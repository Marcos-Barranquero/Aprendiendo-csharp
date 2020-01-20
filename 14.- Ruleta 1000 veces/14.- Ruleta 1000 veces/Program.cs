using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.__Ruleta_1000_veces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que juega sólo a la ruleta sin dinero.
            // Una vez termine, sacar por pantalla cuántas veces 
            // ha caído cada número.
            Random random = new Random();
            int numApostado, numRuleta, vecesGanadas=0;
            int[] numGanadores = new int[37];

            for (int repeticiones = 0; repeticiones < 10000; repeticiones++)
            {
                // Generar número por el cual se ha apostado:
                numApostado = random.Next(0, 37);
                Console.WriteLine($"Número apostado: {numApostado}.");

                //Generar número de la ruleta.
                numRuleta = random.Next(0, 37);
                Console.WriteLine($"Ha caído en el número {numRuleta}");

                //Apuntamos el número que ha caído:
                numGanadores[numRuleta]++;

                if (numRuleta == numApostado) 
                {
                    Console.WriteLine("El bot ha ganado.");
                    vecesGanadas++;
                }


            }

            Console.WriteLine("######################");

            //Mostramos estadísticas:
            Console.WriteLine("Estadísticas: ");

            for (int elemento = 0; elemento < numGanadores.Length; elemento++)
            {
                Console.WriteLine($"Veces que ha salido el {elemento}: {numGanadores[elemento]}");
            }

            Console.WriteLine($"Veces ganadas: {vecesGanadas}");

            Console.ReadKey();
        }
    }
}
