using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC11_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad;
            double sup;
            double vol;
            Console.WriteLine("introduzca radio en cm");
            rad = int.Parse(Console.ReadLine());
            sup = 4 * 3.14 * Math.Pow(rad, 2);
            vol = (3.1416*4/3)*Math.Pow(rad,3);
            Console.WriteLine("su superficie es "+ sup + " y su volumen es " + vol);
            Console.ReadKey();
        }
    }
}
