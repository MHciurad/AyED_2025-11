using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             TP 2 - Etapa 0
             Desarrollar un codigo en el que almacenemos el nombre en una variable
             'nombre´y la edad en la variable 'edad'
             Finalmente debe saludar "Hola NOMBRE , tu edad es EDAD"
             */

            //Declaramos Variables

            string nombre;
            string edad;

            //Instanciamos

            nombre = "Leonel Pinto";
            edad = "16";

            //Imprimimos

            Console.WriteLine("Hola " + nombre + " tu edad es: " + edad);
            Console.ReadKey();
        }
    }
}
