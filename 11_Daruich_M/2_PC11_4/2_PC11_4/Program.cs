using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*El programa solicitará al usuario que ingrese la cantidad de productos vendidos
             durante el Hot Sale.
             Luego, pedirá al usuario que ingrese el precio
             de cada producto, uno por uno. Una vez ingresados todos
             los precios, el programa determinará cuál fue el precio más alto
             y cuál fue el precio más bajo.
             Finalmente, mostrará al usuario los precios más alto
             y más bajo registrados durante el evento. */
            
            int Productos;
            
            Console.WriteLine("indique cuantos productos se vendieron");
            Productos = int.Parse(Console.ReadLine());
            int[] precios = new int[Productos];
            for (int conta = 0; conta < Productos; conta++)
            {
                Console.WriteLine("indique el precio del producto " + conta);
                precios[conta] = int.Parse(Console.ReadLine());

            }

                Array.Sort(precios);
            Console.WriteLine("El precio mas alto fue " + precios[Productos - 1]);
            Console.WriteLine("y el mas bajo " + precios[1]);
            Console.WriteLine(precios[Productos - 1]);
            Console.WriteLine(precios[1]);

            Console.ReadKey();
        }
    }
}
