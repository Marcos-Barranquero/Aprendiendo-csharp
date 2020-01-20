using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.__Tipos_de_datos_y_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce número 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce número 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La suma de ambos números es: " + (n1 + n2));
            Console.WriteLine("La resta de ambos números es: " + (n1 - n2));
            Console.WriteLine("La división de ambos números es: " + (n1 / n2));
            Console.WriteLine("La multiplicación de ambos números es: " + (n1 * n2));
            Console.WriteLine("El resto de dividir ambos números es: " + (n1 % n2));





            Console.ReadKey();
        }
    }
}
