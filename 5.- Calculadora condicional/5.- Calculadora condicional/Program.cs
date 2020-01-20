using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.__Calculadora_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a la calculadora.");
            Console.WriteLine("Introduce operación: " + Environment.NewLine +
                              "1.- Suma" + Environment.NewLine +
                              "2.- Resta" + Environment.NewLine +
                              "3.- Multiplicación" + Environment.NewLine +
                              "4.- División" + Environment.NewLine);

            int operacion = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce número 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce número 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double resultado;

            if (operacion == 1) { resultado = n1 + n2; }
            else if (operacion == 2) { resultado = n1 - n2; }
            else if (operacion == 3) { resultado = n1 * n2; }
            else if (operacion == 4) { resultado = n1 / n2; }
            else {
                Console.WriteLine("Operación incorrecta.");
                return;
            }

            Console.WriteLine("El resultado es " + resultado);

            Console.ReadKey();
        }
    }
}
