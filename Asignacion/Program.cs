using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x, y, z;
            //x = y = z = 20;

            ////Lo que no debemos hacer :
            //// x= 20 + (y = 45 + ( z = 5));

            //Console.WriteLine("x: " + x + ", y: " + y + ", z: " + z);


            //Grupo 2 : Asignaciones Abreviadas
            int x = 10;
            Console.WriteLine("x contiene: " + x);

            x += 5;
            Console.WriteLine("x += 5 retorna: " + x);

            x -= 3;
            Console.WriteLine(" x -= 3 retorna: " + x);

            x *= 2;
            Console.WriteLine("x *= 2 retorna: " + x);

            x /= 6;
            Console.WriteLine("x /= 6 retorna: " + x);

            x %= 7;
            Console.WriteLine("x %= 7 retorna: " + x);

            Console.ReadKey();
        }
    }
}
