using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC11_2
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Mult(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        { int opcion, a, b, c;
            do
            {

                Console.WriteLine("1.suma");
                Console.WriteLine("2.resta");
                Console.WriteLine("3.multiplicacion");
                Console.WriteLine("4.divison");
                Console.WriteLine("5.salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca los dos numeros");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = Suma(a, b);
                        Console.WriteLine("el resultado es " + c);
                        break;
                    case 2:
                        Console.WriteLine("introduzca los dos numeros");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = Resta(a, b);
                        Console.WriteLine("el resultado es " + c);
                        break;
                    case 3:
                        Console.WriteLine("introduzca los dos numeros");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = Mult(a, b);
                        Console.WriteLine("el resultado es " + c);
                        break;
                    case 4:
                        Console.WriteLine("introduzca los dos numeros");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = Div(a, b);
                        Console.WriteLine("el resultado es " + c);
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.Intente de nuevo.");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            } while (opcion != 5);
        }
    }
}
