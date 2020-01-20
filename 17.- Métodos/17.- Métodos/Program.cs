using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.__Métodos
{
	class Program
	{
		static void Main(string[] args)
		{
			MostrarMenu();

			int select = ObtenerSelect();
			Tuple<double, double> numeros = ObtenerNumero();
			double n1 = numeros.Item1;
			double n2 = numeros.Item2;

			Calculadora(select, n1, n2);


			Console.ReadKey();
		}

		private static void Calculadora(int select, double n1, double n2)
		{
			switch (select)
			{
				case 1: Console.WriteLine($"Suma: {n1} + {n2} = {n1 + n2} "); break;
				case 2: Console.WriteLine($"Resta: {n1} - {n2} = {n1 - n2} "); break;
				case 3: Console.WriteLine($"Multiplicación: {n1} * {n2} = {n1 * n2} "); break;
				case 4: Console.WriteLine($"División: {n1} / {n2} = {n1 / n2} "); break;
				default: Console.WriteLine("Opción no contemplada."); break;
			}
		}

		static void MostrarMenu()
		{
			Console.WriteLine("## Menú ##");
			Console.WriteLine("1.- Suma");
			Console.WriteLine("2.- Resta");
			Console.WriteLine("3.- Multiplicación");
			Console.WriteLine("4.- División");
		}

		static int ObtenerSelect()
		{
			Console.WriteLine("Introduce número: ");
			int select = Convert.ToInt32(Console.ReadLine());

			return select;
		}

		static Tuple<double, double> ObtenerNumero()
		{
			Console.WriteLine("Introduce primer número: ");
			double numero1 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Introduce segundo número: ");
			double numero2 = Convert.ToDouble(Console.ReadLine());

			return Tuple.Create(numero1, numero2);
		}
	}
}
