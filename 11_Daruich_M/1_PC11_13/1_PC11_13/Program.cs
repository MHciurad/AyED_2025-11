using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int elec = 0;

            while (elec != 4)
            {
                Console.WriteLine("\nbuen dia, elija una opcion");
                Console.WriteLine("\n-1: ver el dia");
                Console.WriteLine("\n-2: ver el clima");
                Console.WriteLine("\n-3: Decir la Hora");
                Console.WriteLine("\n-4: Salir");
                elec = int.Parse(Console.ReadLine());
                switch (elec)
                {
                    case 1:
                        Console.WriteLine("es miercoles");
                        break;
                    case 2:
                        Console.WriteLine("esta nublado");
                        break;
                    case 3:
                        Console.WriteLine("es alguna hora");
                        break;

                }
            }


        }
    }
}
