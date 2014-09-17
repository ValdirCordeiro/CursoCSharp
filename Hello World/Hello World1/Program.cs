using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            switch (x)
            {
                case 0:

                case 1:
                    Console.WriteLine("Fevereiro");
                    break;

                default:
                    Console.WriteLine("Inválido");
                    break;
            }
            
            System.Console.WriteLine(" Hello World em C#");


        }
    }
}
