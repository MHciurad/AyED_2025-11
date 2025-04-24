using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC11_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double cent;
            double kel;
            double far;
            Console.WriteLine("introduzca temperatura en centigrados");
            cent = int.Parse(Console.ReadLine());
            kel = cent + 273.15;
            far = 32 + 9*cent/5;
            Console.WriteLine("la temperatuyra en Kelvin es " + kel + " y en farenheit " + far);
            Console.ReadKey();
        }
    }
}
