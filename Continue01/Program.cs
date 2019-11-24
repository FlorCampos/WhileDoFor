using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue01
{
    class Program
    {
        //imprimir los múltiplos de 7 de 2 dígitos
        static void Main(string[] args)
        {
            int x = 9;

            while (x < 99)
            {
                ++x;
                if (x % 7 !=0)
                {
                    continue; // del continue salta a while e ignora al Console.WriteLine(x);
                }
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
