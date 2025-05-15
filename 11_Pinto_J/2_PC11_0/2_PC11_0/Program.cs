using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             TP 0 - ETAPA 2
             
             Lilo está organizando una fiesta para los aliens invitados por Stitch y necesita gestionar la cantidad 
             de comida necesaria. Para ello, ha creado un programa en C# que le ayudará a calcular el promedio 
             de comida que necesitará por invitado. El programa solicitará al usuario que ingrese la cantidad 
             de invitados y luego pedirá la cantidad de comida que cada invitado consume, asegurándose 
             de que los valores ingresados estén dentro del rango permitido (de 1 a 100). Una vez que 
             se hayan ingresado todos los datos, el programa calculará el promedio de comida por invitado 
             y lo mostrará en pantalla.
             
             El programa solicitará al usuario que ingrese la cantidad de invitados a la fiesta.Luego, para cada invitado, 
             el programa solicitará que se ingrese la cantidad de comida que come (un número entre 1 y 100), 
             asegurándose de que el valor ingresado esté dentro del rango permitido. Si el valor ingresado no 
             está dentro del rango, se mostrará un mensaje de error y se pedirá que se ingrese nuevamente.
             Una vez que se hayan ingresado los datos de todos los invitados, el programa calculará el promedio 
             de comida por invitado. Finalmente, el programa mostrará en pantalla el promedio de comida por invitado.
             
             */

            int tamaño;
            int cantcomida;
            float comida;
            float comidatotal;

            comida = 0;

            Console.WriteLine("ingrese la cantidad de invitados a la fiesta");
            tamaño = int.Parse(Console.ReadLine());

            int[]CantInvitados = new int[tamaño];
            for (int i = CantInvitados.Count() - 1; i >= 0; i--)
            {
                Console.WriteLine("ingrese la cantidad de comida por invitado");
                cantcomida = int.Parse(Console.ReadLine());
                if (cantcomida<0 || cantcomida>100)
                {
                    Console.WriteLine("error");
                    Console.ReadKey();
                }
                else
                {
                    comida = comida + cantcomida;
                }

            }
            comidatotal = comida / tamaño;

            Console.Write("la comida promedio que ingiere cada invitado es de: " + comidatotal + " comidas");
            Console.ReadKey();
        }
    }
}
