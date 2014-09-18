using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Bola b1 = new Bola();
            Bola b2 = new Bola();           
            Bola b3 = new Bola();
            Console.WriteLine(Bola.numBolas);

            Matematica.Somar(20, 5);
            Console.WriteLine(Matematica.resultado);
        }
    }

    class Bola
    {
        public static int numBolas;
        
        public Bola()
        {
            numBolas++;
        }
    }

    class Matematica
    {
        public static int resultado;

        public static void Somar(int a, int b)
        {
            resultado = a + b;
        }
    }
}
