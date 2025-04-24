using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Jugador1";
            int sal = 100;
            int mon = 50;
            int endef = 0;
            bool esp = false;
            int op = 0;

            while (op != 5)
            {
                Console.WriteLine("1. Mostrar estado del jugador");
                Console.WriteLine("2. Encontrar espada mágica");
                Console.WriteLine("3. Pelear contra un enemigo");
                Console.WriteLine("4. Comprar poción de vida (vale 20 monedas)");
                Console.WriteLine("5. Salir del juego");
                Console.WriteLine("Seleccione una opción:");
                op = int.Parse(Console.ReadLine());
                if (op == 5 || sal <= 0)
                {
                    Console.WriteLine("gracias por jugar");
                    op = 5;
                    Console.ReadKey();
                }
                else if (op > 5)
                {
                    Console.WriteLine("invalida, intente otra vez");
                }
                else
                {
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine(nombre + "\n Salud:" + sal + "\n Dinero:" + mon + "\n Enemigos derrotados:" + endef + "\n Espada:" + esp);
                            break;
                        case 2:
                            if (esp == false)
                            {
                                Console.WriteLine("Felicidades! encontraste la espada magica");
                                esp = true;
                            }
                            else
                            {
                                Console.WriteLine("ya tienes la espada magica");
                            }
                            break;
                        case 3:
                            if (esp == true)
                            {
                                Console.WriteLine("¡Ganaste la batalla!Salud - 10.");
                                sal = sal - 10;
                                endef = endef + 1;
                            }
                            else
                            {
                                Console.WriteLine("¡Fue una pelea dura sin espada!Salud - 30.");
                                sal = sal - 30;
                            }
                            break;
                        case 4:
                            if (mon >= 20)
                            {
                                Console.WriteLine("Usaste una poción. +20 de salud.");
                                sal = sal + 20;
                                mon = mon - 20;
                            }
                            else
                            {
                                Console.WriteLine("no tienes suficientes monedas");
                            }
                            break;
                    }
                }
            }




        }
    }
}
