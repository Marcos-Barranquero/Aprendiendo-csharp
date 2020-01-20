using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace _15.__Switch
{
	class Program
	{
		static void Main(string[] args)
		{
			double n1, n2;
			char select;

			Console.WriteLine("Hola, bienvenido a la calculadora.");

			Console.Write("Introduce número 1: ");
			n1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Introduce número 2: ");
			n2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Operaciones: ");
			Console.WriteLine("s.- Suma: ");
			Console.WriteLine("r.- Resta ");
			Console.WriteLine("m.- Multiplicación ");
			Console.WriteLine("d.- División ");

			Console.WriteLine("¿Qué desea hacer? (Introduce s,r,m ó d según lo que desees): ");
			select = Convert.ToChar(Console.ReadLine());

			switch (select)
			{
				case 's':
					Console.WriteLine($"Suma: {n1} + {n2} = {n1 + n2} "); break;
				case 'r':
					Console.WriteLine($"Resta: {n1} - {n2} = {n1 - n2} "); break;
				case 'm':
					Console.WriteLine($"Multiplicación: {n1} * {n2} = {n1 * n2} "); break;
				case 'd':
					Console.WriteLine($"División: {n1} / {n2} = {n1 / n2} "); break;
				default:
					Console.WriteLine("Operación inválida."); break;
			}



			Console.ReadKey();
		}
	}
}
