using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do04
{
    class Program
    {
        //Solicitar y validar valor positivo(>0)
        static void Main(string[] args)
        {

            double valor;

            do
            {
                Console.Write("Valor positivo (>0):");
                valor = Convert.ToDouble(Console.ReadLine());
            } while (valor <= 0); //mientras siga siendo verdadero,, regresa al do.

            Console.WriteLine("Valor ingresado: " + valor);
            Console.ReadKey();
        }
    }
}
