using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.__Num_entre_1_y_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(num <= 1000)
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                    System.Console.WriteLine("HUehueh");
                }
                num++;
            }

            for (;;)
            {
                break;
            }
            Console.ReadKey();
        }
    }
}
