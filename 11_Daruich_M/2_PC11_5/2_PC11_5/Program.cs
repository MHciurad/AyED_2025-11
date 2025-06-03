using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Objetos, Valmin;
            Console.WriteLine("cuantos objetos desea evaluar");
            Objetos = int.Parse(Console.ReadLine());
            Console.WriteLine("cual es el valor minimo de los objetos que desea mantener");
            Valmin = int.Parse(Console.ReadLine());
            int[] valores = new int[Objetos];
            for (int conta = 0; conta < Objetos; conta++)
            {
                Console.WriteLine("ingrese el valor del objeto " + (conta + 1));
                 valores[conta]= int.Parse(Console.ReadLine());
            }
            for (int conta = 0; conta < Objetos; conta++)
            {
                if (valores[conta] > Valmin)
                {
                    Console.WriteLine((conta+1) + " " + valores[conta]);
                }
            }
                Console.ReadKey();
        }
    }
}
