using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break01
{
    class Program
    {
        //pide valores hasta que se ingrese cero
        //finalmente imprimir la suma de todos
        static void Main(string[] args)
        {
            double sum = 0;
            
            while (true)
            {
                Console.Write("Valor [0==FIN]: ");
                double x = Convert.ToDouble(Console.ReadLine());

                if (x == 0)
                {
                    break;
                }

                sum += x;
            }

            Console.WriteLine("Suma: " + sum);
            Console.ReadKey();
        }
    }
}
