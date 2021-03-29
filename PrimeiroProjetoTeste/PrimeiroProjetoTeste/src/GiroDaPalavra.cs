using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoTeste.src
{
    class GiroDaPalavra
    {
        public string Word1 { get; set; }
        public string Word2 { get; set; }

        public GiroDaPalavra(string Word1, string Word2)
        {
            this.Word1 = Word1;
            this.Word2 = Word2;
        }

        public int Teste()
        {
            int index1 = 0;

            if (Word1 == Word2)
            {
                return 1;
            }

            foreach (char character in Word1)
            {
                if (index1 == Word2.Length - 1) return 1;

                if (character == Word2[index1 + 1])
                {
                    index1++;
                }
                else if (character == Word2[^1])
                {
                    index1++;
                }
                else if (character == Word2[index1 - 1])
                {
                    index1++;
                }
            }

            return 0;
        }
    }
}
