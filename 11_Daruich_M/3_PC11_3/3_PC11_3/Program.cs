using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC11_3
{
    class Program
    {
        static void op1(int z2, int z1, int a, int b, int c)
        {
            z1++;
            Console.WriteLine("introduzca nombre,");
            encar[z1, z2] = a;
            z2 = z2 + 1;
            Console.WriteLine("introduzca tipo,");
            encar[z1, z2] = b;
            z2 = z2 + 1;
            Console.WriteLine("introduzca nivel");
            encar[z1, z2] = c;
            z2 = z2 + 1;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int opcion, z1, z2, a, b, c;
            int[,] encar = new int[26, 6];
            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL P.E.R.O. ==== ");
                Console.WriteLine(" 1.Registrar nueva encargo");
                Console.WriteLine(" 2.Ver todas los encargos");
                Console.WriteLine(" 3.asignar camion a encargo");
                Console.WriteLine(" 4.mostrar encargos asignados");
                Console.WriteLine(" 5.Promedio ganancia por sede");
                Console.WriteLine(" 6.Mostrar encargo con mayor distancia");
                Console.WriteLine(" 7.Filtrar por codigo camion");
                Console.WriteLine(" 8.Salir ");
                Console.Write(" Opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("introduzca tipo,");
                        b= int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("introduzca nivel");
                       c= int.Parse(Console.ReadLine());
                        Console.WriteLine(op1(z2,z1,a,b,c));
                        break;
                    case 2:
                        // Punto 2: Ver todas las misiones
                        break;
                    case 3:
                        // Punto 3: Cambiar estado de misión
                        break;
                    case 4:
                        // Punto 4: Listar misiones en curso
                        break;
                    case 5:
                        // Punto 5: Misión con más objetos a extraer
                        break;
                    case 6:
                        // Punto 6: Promedio de peligro por mapa
                        break;
                    case 7:
                        // Punto 7: Filtrar por mapa
                        break;
                    case 8:
                        Console.WriteLine(" Saliendo del sistema... ¡Esperemos que el PERO no sea letal!");
                        break;
                    default:
                        Console.WriteLine(" Opción no válida.Intente de nuevo");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 8);
        }
    }
}
