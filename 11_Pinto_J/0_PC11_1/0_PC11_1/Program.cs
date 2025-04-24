using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC11_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             TP 1 - Etapa 0
             Utilizando variable tipo string definir un programa que almacene
             en una variable una cadena que sea "Hola Mundo!" e imprimirla
            */

            //TipoDato nombredeVariable;
            //nombreDeVariable = Dato;

            //tipoDato nombreVariable = dato;

            //Caso 1

            string variable1;  // Declaramos la variable
            variable1 = "Hola Mundo!";  // instanciamos variables
            Console.WriteLine(variable1);   // imprimimos la variable
            Console.ReadKey();


            //Caso 2

            string variable2 = "Hola Mundo!";   //  Manera mas optimizada
            Console.WriteLine(variable2);
            Console.ReadKey();
        }
    }
}
