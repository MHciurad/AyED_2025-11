using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC11_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double x;
            double dia;
            double per;
            double are;
            Console.WriteLine("introduzca alto y ancho en cm");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            dia = Math.Sqrt(x*x + y*y);
            per = x * 2 + y * 2;
            are = x * y;
            Console.WriteLine("la diagonal es " + dia+ " area " + are + " perimetro " + per);
            Console.ReadKey();
        }
    }
}
