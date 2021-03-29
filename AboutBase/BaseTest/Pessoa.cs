using System;

namespace BaseTest
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public float Peso { get; set; }

        public Pessoa()
        {
            Nome = "Padrao";
            Peso = 10.0f;
        }
    
        public Pessoa(string nome, float peso)
        {
            Nome = nome;
            Peso = peso;
            Console.WriteLine(@"Classe Pessoa {0}", Nome);
        }
    }
}
