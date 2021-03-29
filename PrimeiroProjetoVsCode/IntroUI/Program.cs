using System;
using IntroLibrary;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel{
                FistName = "Tim",
                LastName = "Test"
            };

            System.Console.WriteLine($"Olá, { p.FistName } {p.LastName}.");
            Console.WriteLine("Hello World!");
            Console.WriteLine("this is a tast");
        }
    }
}
