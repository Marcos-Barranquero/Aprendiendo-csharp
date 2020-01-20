using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.__Ruleta
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinero = 1000;
            bool seguir = true;

            while (seguir)
            {
                int numeroElegido, numeroAleatorio;
                double apuesta;
                do
                {
                    Console.Clear();
                    Console.Write("Introduce cuánto quieres apostar: ");
                    apuesta = Convert.ToInt32(Console.ReadLine());
                } while (apuesta > dinero || apuesta < 1);
                do
                {
                    Console.Write("Introduce el número por el que quieres apostar(1-36): ");
                    numeroElegido = Convert.ToInt32(Console.ReadLine());

                } while (numeroElegido < 0 || numeroElegido > 36);

                Random random = new Random();
                numeroAleatorio = random.Next(0, 37);

                if (numeroAleatorio == numeroElegido)
                {
                    Console.WriteLine("¡Enhorabuena! Ha caído tu número.");
                    dinero += apuesta * 36;
                }
                else
                {
                    Console.WriteLine("Lo siento, ha caído el " + numeroAleatorio);
                    dinero -= apuesta;
                }

                if (dinero > 0)
                {
                    Console.WriteLine("Tu saldo es de: " + dinero);
                    Console.Write("Escribe N si no deseas continuar, si no, pulsa cualquier otra tecla: ");
                    string respuesta = Console.ReadLine();
                    if ((respuesta.Equals("N")))
                    {
                        seguir = false;
                    }
                }

            }

            Console.WriteLine("Saliendo del juego...");


            Console.ReadKey();
        }
    }
}
