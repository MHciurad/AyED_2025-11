using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC11_5
{
    class Program
    {
        static void Main()
        {
            int hpHornet = 10;
            int hpMaxHornet = 10;
            int atkHornet = 3;
            int hpEnemigo = 12;
            Console.WriteLine("=== Hollow Knight: Simulador básico ===");
            while (hpHornet > 0 && hpEnemigo > 0)
            {
                MostrarEstado(hpHornet, hpEnemigo);
                Console.Write("\nAcción (atacar/curar/salir): ");
                string accion = Console.ReadLine();
                if (accion == "atacar")
                {
                    hpEnemigo = Atacar(atkHornet, hpEnemigo);
                }
                else if (accion == "curar")
                {
                    hpHornet = Curar(hpHornet, hpMaxHornet);
                }
                else if (accion == "salir")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Acción no válida.");
                }
                // Enemigo ataca automáticamente
                if (hpEnemigo > 0)
                {
                    hpHornet -= 2;
                    Console.WriteLine("El enemigo contraataca y hace 2 de daño!");
                }
            }
            Console.WriteLine("\n=== Resultado ===");
            if (hpHornet <= 0) Console.WriteLine("Hornet ha caído...");
            else if (hpEnemigo <= 0) Console.WriteLine("¡Hornet ganó!");
            else Console.WriteLine("Batalla interrumpida.");
            Console.ReadKey();
        }
        // -------------------
        // ACA DEBEN CREAR LAS FUNCIONES:
        static int Atacar(int a, int b)
        {
            b = b - a;
            if (b < 0)
            {
                b = 0;
            }
            return b;
        }
        static int Curar(int a, int b)
        {
            b = a + 5;
            if (b > 10)
            {
                b = 10;
            }
            return b;
        }
        static void MostrarEstado(int a, int b)
        {
            Console.WriteLine("HP Hornet " + a + " HP enemigo " + b);
        }

    }
}