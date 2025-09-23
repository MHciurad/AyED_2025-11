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
            int x, y;


            Console.WriteLine("ingrese cantidad participantes");
            x = int.Parse(Console.ReadLine());
            int[] Vec = new int[x];
            for (int i = 0; i < x; i++)
            {
                y = 0;
                Console.WriteLine("ingrese puntuacion del concursante " + (i + 1));
                Vec[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(Vec);
            Console.WriteLine("ingrese numero para filtrar");
            y = int.Parse(Console.ReadLine());
            int[] Vec2 = new int[x];
            Console.WriteLine("los puntajes son:");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(Vec[i]);
            }
            Console.WriteLine("los flitrados por el numero indicado son:");
            for (int i = 0; i < x; i++)
            {
                if (Vec[i]% y == 0)
                {
                    Console.WriteLine(Vec[i]);
                }

            }

            Console.ReadKey();
        }
    }
}
