using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int op, x, y;
            op = 0;
            Console.WriteLine("cuantos espacios debera tener el vector");
            x = int.Parse(Console.ReadLine());
            int[] Vec = new int[x];
            for (int i = 0; i < x; i++)
            {
                Vec[i] = rand.Next(1, 100);

            }

            {
                while (op != 4)
                {
                    op = 0;
                    Console.Clear();
                    Console.WriteLine("1. imprmir vector");
                    Console.WriteLine("2. buscar numero");
                    Console.WriteLine("3. ordenar");
                    Console.WriteLine("4. Salir");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            for (int i = 0; i < x; i++)
                            {
                                Console.WriteLine(Vec[i]);
                            }
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine("ingrese el numero a buscar");
                            y = int.Parse(Console.ReadLine());
                            for (int i = 0; i < x; i++)
                            {
                                if (Vec[i] == y)
                                {
                                    Console.WriteLine(Vec[i]);
                                    Console.WriteLine("se encuentra en la poscicion " + (i + 1));
                                }

                            }

                            Console.ReadKey();
                            break;

                        case 3:
                            Console.WriteLine("manyor menor menor mayor");
                            break;

                        case 4:
                            Console.WriteLine("gracias, vuelva pronto");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
    }
}

