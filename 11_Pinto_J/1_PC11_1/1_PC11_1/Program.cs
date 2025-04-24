using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             TP 1 - Etapa 1
             
             Escribir un programa que almacene la cadena de caracteres contraseña en una variable, 
             pregunte al usuario por la contraseña e imprima por pantalla si la contraseña introducida 
             por el usuario coincide con la guardada en la variable sin tener en cuenta mayúsculas 
             y minúsculas.

             */

            string contraseña;
            string contraseñaguardada;

            contraseñaguardada = "contraseñacompletamentesegura";

            Console.Write("Ingrese su contraseña: ");
            contraseña = Console.ReadLine();

            if (contraseña.ToUpper() == contraseñaguardada.ToUpper())
            {
                Console.WriteLine("La contraseña es correcta");
            }
            else
            {
                Console.WriteLine("La contraseña es incorrecta, intentelo nuevamente");
            }
            Console.ReadKey();
        }
    }
}
