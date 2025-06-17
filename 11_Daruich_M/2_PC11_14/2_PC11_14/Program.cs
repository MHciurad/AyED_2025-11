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
            string[,] Pochidex = new string[75, 6];
            string OP2;
            int op, OP, z2, z1, colen, colen2, colen3;
            z1 = 0;
            z2 = 0;
            op = 1;
            colen = 0;
            colen2 = 5;
            colen3 = 4;
            for (int i = 0; i < 75; i++)
            {
                Pochidex[i, colen] = (i + 1).ToString();
            }
            for (int i = 0; i < 75; i++)
            {
                Pochidex[i, colen2] = 0.ToString();
            }
            for (int i = 0; i < 75; i++)
            {
                Pochidex[i, colen3] = 0.ToString();
            }
            Pochidex[0, 0] = "fila";
            Pochidex[0, 1] = "nombre";
            Pochidex[0, 2] = "nivel";
            Pochidex[0, 3] = "tipo";
            Pochidex[0, 4] = "estado";
            Pochidex[0, 5] = "investigador asignado";


            while (op != 9)
            {
                op = 0;
                z2 = 1;
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
                        break;

                    case 2:
                        Console.WriteLine("que entrada desea alterar?");
                        OP = int.Parse(Console.ReadLine());
                        Console.WriteLine("introduzca el numero de empleado del investigador a cargo");
                        Pochidex[OP, 5] = Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("cual Pochimon Quiere actualizar?");
                        OP = int.Parse(Console.ReadLine());
                        Console.WriteLine("a que nivel a cambiado?");
                        Pochidex[OP, 3] = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("que entrada desea alterar?");
                        OP = int.Parse(Console.ReadLine());
                        Console.WriteLine("si el pochimon esta en investigacion ponga 1");
                        Console.WriteLine("si ya ha sido investigado, ponga 2");
                        Pochidex[OP, 4] = Console.ReadLine();
                        break;
                    case 5:
                        for (int r = 0; r < 75; r++)
                        {
                            for (int c = 0; c < 6; c++)
                            {
                                Console.Write($"[{Pochidex[r, c],-5}]");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        Console.WriteLine("Pör cual tipo quiere buscar");
                        OP2 = Console.ReadLine();
                        for (int i = 0; i < 75; i++)
                        {
                            if (Pochidex[i, 3] == OP2)
                            {
                                for (int r = 0; r < 75; r++)
                                {
                                    for (int c = 0; c < 6; c++)
                                    {
                                        Console.Write($"[{Pochidex[r, c],-5}]");
                                    }
                                    Console.WriteLine();
                                }

                            }
                        }
                        break;
                    case 9:
                        Console.WriteLine("gracias, vuelva pronto");
                        Console.ReadKey();
                        break;

                }
                

            }



                }
            
        }
           
        }
    
    

