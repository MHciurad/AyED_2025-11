using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("introduzca su numero");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(num - i);
            }
            Console.ReadKey();
        }
    }
}
