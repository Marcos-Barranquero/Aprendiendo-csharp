using System;

namespace _9.__Bucle_for_y_tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int cuenta = 0; cuenta <= 10; cuenta++)
                {
                    int multiplicacion = i * cuenta;
                    Console.WriteLine(i + " * " + cuenta + " = " + multiplicacion);
                }
                Console.WriteLine("\n####################\n");

            }

            Console.ReadKey();
        }
    }
}
