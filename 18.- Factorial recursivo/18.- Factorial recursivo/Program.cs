using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.__Factorial_recursivo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(FactorialRecursivo(-4));

			Console.ReadKey();
		}

		static int FactorialRecursivo(int numero)
		{
			if (numero == 0) { return 1; }
			if (numero < 0){ return 0; }


			return numero * FactorialRecursivo(numero - 1);

		}



	}
}
