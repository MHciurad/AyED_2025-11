using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             TP 2 - Etapa 1

             Escribir un programa que pida al usuario dos números y muestre por pantalla su división. 
             Si el divisor es cero el programa debe mostrar un error.
             */

            int num1;
            int num2;
            int resultado;

            Console.Write("ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("ingrese el primer numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("la division sera: " + num1 + "/" + num2);

            

            if(num2 == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                resultado = num1 / num2;
                Console.WriteLine("el resultado de la divison es: " + resultado);
            }
            Console.ReadKey();
        }
    }
}
