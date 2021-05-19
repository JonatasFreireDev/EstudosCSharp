using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    public class Program
    {
        //https://docs.microsoft.com/pt-br/dotnet/api/system.threading.tasks.task?view=net-5.0

        public static void Main(string[] args)
        {
            Exemplo4.DoSomething();
            Console.ReadLine();
        }
    }
}