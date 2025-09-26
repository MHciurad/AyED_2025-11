using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");

        // 1) Generar mano aleatoria
        string[] mano = GenerarManoAleatoria();

        // 2) Determinar tipo de mano
        string tipo = TipoDeMano(mano);

        // 3) Calcular puntaje base
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
        MostrarResumen(mano, tipo, basePts, mult, total);
        Console.ReadKey();
    }

    // 1) Generar mano aleatoria
    static string[] GenerarManoAleatoria()
    {
        string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
        string[] palos = { "H", "D", "C", "S" };
        string[] mano = new string[5];

        Random rnd = new Random();

        for (int i = 0; i < 5; i++)
        {
            int r = rnd.Next(rangos.Length);
            int p = rnd.Next(palos.Length);
            mano[i] = rangos[r] + palos[p];
        }

        return mano;
    }

    // 2) Tipo de mano
    static string TipoDeMano(string[] mano)
    {
        char[] rangos = new char[5];
        for (int i = 0; i < 5; i++)
        {
            rangos[i] = mano[i][0];
        }

        int[] contadores = new int[5];
        for (int i = 0; i < 5; i++)
        {
            int cuenta = 0;
            for (int j = 0; j < 5; j++)
            {
                if (rangos[i] == rangos[j])
                {
                    cuenta++;
                }
            }
            contadores[i] = cuenta;
        }

        bool hayPar = false;
        bool hayTrio = false;

        for (int i = 0; i < 5; i++)
        {
            if (contadores[i] == 4) return "Poker";
            if (contadores[i] == 3) hayTrio = true;
            if (contadores[i] == 2)
            {
                if (hayTrio) return "Full";
                hayPar = true;
            }
        }

        if (hayTrio) return "Trio";
        if (hayPar) return "Par";
        return "Nada";
    }

    // 3) Puntaje base
    static int PuntajeBase(string[] mano)
    {
        int total = 0;

        for (int i = 0; i < mano.Length; i++)
        {
            char rango = mano[i][0];
            total += ValorCarta(rango);
        }

        return total;
    }

    static int ValorCarta(char r)
    {
        if (r == 'A') return 14;
        if (r == 'K') return 13;
        if (r == 'Q') return 12;
        if (r == 'J') return 11;
        if (r == 'T') return 10;

        return int.Parse(r.ToString());
    }

    // 4) Multiplicador
    static double Multiplicador(string tipo)
    {
        if (tipo == "Nada") return 1.0;
        if (tipo == "Par") return 1.5;
        if (tipo == "Trio") return 2.5;
        if (tipo == "Full") return 3.5;
        if (tipo == "Poker") return 4.0;
        return 1.0;
    }

    // 5) Aplicar jokers
    static double AplicarJokers(double puntaje, bool x2, bool mas10)
    {
        if (x2) puntaje = puntaje * 2;

        if (mas10) puntaje = puntaje + 10;
        return puntaje;
    }

    // 6) Mostrar resumen
    static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
    {
        Console.Write("Mano: ");
        for (int i = 0; i < mano.Length; i++)
        {
            Console.Write("[" + mano[i] + "] ");
        }
        Console.WriteLine();

        Console.WriteLine("Tipo: " + tipo);
        Console.WriteLine("Puntaje base: " + basePts);
        Console.WriteLine("Multiplicador: x" + mult);
        Console.WriteLine("Total (con Jokers): " + total);
    }
}
