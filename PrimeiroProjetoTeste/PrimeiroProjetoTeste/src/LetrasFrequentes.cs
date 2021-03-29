using System;

namespace PrimeiroProjetoTeste.src
{
    class LetrasFrequentes
    {
        public static void VerifyLetters(string InputData)
        {
            char[] dataAsArray = InputData.ToCharArray();

            int DataSize = InputData.Length - 1;

            int MaxTimes = 0;
            char charMaxTimes = 'n';

            int MaxTimes2 = 0;
            char charMaxTimes2 = 'n';

            foreach (char character in dataAsArray)
            {
                int count = 0;
                foreach (char charac in dataAsArray)
                {
                    if (character == charac) count++;
                }

                if (count > MaxTimes)
                {
                    MaxTimes = count;
                    charMaxTimes = character;
                }

                if (count == MaxTimes && charMaxTimes != character)
                {
                    MaxTimes2 = count;
                    charMaxTimes2 = character;
                }

            }
            PrintLetters(MaxTimes,
                         charMaxTimes,
                         MaxTimes2,
                         charMaxTimes2,
                         DataSize);
        }

        private static void PrintLetters(int MaxTimes, char charMaxTimes, int MaxTimes2, char charMaxTimes2, int size)
        {
            double porcent = Math.Round(((double)MaxTimes / (double)size) * 100, 2);
            
            Console.WriteLine(" {0} {1} %", charMaxTimes, porcent);

            if (MaxTimes2 == MaxTimes)
            {
                Console.WriteLine(" {0} {1} %", charMaxTimes2, porcent);
            }
        }
    }
}
