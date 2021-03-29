using System;

namespace PrimeiroProjetoTeste.src.model
{
    class User
    {
        private string name;
        public string Name { get; set; }

        public User()
        {
            this.name = "teste";
            this.Name = "teste";
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }


        public void VerifyName()
        {
            if (this.name == this.Name)
            {
                Console.WriteLine("{0} e {1} são iguais", this.name, this.Name);
            }
            else
            {
                Console.WriteLine("{0} e {1} NÃO são iguais", this.name, this.Name);
            }
        }

    }
}
