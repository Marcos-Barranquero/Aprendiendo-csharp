using System;

namespace _13.__Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] numeros = new int[5];

            numeros[0] = 4;
            numeros[1] = 3;
            numeros[2] = 2;
            numeros[3] = 6;
            numeros[4] = 5;



            //Bucle for each 
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
