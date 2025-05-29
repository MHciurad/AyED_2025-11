using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tp 1 - Etapa 2
             
             El Rayo McQueen está compitiendo en una carrera de alta velocidad. Necesita un programa en C# que le ayude a registrar los tiempos de cada vuelta y calcular algunas estadísticas importantes. 
             El programa debe cumplir el siguiente orden:
             Permitir al Rayo McQueen ingresar los tiempos de cada vuelta de la carrera en segundos. Utiliza un array para almacenar estos tiempos.
             Calcular y mostrar en pantalla el tiempo total de la carrera.
             Calcular y mostrar en pantalla el promedio de tiempo por vuelta.
             Determinar y mostrar en pantalla cuál fue la mejor vuelta, es decir, la vuelta con el menor tiempo registrado.
             El programa debe permitir al usuario ingresar la cantidad de vueltas que completó Rayo McQueen y luego ingresar los tiempos de cada vuelta. Al finalizar, mostrará las estadísticas calculadas.
             (Opcional: los tiempos se pueden ingresar automáticamente con un for y un Random... recordar nombreRandom.Next(10, 500) ).
             
             */

            int CantVueltas;
            int tiempototal;
            int mejortiempo;
            int promedio;

            mejortiempo = 500;
            tiempototal = 0;

            Console.WriteLine("Ingrese la cantidad de vueltas");

            CantVueltas = int.Parse(Console.ReadLine());
            int[] tiempos = new int[CantVueltas];

            Random tiempo = new Random();

            for (int conta = 0; conta <= CantVueltas; conta++)
            {
                tiempos[conta] = tiempo.Next(10, 500);
                Console.WriteLine("el tiempo de la vuelta Nro: " + conta + ", es de: " + tiempos[conta] + " segundos");

                tiempototal = tiempototal + tiempos[conta];

                if (tiempos[conta] < mejortiempo)
                {
                    mejortiempo = tiempos[conta];
                }
            }

            promedio = tiempototal / CantVueltas;

            Console.WriteLine("El mejor tiempo realizado por el Rayo McQueen es de: " + mejortiempo);
            Console.WriteLine("El tiempo promedio es de: " + promedio);
            Console.WriteLine("el tiempo total es de: " + tiempototal);

            Console.ReadKey();
        }
    }
}
