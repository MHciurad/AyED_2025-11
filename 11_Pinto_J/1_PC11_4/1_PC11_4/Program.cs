using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             TP 4 - Etapa 1
             
             Para poder cobrar la beca JuanPedro se debe cumplir con alguna de las siguientes condiciones... 
             1) ser mayor de 19 años y tener unos ingresos iguales o inferiores a $100.000 mensuales
             2) ser menor de 19 y no poseer ingresos mensuales
             3) tener 19 años y poseer ingresos hasta $50.000 mensuales
             
             Escribir un programa que pregunte al usuario su edad y sus ingresos 
             y muestre por pantalla si el usuario puede cobrar o no.
             
             */

            int edad;
            int ingresos;

            Console.Write("indique su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("indique sus ingresos: ");
            ingresos = int.Parse(Console.ReadLine());

            if (edad > 19 && ingresos <= 100000)
            {
                Console.WriteLine("puede acceder a la Beca");
            }
            else if (edad < 19 && ingresos == 0)
            {
                Console.WriteLine("puede acceder a la beca");
            }
            else if (edad == 19 && ingresos <= 50000)
            {
                Console.WriteLine("puede acceder a la beca");
            }
            else
            {
                Console.WriteLine("no puede acceder a la beca");
            }
            Console.ReadKey();
        }
    }
}
