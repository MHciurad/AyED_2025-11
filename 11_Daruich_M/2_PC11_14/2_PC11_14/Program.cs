using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Pochidex = new string[75, 5];
            int op, OP, z2, z1, columnaALlenar;
            z1 = 0;
            z2 = 0;
            op = 1;
            columnaALlenar = 0;
            for (int i = 0; i < 75; i++)
            {
                Pochidex[i, columnaALlenar] = (i + 1).ToString();
            }

            while (op != 9)
            {
                op = 0;
                z2 = 0;
                Console.WriteLine("1. Registrar Pochimon");
                Console.WriteLine("2. Asignar investigador Pochimon");
                Console.WriteLine("3. Actualizar Nivel de Pochimon");
                Console.WriteLine("4. Marcar Pochimon como Investigado");
                Console.WriteLine("5. Mostra info de Pochimon");
                Console.WriteLine("6. Buscar Pochimon por tipo");
                Console.WriteLine("7. Mostrar Pochimon por investigador");
                Console.WriteLine("8. Mostrar Pochimon Picados");
                Console.WriteLine("9. Salir");
                Console.WriteLine(z1);
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        z1++;
                        Console.WriteLine("introduzca nombre,");
                        Pochidex[z1, z2] = Console.ReadLine();
                        z2 = z2 + 1;
                        Console.WriteLine("introduzca tipo,");
                        Pochidex[z1, z2] = Console.ReadLine();
                        z2 = z2 + 1;
                        Console.WriteLine("introduzca nivel");
                        Pochidex[z1, z2] = Console.ReadLine();
                        z2 = z2 + 1;
                        Console.ReadKey();
                        break;

                    case 2:
                        for (int r = 0; r < 75; r++)
                        {
                            for (int c = 0; c < 5; c++)
                            {
                                Console.Write($"[{Pochidex[r, c],-5}]");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("cual Pochimon Quiere actualizar?");
                        OP = int.Parse(Console.ReadLine());
                        Console.WriteLine("a que nivel a cambiado?");
                        Pochidex[OP, 4] = Console.ReadLine();
                        break;
                    case 4:

                        break;
                    case 9:
                        Console.WriteLine("gracias, vuelva pronto");
                        Console.ReadKey();
                        break;

                }
                

            }


                /*else if (op > 9)
                {
                    Console.WriteLine("invalida, intente otra vez");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("gracias, hasta pronto");
                    Console.ReadKey();*/

                }
            
        }
           
        }
    
    

