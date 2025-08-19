using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC11_0
{
    class Program
    {
        static string Saludo(string nombre)
        {
            return "hola " + nombre + " como estas";
        }
        static void Main(string[] args)
        {
            string N, mens;
            Console.WriteLine("cual es tu nombre?");
            N = Console.ReadLine();
            mens = Saludo(N);
            Console.WriteLine(mens);
            Console.ReadKey();
        }
    }
}
