using System.Net;
using System.Net.Http.Json;

class Program
{
    private static void Main(string[] args)
    {
        HttpClient client = new HttpClient();

        var requestMessage = new HttpRequestMessage()
        {
            RequestUri = new Uri("https://localhost:7224/home"),
            Method = HttpMethod.Get,
        };

        var responseMessage = client.Send(requestMessage);
        if (responseMessage.IsSuccessStatusCode)
        {
            var reader = new StreamReader(responseMessage.Content.ReadAsStream());
            Console.WriteLine("Request message: " + reader.ReadToEnd());
        }
        else
        {
            Console.WriteLine($"Request error: {responseMessage.StatusCode}");
        }

        requestMessage = new HttpRequestMessage();
        requestMessage.RequestUri = new Uri("https://localhost:7224/Info");
        requestMessage.Content = JsonContent.Create(new
        {
            Name = "Hello kity",
            Birth = "2019",
            Age = 20
        });

        responseMessage = client.Send(requestMessage);


        if (responseMessage.IsSuccessStatusCode)
        {
            var reader = new StreamReader(responseMessage.Content.ReadAsStream());
            Console.WriteLine("Request message: " + reader.ReadToEnd());
        }
        else
        {
            Console.WriteLine($"Request error: {responseMessage.StatusCode}");
        }

        Console.ReadLine();
    }
}