using System.Net;
using System;
using System.Net.WebSockets;
using System.Text.Json;
using System.Text.RegularExpressions;
class Program
{
     static string apiKey = "f715bda8283e1b2334a99b3cb970adbd";
     static string bibleId = "de4e12af7f28f599-02";
     static string endpoint = "https://api.scripture.api.bible/v1";
     static void Main(string[] args)
     {
          HttpClient client = new HttpClient();
          client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
          Console.WriteLine("Scripture memorized");
          var bookRequest = request(client, endpoint + $"/bibles/{bibleId}/books");
          JSONBookData? books = JsonSerializer.Deserialize<JSONBookData>(bookRequest.Result);
          Random random = new Random();
          int bookIndex = random.Next(books.data.Length);
          var chapterRequest = request(client, endpoint + $"/bibles/{bibleId}/books/{books.data[bookIndex]}/chapters");
          JSONChapterData? chapters = JsonSerializer.Deserialize<JSONChapterData>(chapterRequest.Result);
          int chapterIndex = random.Next(1, chapters.data.Length);
          string query = "?content-type=text&include-notes=false&include-titles=false&include-chapter-numbers=false&include-verse-numbers=true&include-verse-spans=false";
          int verseId = 1;
          var versesRequest = request(client, endpoint + $"/bibles/{bibleId}/chapters/{chapters.data[chapterIndex]}"+query);
          Chapter verses = JsonSerializer.Deserialize<JSONVersesData>(versesRequest.Result).data;//versesResults[0]);
          verses.CreateScripture(0, 3);
          TestScripture(verses, true);
          Console.ReadLine();
     }

     static void TestScripture(Chapter chapter, bool hidden = false){
          if(hidden){
               for(int i = 0; i < chapter.scripture.Count; i++){
                    int r = new Random().Next(100);
                    if(r < 30){
                         chapter.HideWord(i);
                    }
               }
          }
          Console.WriteLine(chapter.Scripture());
     }

     static void Test(Chapter json)
     {
          string dataType = "Verses";
          //Console.WriteLine($"{dataType} Length: {json.data.Length}");
          Console.WriteLine($"{dataType} Id: {json.reference}");
          Console.WriteLine($"{dataType} Content: {json.content}");
     }

     static async Task<string> request(HttpClient client, string endPoint)
     {
          HttpRequestMessage request = new HttpRequestMessage();
          request.RequestUri = new Uri(endPoint);
          request.Headers.Add("api-key", apiKey);
          HttpResponseMessage response = await client.SendAsync(request);
          var message = await response.Content.ReadAsStringAsync();

          return message;
     }
}
