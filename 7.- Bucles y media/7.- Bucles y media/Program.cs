using System;

namespace _7.__Bucles_y_media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Calculadora de medias de exámenes ##");

            int numNotas = 0;
            double media = 0;

            Console.Write("¿Cuántos exámenes has realizado? ");

            numNotas = Convert.ToInt32(Console.ReadLine());

            media = calculaMedia(numNotas, media);

            Console.WriteLine("La media final es: " + media);

            Console.ReadKey();
        }

        private static double calculaMedia(int numNotas, double media)
        {
            for (int i = 0; i < numNotas; i++)
            {
                Console.Write("Introduce nota nº " + i + ": ");
                media += (Convert.ToDouble(Console.ReadLine()) / numNotas);
            }

            return media;
        }
    }
}
