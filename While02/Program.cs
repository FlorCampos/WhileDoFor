using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While02
{
    class Program
    {
        //pide valor entero y mostrarlo al revés
        //Ingreso : 1234
        //Salida : 4321
        static void Main(string[] args)
        {
            Console.Write("\n\tIngrese entero: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tSalida: ");

            while (x > 0)
            {
                int dig = x % 10;
                Console.Write(dig);
                x /= 10;  
            }
            
            Console.ReadKey();

        }
    }
}
