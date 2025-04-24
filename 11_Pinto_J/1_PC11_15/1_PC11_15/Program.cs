using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             TP 15 - Etapa 1
             
             Simulá un juego donde el personaje está atrapado en una isla y debe sobrevivir
             durante 7 días. Cada día puede realizar distintas acciones, pero algunas tienen
             una probabilidad de tener consecuencias malas o buenas. Para esto, vas a
             utilizar números aleatorios

             */

            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 0;
            bool sigueVivo = true;
            Random rand = new Random();
            int opcion;

            while (dia < 7 || opcion != 5 )
            {
                dia = dia + 1;
                Console.WriteLine("Día " + dia + " – ¿Qué querés hacer?");
                Console.WriteLine("1.Buscar comida");
                Console.WriteLine("2.Dormir");
                Console.WriteLine("3.Explorar la isla");
                Console.WriteLine("4.Ver estado del personaje");
                Console.WriteLine("5.Salir del juego");
                opcion = int.Parse(Console.ReadLine());
                if (salud <= 0 || hambre <= 0 || energia <= 0)
                {
                    Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over ☠️");
                    sigueVivo = false;
                    Console.ReadKey();
                }
                else if (opcion > 5)
                {
                    Console.WriteLine("error intente otra vez");
                    sigueVivo = false;
                    Console.ReadKey();
                }
                else
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("fuiste a buscar comida, hambre +30 energia -15");
                            hambre = hambre + 30;
                            energia = energia - 15;
                            int numeroAleatorio = rand.Next(1, 101);
                            if (numeroAleatorio <= 30)
                            {
                                Console.WriteLine("fuiste a buscar comida, comiste algo en mal estado, salud -15");
                                salud = salud - 15;
                            }

                            break;
                        case 2:
                            Console.WriteLine("fuiste a dormir, energia +30 hambre -10");
                            energia = energia + 30;
                            hambre = hambre - 10;
                            break;
                        case 3:
                            Console.WriteLine("fuiste a explorar la isla, energia -20 hambre -15");
                            energia = energia - 20;
                            hambre = hambre - 15;
                            int numeroAleatorio2 = rand.Next(1, 101);
                            if (numeroAleatorio2 > 50)
                            {
                                Console.WriteLine("fuiste a explorar la isla, ¡Encontraste una planta curativa! Salud + 10.");
                                salud = salud + 10;
                            }
                            break;
                        case 4:
                            Console.WriteLine("salud: " + salud);
                            Console.WriteLine("energia: " + energia);
                            Console.WriteLine("hambre: " + hambre);
                            Console.WriteLine("dia: " + dia);
                            break;
                    }
                }
            }

        }
    }
}
