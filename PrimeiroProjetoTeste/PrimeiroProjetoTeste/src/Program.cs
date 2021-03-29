using PrimeiroProjetoTeste.src;
using PrimeiroProjetoTeste.src.model;
using System;

namespace PrimeiroProjetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------Primeiro Exercicio
            //User novoUsuario = new();

            //novoUsuario.VerifyName();

            //novoUsuario.Name = "Adilson";
            //Console.WriteLine(novoUsuario.Name);

            //novoUsuario.SetName("Juliano");
            //Console.WriteLine(novoUsuario.GetName());


            //----------------------------------Segundo Exercicio
            //LetrasFrequentes.VerifyLetters("paralelepipedo");

            //----------------------------------Terceiro Exercicio
            GiroDaPalavra test = new("gemlingua", "emlinguag");

            Console.WriteLine(test.Teste());

        }
    }
}
