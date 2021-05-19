using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Console
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            swaggerClient client = new("https://localhost:44300", new HttpClient());

            var records = await client.WeatherForecastAsync();

            foreach (var r in records)
            {
                System.Console.WriteLine($"{r.Date}: {r.Summary}");
            }
        }
    }
}