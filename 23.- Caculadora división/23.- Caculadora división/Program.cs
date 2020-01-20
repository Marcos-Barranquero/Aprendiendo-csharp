using System;

namespace _23.__Caculadora_división
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int n1, n2, division;


			Console.Write("Introduce n1: ");

			n1 = recoger_Numero();


			Console.Write("Introduce n2: ");
			n2 = recoger_Numero();

			Console.WriteLine($"El primer número es {n1} y el segundo es {n2}");
			division = n1 / n2;
			Console.WriteLine($"{n1} / {n2} = {division}");


			Console.ReadKey();

		}

		private static int recoger_Numero()
		{
			int numero = 0;
			bool conversion_correcta = false;
			while (!conversion_correcta)
			{
				conversion_correcta = int.TryParse(Console.ReadLine(), out numero);
				if (!conversion_correcta || numero==0)
				{
					Console.Write("Valor no válido. Debes introducir un número != 0: ");
					conversion_correcta = false;
				}
			}
			return numero;
		}
	}
}