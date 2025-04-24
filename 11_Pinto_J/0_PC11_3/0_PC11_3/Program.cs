using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             TP 3 - Etapa 0
             Desarrollar un codigo en el que almacenemos el nombre en una variable
             'nombre' y la edad en la variable 'edad'
             Los datos deben ser ingresados por el usuario
             Finalmente debe saludar "Hola NOMBRE, tu edad es: EDAD"
             */

            //Declaramos variables

            string nombre;
            int edad;


            //UI - User Interface
            Console.Write("¿Cual es tu nombre?: ");



            //Instancia el usuario
            nombre = Console.ReadLine();
            Console.WriteLine("Tu nombre es: " + nombre);

            Console.Write("¿Cual es tu edad?: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Tu edad es: " + edad);

            Console.WriteLine("Hola " + nombre + ", tu edad es: " + edad);
            Console.ReadKey();

        }
    }
}
