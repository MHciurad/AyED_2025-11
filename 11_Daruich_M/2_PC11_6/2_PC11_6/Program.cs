using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Examinados, Multiplo;

            Console.WriteLine("indique cuantos examinados hubo");
            Examinados = int.Parse(Console.ReadLine());
            int[] puntajes = new int[Examinados];
            for (int conta = 0; conta < Examinados; conta++)
            {
                Console.WriteLine("ingrese el puntaje del examinado " + (conta + 1));
                puntajes[conta] = int.Parse(Console.ReadLine());
            }
            Array.Sort(puntajes);
            Console.WriteLine("indique por cual multiplo quiere filtrar");
            Multiplo = int.Parse(Console.ReadLine());
            for (int conta = 0; conta <  Examinados; conta++)
            {   if (puntajes[conta]%Multiplo == 0)
                {
                    Console.WriteLine(puntajes[conta]);
                }
                }
                 Console.ReadKey();


            }
    }
}
