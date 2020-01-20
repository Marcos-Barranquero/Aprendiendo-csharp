using System;

namespace _10.__Cálculo_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un nº y calcularé su factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = 1;
            for (int contador = 0; contador < numero; contador++)
            {
                resultado += resultado * contador;
            }

            Console.WriteLine("Resultado: " + resultado);
            Console.ReadKey();
        }
    }
}
