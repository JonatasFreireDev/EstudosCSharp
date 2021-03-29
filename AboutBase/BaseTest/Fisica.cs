using System;

namespace BaseTest
{
    public class Fisica : Pessoa
    {
        public Fisica(string nome, int peso) : base(nome, peso)
        {
            Console.WriteLine(@"Classe Pessoa {0}", Nome);
        }
    }
}
