using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementoDecremento
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("x contiene: " + x);

            ++x;
            Console.WriteLine("++x adiciona 1 y contiene: " + x);

            x++;
            Console.WriteLine("x++ adiciona 1 y contiene: " + x);

            --x;
            Console.WriteLine("--x sustrae 1 y contiene: " + x);

            x--;
            Console.WriteLine("x-- sustrae 1 y contiene: " + x);

            //LO QUE NO SE DEBE HACER

            int y;
            y = ++x; //
            Console.WriteLine("x: " + x + ", y: " + y);

            y = x++;
            Console.WriteLine("x: " + x + ", y: " + y);

            Console.ReadKey();
        }
    }
}
