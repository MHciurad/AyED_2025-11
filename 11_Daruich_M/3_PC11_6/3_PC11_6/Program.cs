using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC11_6
{
    class Program
    {
        Random rand = new Random();
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");
            // 1) Generar mano aleatoria
            string[] mano = new string[5];
                GenerarManoAleatoria(mano);
            Console.WriteLine(mano);
            Console.ReadKey();
             /*2) Determinar tipo de mano
            string tipo = TipoDeMano(mano);
            // 3) Calcular puntaje base

            Balatro 5


int basePts = PuntajeBase(mano);
            // 4) Obtener multiplicador
            double mult = Multiplicador(tipo);
            // 5) Calcular puntaje final
            double total = basePts * mult;
            // 6) Aplicar jokers
            bool jokerX2 = true;
            bool jokerMas10 = true;
            total = AplicarJokers(total, jokerX2, jokerMas10);
            // 7) Mostrar resumen final
            MostrarResumen(mano, tipo, basePts, mult, total);*/
        }
        // ⚠️ Todas las funciones que se llaman en el Main
        // deben ser creadas acá abajo por ustedes.
        static string[] GenerarManoAleatoria(string[]v)
        {
            Random rand = new Random();
            int a,b;
            string c;
            v = new string[5];
            char[] num = { ' ','A', '2', '3', '4', '5', '6', '7', '8', '9', 'F', 'J', 'Q', 'K' };
            char[] pal = { ' ', 'H', 'S', 'T', 'D' };
            for (int i = 0; i < 5; i++)
            {
                a = rand.Next(1, 14);
                b = rand.Next(1, 5); 
                  v[i]  =  (num[a].ToString() + pal[b].ToString()); 
            }
            Console.WriteLine(v);
            return (v);



            }


        }
    }

