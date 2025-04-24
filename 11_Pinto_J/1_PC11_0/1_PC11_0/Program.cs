using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             TP 0 - Etapa 1
             
             Escribir un programa que pregunte al usuario 
             su edad y muestre por pantalla si es mayor de edad o no.

             */

            int edad;

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("El usuario es mayor de edad");
            }
            else
            {
                Console.WriteLine("El usuario es menor de edad");
            }
            Console.ReadKey();
        }
    }
}
