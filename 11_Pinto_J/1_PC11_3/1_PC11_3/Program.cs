using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             TP 3 - Etapa 1
            
             Escribir un programa que pida al usuario un número entero y muestre por pantalla si es par o impar.
             
             Y... ¿Si es 0?
             */

            int numero;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("cero (0)");
            }
            else if ((numero % 2) == 0)
            {
                Console.WriteLine("el numero es par");
            }
            else if ((numero % 2)== 1)
            {
                Console.WriteLine("el numero es impar");
            }

            Console.ReadKey();
        }
    }
}
