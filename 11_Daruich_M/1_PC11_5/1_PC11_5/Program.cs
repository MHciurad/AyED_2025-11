using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int comida, refugio, bate;

            Console.WriteLine("responda con 0 para no y 1 o mas para si ");
            Console.WriteLine("tiene Comida? ");
            comida = int.Parse(Console.ReadLine());

            Console.WriteLine("tiene refugio? ");
            refugio = int.Parse(Console.ReadLine());
            Console.WriteLine("tiene un bate? ");
            bate = int.Parse(Console.ReadLine());

            if (refugio > 0 && comida > 0 && bate > 0)
            {
                Console.WriteLine("sobrevivira al apocalipsis");
            }
            else
            {
                Console.WriteLine("RIP");
            }
            Console.ReadKey();
        }
    }
}
