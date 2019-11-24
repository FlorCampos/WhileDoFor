using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While03
{
    class Program
    {
        //pide valores hasta que se ingrese cero
        //finalmente imprimir la suma de todos
        static void Main(string[] args)
        {
            double sum = 0;
            bool sigue = true;

            while (sigue)
            {
                Console.Write("Valor [0==FIN]: ");
                double x = Convert.ToDouble(Console.ReadLine());

                sum += x;

                //Primera forma
                //if (x == 0)
                //{
                //    sigue = false;
                //}

                //Segunda forma
                //sigue = (x == 0) ? false : true;

                //Tercer forma
                sigue = !(x == 0);

            }

            Console.WriteLine("Suma: " + sum);
            Console.ReadKey();

        }
    }
}
