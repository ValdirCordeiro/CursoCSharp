using System;

namespace Softblue
{
	class Program
	{
		static void Main()
		{
			//Cria um triângulo, dá valor aos fields e calcula a área
			Triangulo tr = new Triangulo();

            Console.WriteLine("Digite a base do Triângulo:");
            tr.@base = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a altura do Triângulo:");
            tr.altura = double.Parse(Console.ReadLine());
			
            double area = tr.CalcularArea();
			Console.WriteLine("Área triângulo: " + area);
		
			//Cria um quadrado, dá valor aos fields e calcula a área
			Quadrado q = new Quadrado();
            Console.WriteLine("Digiteo lado do Quadrado:");
            q.lado = double.Parse(Console.ReadLine()); ;
			area = q.CalcularArea();
			Console.WriteLine("Área quadrado: " + area);
		
			//Cria uma circunferência, dá valor aos fields e calcula a área
			Circunferencia c = new Circunferencia();
            Console.WriteLine("Digiteo o raio da Circunferência");
            c.raio = double.Parse(Console.ReadLine()); 
			area = c.CalcularArea();
			Console.WriteLine("Área circunferência: " + area);
		
			//Cria um trapézio, dá valor aos fields e calcula a área
			Trapezio tp = new Trapezio();
            Console.WriteLine("Digiteo a base Maior do Trapézio:");
            tp.baseMaior = double.Parse(Console.ReadLine());

            Console.WriteLine("Digiteo a base Menor do Trapézio:");
            tp.baseMenor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digiteo a altura do Trapézio:");
            tp.altura = double.Parse(Console.ReadLine());
			area = tp.CalcularArea();
			Console.WriteLine("Área trapézio: " + area);
		}
	}

	class Triangulo
	{
		// Base (a '@' deve ser usada porque 'base' é uma palavra reservada do C#)
		public double @base;

		// Altura
		public double altura;

		public double CalcularArea()
		{
			double area = @base * altura / 2;
			return area;
		}
	}

	class Quadrado
	{
		// Lado do quadrado
		public double lado;

		public double CalcularArea()
		{
			// Multiplica o lado por ele mesmo
			double area = lado * lado;
			return area;
		}
	}

	class Circunferencia
	{
		// Raio da circunferência
		public double raio;

		public double CalcularArea()
		{
			// Math.PI é a constante que representa o PI (3,14159265...)
			double area = Math.PI * raio * raio;
			return area;
		}
	}

	class Trapezio
	{
		// Altura
		public double altura;

		// Base maior
		public double baseMaior;

		// Base menor
		public double baseMenor;

		public double CalcularArea()
		{
			double area = ((baseMaior + baseMenor) / 2) * altura;
			return area;
		}
	}

	
}
