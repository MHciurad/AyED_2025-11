using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_3
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
                Console.WriteLine("ingrese puntuacion del concursante " + (i+1));
                Vec[i] = int.Parse(Console.ReadLine());

            }
            Array.Sort(Vec);
            Array.Reverse(Vec);
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine((i+1) +  " lugar con "+Vec[i]);
            }
                Console.WriteLine("el ganador es el concursante con " + Vec[x - 1] + " puntos");
            Console.WriteLine("el ultimo lugar es el concursante con " + Vec[0] + " puntos");
            Console.ReadKey();
          
        }
    }
}
