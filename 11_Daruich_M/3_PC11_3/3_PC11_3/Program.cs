using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC11_3
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("indique la cantidad de alumnos");
            n = int.Parse(Console.ReadLine());
            string[,] matriz = new string[n, 3];
            n = n + 1;

            llenmatriz(matriz);
            ImprimirMatriz(matriz);
        }

        // Método que recibe una matriz bidimensional
        static void ImprimirMatriz(string[,] m)
        {

     

            for (int i = 0; i < m.GetLength(0); i++) // filas
            {
                for (int j = 0; j < m.GetLength(1); j++) // columnas
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void llenmatriz(string[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++) // filas
            {

                string nombre, edad, calificacion;
                Console.WriteLine("ingrese el nombre del alumno");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese la edad del alumno");
                edad = Console.ReadLine();
                Console.WriteLine("ingrese la calificacion del alumno");
                calificacion = Console.ReadLine();
                m[i, 0] = nombre;
                m[i, 1] = edad;
                m[i, 2] = calificacion;
            }
        }

    }
}