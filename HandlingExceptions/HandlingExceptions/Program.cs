using ExceptionsLibrary;
using System;

namespace HandlingExceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DemoCode demo = new();

            try
            {
                int result = demo.GrandParentMethod(3);
                Console.WriteLine($"The value is {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("You gave us bad information.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                var inner = ex.InnerException;

                while (inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }

            Console.ReadLine();
        }
    }
}