using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.__Sobrecarga_de_métodos
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Suma(1,3));
			Console.WriteLine(Suma(1.32,3.22));

			Console.ReadKey();
		}

		static int Suma(int n1, int n2)
		{
			return n1 + n2;
		}

		static double Suma(double n1, double n2)
		{
			return n1 + n2;
		}


	}
}
