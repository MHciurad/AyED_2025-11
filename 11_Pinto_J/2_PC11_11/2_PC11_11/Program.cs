using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         * 
         * TP 11 - ETAPA 2
         * 
         * 
         * 
         * */
            int n;

            Console.WriteLine("ingrese tamaño de la matriz (n x n)");
            n = int.Parse(Console.ReadLine());
            Random rand = new Random();

            int[,] mimatriz = new int[n, n];

            /******************************************/
            for (int f = 0; f < n; f++)
            {

                for (int c = 0; c < n; c++)
                {
                    int numeroAleatorio = rand.Next(1, 100);
                    mimatriz[f, c] = numeroAleatorio;
                }
            }
            Console.WriteLine("_-------------matriz normal---------------");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(mimatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("_-------------matriz invertida 90°---------------");

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(mimatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
