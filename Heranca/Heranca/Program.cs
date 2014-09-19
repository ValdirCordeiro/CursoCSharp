using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
           // Animal a = new Animal();
            Cachorro a = new Cachorro();
            a.Peso = 4;
            a.Altura = 0.8;
            

            a.Mover();
            a.MostrarDados();
            a.Latir();
        }
    }
}
