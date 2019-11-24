using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._SumaNumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escriba un programa que calcule e imprima la suma todos los números impares desde cero
               hasta un número N dado como dato.
             */

            Console.Write("Ingrese número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int i = 0, sum = 0;
               
            while (i <= numero)
            {
                if (i % 2 == 1 || i == 0)
                {
                    Console.Write(i + " + ");
                    sum += i;
                }
                ++i;
            }

            Console.Write("\b\b= " + sum);
            Console.ReadKey();
        }
    }
}
