using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do02
{
    class Program
    {
        //validar ingreso de 3 notas [0,20]
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;

            //validado nota 1
            do
            {

                Console.Write("Nota [0,20]: ");
                nota1 = Convert.ToInt32(Console.ReadLine());

            } while (nota1 < 0 || nota1 > 20);

            //validado nota 2
            do
            {

                Console.Write("Nota [0,20]: ");
                nota2 = Convert.ToInt32(Console.ReadLine());

            } while (nota2 < 0 || nota2 > 20);

            //validado nota 3
            do
            {

                Console.Write("Nota [0,20]: ");
                nota3 = Convert.ToInt32(Console.ReadLine());

            } while (nota3 < 0 || nota3 > 20);

            Console.WriteLine("Nota Ingresada1: " + nota1);
            Console.WriteLine("Nota Ingresada2: " + nota2);
            Console.WriteLine("Nota Ingresada3: " + nota3);
            Console.ReadKey();
        }
    }
}
