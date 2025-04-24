using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC11_5
{
    class Program
    {
        static void Main(string[] args)
        {/*Escribe un programa en C# que calcule el resultado de restar
            dos números introducidos por el usuario.*/
            int pre;
            int pri;
            int res;
            Console.WriteLine("introduzca num 1");
            pre = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca num 2");
            pri = int.Parse(Console.ReadLine());
            res = pre - pri;
            Console.WriteLine("su resultado es " + res);
            Console.ReadKey();
        }
    }
}
