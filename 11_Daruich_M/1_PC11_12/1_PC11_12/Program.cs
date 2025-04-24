using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            int num;
            num = 0;
            while (num != 1) 
            {
                Console.WriteLine("desea terminar el programa?");
                ans = Console.ReadLine();
                if (ans == "SI")
                {
                    num = 1;
                }
            }


        }
    }
}
