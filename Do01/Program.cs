using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do01
{
    class Program
    {
        //validar ingreso de nota [0,20]
        static void Main(string[] args)
        {
            int nota; 
            do
            {

                Console.Write("Nota [0,20]: ");
                nota = Convert.ToInt32(Console.ReadLine());

            } while (nota < 0 || nota > 20);

            Console.WriteLine("Nota Ingresada: " + nota);
            Console.ReadKey();
        }
    }
}
