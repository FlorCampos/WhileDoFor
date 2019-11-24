using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While01
{
    class Program
    {   //pide valor entero y muestra suma de dígitos
        static void Main(string[] args)
        {
            Console.Write("Ingrese entero: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int sum = 0; //? porque cero

            while (x > 0)
            {
                int dig = x % 10; 
                sum += dig;
                x /= 10;  // 1 entre 10 = 0
            }

            Console.WriteLine("Suma de dígitos: " + sum);
            Console.ReadKey();

        }
    }
}
