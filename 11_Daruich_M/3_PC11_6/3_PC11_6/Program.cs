using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC11_7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");
            // 1) Generar mano aleatoria
            string[] mano = GenerarManoAleatoria();
            foreach (string carta in mano)
            {
                Console.WriteLine(carta);
            }
            // 2) Determinar tipo de mano
            //string tipo = TipoDeMano(mano);
            //Console.WriteLine(tipo);

            // 3) Calcular puntaje base
            int basePts = PuntajeBase(mano);
            Console.WriteLine(basePts);

            /* 4) Obtener multiplicador
            double mult = Multiplicador(tipo);
            // 5) Calcular puntaje final
            double total = basePts * mult;
            // 6) Aplicar jokers
            bool jokerX2 = true;
            bool jokerMas10 = true;
            total = AplicarJokers(total, jokerX2, jokerMas10);
            // 7) Mostrar resumen final
            MostrarResumen(mano, tipo, basePts, mult, total);
        }
        // ⚠️ Todas las funciones que se llaman en el Main
        // deben ser creadas acá abajo por ustedes. */
            Console.ReadKey();
    }

    static string[] GenerarManoAleatoria()
        {
            Random rand = new Random();
            int a, b;
            string[]v = new string[5];
            string[] num = { " ", "A", "2", "3", "4", "5", "6", "7", "8", "9", "F", "J", "Q", "K" };
            string[] pal = { " ", "H", "S", "T", "D" };
            for (int i = 0; i < 5; i++)
            {
                a = rand.Next(1, 14);
                b = rand.Next(1, 5);
                v[i] = (num[a].ToString() + pal[b].ToString());
            }
            
            return (v);
        }

        static int PuntajeBase(string[] mano)
        {
            int puntos = 0;
            for (int i = 0; i < 5; i++)
            {
                if (mano[i].StartsWith("A"))
                {
                    puntos = puntos + 14;
                }
                else if (mano[i].StartsWith("2"))
                {
                    puntos = puntos + 2;
                }
                else if (mano[i].StartsWith("3"))
                {
                    puntos = puntos + 3;
                }
                else if (mano[i].StartsWith("4"))
                {
                    puntos = puntos + 4;
                }
                else if (mano[i].StartsWith("5"))
                {
                    puntos = puntos + 5;
                }
                else if (mano[i].StartsWith("6"))
                {
                    puntos = puntos + 6;
                }
                else if (mano[i].StartsWith("7"))
                {
                    puntos = puntos + 7;
                }
                else if (mano[i].StartsWith("8"))
                {
                    puntos = puntos + 8;
                }
                else if (mano[i].StartsWith("9"))
                {
                    puntos = puntos + 9;
                }
                else if (mano[i].StartsWith("T"))
                {
                    puntos = puntos + 10;
                }
                else if (mano[i].StartsWith("J"))
                {
                    puntos = puntos + 11;
                }
                else if (mano[i].StartsWith("Q"))
                {
                    puntos = puntos + 12;
                }
                else if (mano[i].StartsWith("K"))
                {
                    puntos = puntos + 13;
                }
            }
            return puntos;
        }
    }
}


