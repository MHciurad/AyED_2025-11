using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * TP 13 - ETAPA 2
             * 
             */

            int n;
            string nombre, edad, calificacion;
            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            n = int.Parse(Console.ReadLine());
            n = n + 1;
            string[,] estudiantes = new string[n, 3];

            estudiantes[0, 0] = "Nombre";
            estudiantes[0, 1] = "Edad";
            estudiantes[0, 2] = "Calificacion";

            for (int f = 1; f < n; f++)
            {
                    Console.WriteLine("ingrese el nombre del alumno");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ingrese la edad del alumno");
                    edad = Console.ReadLine();
                    Console.WriteLine("ingrese la calificacion del alumno");
                    calificacion = Console.ReadLine();
                    estudiantes[f, 0] = nombre;
                    estudiantes[f, 1] = edad;
                    estudiantes[f, 2] = calificacion;
            }

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(estudiantes[f, c] + " \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
