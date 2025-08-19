using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC11_1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("introduzca los dos numeros");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = Suma(a, b);
            Console.WriteLine("el resultado es " + c);
            Console.ReadKey();
        }
    }
}
