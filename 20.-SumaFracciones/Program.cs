using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._SumaFracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escriba un programa que calcule e imprima el valor de la sumatoria de los N primeros
              términos de la serie 1 + 1/2 + 1/4 + 1/8 + 1/16+...*/

            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1; //indice : i
            double sum = 0;
            double d = 1;

            while ( i <= n)
            {
                double numerador = 1;
                double denominador = d;

                sum += numerador / denominador;

                d *= 2;
                ++i;
            }

            Console.WriteLine("Suma: " + sum);
            Console.ReadKey();
        }
    }
}
