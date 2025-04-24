using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string pal;
            Console.WriteLine("por favor escriba una palabra ");
            pal = Console.ReadLine();
            for(int i =0; i<10; i++)
            {
                Console.WriteLine(" " + pal);
            }
            Console.ReadKey();
        }
    }
}
