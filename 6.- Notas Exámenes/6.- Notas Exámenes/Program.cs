using System;

namespace _6.__Notas_Exámenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Programa calculador de media ##");
            Console.Write("Introduce nota 1: "); double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce nota 2: "); double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce nota 3: "); double n3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce nota 4: "); double n4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce nota 5: "); double n5 = Convert.ToDouble(Console.ReadLine());

            double media = (n1 + n2 + n3 + n4 + n5) / 5;
            Console.WriteLine("Media: " + media);
            bool estaAprobado = media >= 5;
            if (estaAprobado) { Console.WriteLine("Estás aprobado."); }
            else { Console.WriteLine("Estás suspenso."); }


            Console.ReadKey();
        }
    }
}