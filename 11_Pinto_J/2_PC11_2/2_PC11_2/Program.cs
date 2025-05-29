using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              TP 2 - etapa 2
             */

            int CantTPS;
            int CantExam;
            int promedioex;
            int promediotp;

            promedioex = 0;
            promediotp = 0;

            Console.WriteLine("Ingrese la cantidad de Tps");

            CantTPS = int.Parse(Console.ReadLine());
            int[] tps = new int[CantTPS];

            Console.WriteLine("Ingrese la cantidad de examenes");

            CantExam = int.Parse(Console.ReadLine());
            int[] exams = new int[CantExam];


            for (int conta = 1; conta < CantTPS; conta++)
            {
                tps[conta] = int.Parse(Console.ReadLine());
                Console.WriteLine("la nota del tp: " + conta + " es " + tps[conta]);
            }

            for (int conta2 = 1; conta2 <= CantTPS; conta2++)
            {
                exams[conta2] = int.Parse(Console.ReadLine());
                Console.WriteLine("la nota del tp: " + conta2 + " es " + exams[conta2]);

                promedioex = (promedioex + exams[conta2]) / CantExam;
            }

            Console.WriteLine("el promedio de las notas de los examenes es: " + promedioex);

            Console.ReadKey();
        }
    }
}
