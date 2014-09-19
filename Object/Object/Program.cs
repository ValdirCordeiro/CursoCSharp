using System;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            c.Marca = "Fiat";
            c.Ano = 2010;
            Console.WriteLine(c);

            int x = 10;
            string s = x.ToString();

            string s2 = 10.ToString();

            true.Equals(true);
            21.3.Equals(10);
        }
    }

    public class Carro
    {
        public string Marca { get; set; }
        public int Ano { get; set; }

        public override string ToString()
        {
            return Marca + " , " + Ano;
        }
    }
}
