using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         * 
         * TP 12 - ETAPA 2
         * 
         * 
         * 
         * */
            int n;
            Console.WriteLine("Ingrese tamaño de la matriz (n x n):");
            n = int.Parse(Console.ReadLine());

            Random rand = new Random();

            int[,] mimatriz = new int[n, n];
            int[] diagonal = new int[n];

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    int numeroAleatorio = rand.Next(1, 100);
                    mimatriz[f, c] = numeroAleatorio;

                }

            }

            Console.WriteLine("------------- Matriz normal -------------");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(mimatriz[f, c] + "\t");

                }
                Console.WriteLine();

            }

            for (int i = 0; i < n; i++)
            {
                diagonal[i] = mimatriz[i, i];
            }

            Console.WriteLine("\nVector con la diagonal principal:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(diagonal[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
