using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Tasks
{
    public class Exemplo4
    {
        protected static HttpClient HttpClient;

        public Exemplo4()
        {
            HttpClient = new();
        }

        private static async Task GetPostFromJson()
        {
            try
            {
                HttpClient = new();
                var response = HttpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/1").Result;
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    var teste = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(teste);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um problema na ");
            }
        }

        public static void DoSomething()
        {
            var teste = GetPostFromJson();
            teste.Wait();
            Console.WriteLine("Executou");
        }
    }
}