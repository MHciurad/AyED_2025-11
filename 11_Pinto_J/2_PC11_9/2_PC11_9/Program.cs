using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_9
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
            Console.WriteLine("Ingrese tamaño de la matriz (n x n):");
            n = int.Parse(Console.ReadLine());
            
            Random rand = new Random();
            
            int[,] mimatriz = new int[n, n];
            
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
            int[,] matrizRotada = new int[n, n];
            
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    matrizRotada[c, n - 1 - f] = mimatriz[f, c];
                    
                }
                
            }
            
            Console.WriteLine("---------- Matriz rotada 90° ----------");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matrizRotada[f, c] + "\t");
                    
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
