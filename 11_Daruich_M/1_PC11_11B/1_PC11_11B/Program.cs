using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_11B
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("ingrese el num");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);

                }
            }
            Console.ReadKey();
        } 
    }
}
