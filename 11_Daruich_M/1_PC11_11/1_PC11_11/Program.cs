using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, vec,res;
            Console.WriteLine("ingrese el numero ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese cuantas veces ");
            vec = int.Parse(Console.ReadLine());
            while (vec > 0)
            {
                num = num / 2;
                Console.WriteLine(num);
                vec = vec - 1;
            }
            Console.ReadKey();
            
                

        }
    }
}
