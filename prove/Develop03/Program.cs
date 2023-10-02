using System.Net;
using System;
using System.Net.WebSockets;
using System.Text.Json;
class Program
{
    static string apiKey = "f715bda8283e1b2334a99b3cb970adbd";
    static string bibleId = "de4e12af7f28f599-02";
    static string endpoint = "https://api.scripture.api.bible/v1";
    static void Main(string[] args)
    {
        Random random = new Random();
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        Console.WriteLine("Scripture memorized");
        var bookrequest = request(client, endpoint + $"/bibles/{bibleId}/books");
        //Console.WriteLine(test.Result);
        JSONBookData books = JsonSerializer.Deserialize<JSONBookData>(bookrequest.Result);
        int bookindex = random.Next(books.data.Length);
        var chapterrequest = request(client, endpoint + $"/bibles/{bibleId}/books/{books.data[bookindex]}/chapters");
        JSONChapterdata chapters = JsonSerializer.Deserialize<JSONChapterdata>(chapterrequest.Result);
        int chapeterindex = random.Next(chapters.data.Length);
        var Versesrequest = request(client, endpoint + $"/bibles/{bibleId}/chapters/{chapters.data[chapeterindex]}");
        JSONVersesdata Verses = JsonSerializer.Deserialize<JSONVersesdata>(Versesrequest.Result);
        Console.ReadLine();
    }


    static async Task<string> request(HttpClient client, string endPoint)
    {
        HttpRequestMessage request = new HttpRequestMessage();
        request.RequestUri = new Uri(endPoint);
        request.Headers.Add("api-key", apiKey);
        HttpResponseMessage response = await client.SendAsync(request);
        var message = await response.Content.ReadAsStringAsync();

        /*response.Wait();
        if (response.IsCompleted)
        {
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var message = result.Content.ReadAsStringAsync();
                message.Wait();
                return message.ToString();
            }
        }
        */
        return message;
    }
}

//not complete
