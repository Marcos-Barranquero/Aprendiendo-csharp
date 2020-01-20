using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.__Mayor_de_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Operadores lógicos:
             * >  Mayor que
             * <  Menor que
             * == Igual que
             * != Diferente de
             * !  Negación
             * 
             * || Operador OR
             * && Operador AND
             */

            bool mayorEdad = false;

            Console.Write("Introduce tu edad: ");
            int edad = Int32.Parse(Console.ReadLine());

            mayorEdad = edad > 18;

            if (edad > 0 && edad < 120)
            {
                if (edad < 12)
                { Console.WriteLine("Eres muy pequeño."); }
                else if (edad < 18)
                { Console.WriteLine("Lo siento, tienes que esperar un poco."); }
                else if (edad > 18)
                { Console.WriteLine("Eres mayor de 18."); }

            }
            else
            {
                Console.WriteLine("La edad no es válida");
            }

            Console.ReadKey();
        }

    }
}
