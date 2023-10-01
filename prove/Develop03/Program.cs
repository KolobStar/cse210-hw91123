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
        HttpClient client = new HttpClient();
        Console.WriteLine("Scripture memorized");
        var test = request(client, endpoint + $"/bibles/{bibleId}/books");
        Console.WriteLine(test.Result);
        Book book = JsonConvert.DeserializeObject<Book>(test.Result);
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
