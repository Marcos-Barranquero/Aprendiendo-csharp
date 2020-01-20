using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.__Media_con_do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool soyGuapo = false;
            do
            {
                Console.Write("Dime que soy guapo o voy a seguir pidiéndotelo: ");
                string input = Console.ReadLine();
                if(input.Equals("Eres guapo."))
                {
                    soyGuapo = true;
                }

            } while (!soyGuapo);

            Console.WriteLine("Si ya lo sé.");
            Console.ReadKey();
        }
    }
}
