using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _16.__Operaciones_con_strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string cadena = " p aLAl kSdj    ";
			string lista = "Marina, Alberto, Chema, Antonio";

			Console.WriteLine($"Cadena es: {cadena}");
			Console.WriteLine($"Cadena en minúscula es: {cadena.ToLower()}");
			Console.WriteLine($"Cadena en mayúscula es: {cadena.ToUpper()}");
			Console.WriteLine($"Cadena sin espacios laterales es: {cadena.Trim()} ");

			char[] palabra = cadena.ToCharArray(); // Covertir cadena a array de chars

			string[] nombres = lista.Split(',');

			foreach (var nombre in nombres)
			{
				Console.WriteLine(nombre.Trim());
			}

			string numeros = "1 - 2 - 3 - 4 - 5 - 6";
			numeros = numeros.Replace(" -", ",");
			Console.WriteLine(numeros);

			Console.ReadKey();
		}


	}
}
	

