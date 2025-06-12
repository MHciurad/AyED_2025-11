using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         * 
         * TP 8 - ETAPA 2
         * 
         * 
         * 
         * */
            int n;

            Console.WriteLine("ingrese tamaño de la matriz (n x n)");
            n = int.Parse(Console.ReadLine());
            Random rand = new Random();

            int[,] mimatriz = new int[n, n];
            int[,] mimatriz2 = new int[n, n];
            int[,] mimatriz3 = new int[n, n];

            /******************************************/
            for (int f = 0; f < n; f++)
            {

                for (int c = 0; c < n; c++)
                {
                    int numeroAleatorio = rand.Next(1, 100);
                    mimatriz[f, c] = numeroAleatorio;

                }
            }

            for (int f = 0; f < n; f++)
            {

                for (int c = 0; c < n; c++)
                {
                    int numeroAleatorio = rand.Next(1, 100);
                    mimatriz2[f, c] = numeroAleatorio;

                }
            }
            /*********************************************/

            Console.WriteLine("---------------matriz 1--------------");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(mimatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------matriz 2--------------");

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(mimatriz2[f, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------suma de matrices--------------");

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write((mimatriz3[f, c] = mimatriz[f, c] + mimatriz2[f, c]) + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
