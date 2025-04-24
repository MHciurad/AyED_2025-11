using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_6
{
    class Program
    {/*Pedir al usuario que ingrese la temperatura en grados Celsius. Según el valor, informar:

Si es menor o igual a 0 → "Se congela"

Si es mayor o igual a 100 → "Hierve

Si está entre 1 y 99 → "Está en estado líquido"
        */
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("ingrese la temperatura en celcius ");
            temp = int.Parse(Console.ReadLine());
            if (temp <= 0)
            {
                Console.WriteLine("se congela");
            }
            else if (temp >= 100)
            {
                Console.WriteLine("se hierve");
            }
            else if (temp > 1 && temp <= 99)
            {
                Console.WriteLine("esta liquida");
            }
            Console.ReadKey();
        }
    }
}
