using System;
using System.Linq;

namespace _22.__Reversor_de_números
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine(InvierteNumeros(492374));
			Console.WriteLine(InvierteNumeros(InvierteNumeros(787878) + 10));

			Console.ReadKey();
		}

		private static int InvierteNumeros(int numero)
		{
			var cadena = Convert.ToString(numero).ToCharArray();

			Array.Reverse(cadena);

			return Convert.ToInt32(new string(cadena));
		}
	}
}