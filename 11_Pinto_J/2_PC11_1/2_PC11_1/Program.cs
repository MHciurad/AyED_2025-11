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

TP 1 - Etapa 2

*/

int cantvueltas, tiempototal, mejortiempo, promedio, mejorvueltanum;

mejortiempo = 501;
tiempototal = 0;
mejorvueltanum = 1;


Console.WriteLine("Ingrese la cantidad de vueltas");

cantvueltas = int.Parse(Console.ReadLine());
int[] tiempos = new int[cantvueltas];

Random tiempo = new Random();

for (int i = 0; i < cantvueltas; i++)
{
    tiempos[i] = tiempo.Next(10, 500);
    tiempototal = tiempototal + tiempos[i];

}
promedio = tiempototal / cantvueltas;


Console.WriteLine("El tiempo total de la carrera fue: " + tiempototal + " segundos");
Console.WriteLine("El promedio de tiempo por vuelta fue: " + promedio + " segundos");

for (int i = 0; i < cantvueltas; i++)
{
    if (tiempos[i] < mejortiempo)
    {
        mejortiempo = tiempos[i];
        mejorvueltanum = i + 1;
    }
}

Console.WriteLine("La vuelta con mejor tiempo fue la vuelta: " + mejorvueltanum + " con " + mejortiempo + " segundos" );


Console.WriteLine("Lista de vueltas");

for (int i = 0; i < cantvueltas; i++)
{
    Console.WriteLine("la vuelta numero: " + (i + 1) + " tuvo un tiempo de " + tiempos[i] + " segundos");
}
Console.ReadKey();
        }
    }
}
