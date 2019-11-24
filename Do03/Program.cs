using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do03
{
    class Program
    {
        //SOlicitar cadena entre [10,20] caracteres
        static void Main(string[] args)
        {
            string nombre;

            do
            {
                Console.Write("Nombre [10,20] caracteres: ");
                nombre = Console.ReadLine();
            } while (nombre.Trim().Length < 10 || nombre.Trim().Length >20);

            Console.WriteLine("Nombre ingresado: " + nombre);
            Console.ReadKey();
        }
    }
}
