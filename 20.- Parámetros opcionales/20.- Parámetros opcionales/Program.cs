using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.__Parámetros_opcionales
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		static int Suma(int n1, int n2, int n3 = 0)
		{
			return n1 + n2 + n3;
		}
	}
}
