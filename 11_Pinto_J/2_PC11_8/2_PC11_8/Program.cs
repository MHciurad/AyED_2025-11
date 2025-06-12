using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_8
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
            int fila, columna;

            Console.WriteLine("ingrese tamaño de fila");
            fila = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tamaño de columna");
            columna = int.Parse(Console.ReadLine());


            int[,] mimatriz = new int[fila, columna];

            for(int f=0; f<fila; f++)
            {
               for(int c=0; c<columna; c++)
                {
                    mimatriz[f, c] = 0;

                }
            }
            for (int f=0; f<fila;f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    Console.Write(mimatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
