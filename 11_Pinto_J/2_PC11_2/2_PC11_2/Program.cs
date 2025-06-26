using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              TP 2 - etapa 2
             */
            int canttp, cantex, tpsaprobados;
double promedioex, examtotal, tp75;
bool condi1, condi2;

condi1 = false;
condi2 = false;

tpsaprobados = 0;
examtotal = 0;
promedioex = 0;

Console.WriteLine("Ingrese la cantidad de Tps");
canttp = int.Parse(Console.ReadLine());
int[] tps = new int[canttp];

Console.WriteLine("Ingrese la cantidad de examenes");
cantex = int.Parse(Console.ReadLine());
int[] exams = new int[cantex];


/* -------------------------TPS--------------------------- */
tp75 = canttp * 0.75;
for (int i = 0; i < canttp; i++)
{
    Console.WriteLine("Ingrese la nota del tp " + (i + 1));
    tps[i] = int.Parse(Console.ReadLine());
    if (tps[i] >= 6)
    {
        tpsaprobados = tpsaprobados + 1;
    }
}

if (tpsaprobados >= tp75)
{
    condi1 = true;
}

/*-------------------------EXAMENES--------------------------- */

for (int i = 0; i < cantex; i++)
{
    Console.WriteLine("Ingrese la nota del examen " + (i + 1));
    exams[i] = int.Parse(Console.ReadLine());
    examtotal = examtotal + exams[i];
}

promedioex = examtotal / cantex;

if (promedioex >= 6)
{
    condi2 = true;
}
/*------------------------FINAL--------------------------- */

if (condi1 == true && condi2 == true)
{
    Console.WriteLine("Phineas y Ferb aprobaron la materia");
}
else
{
    Console.WriteLine("Phineas y Ferb no aprobaron la materia");
}

Console.ReadKey();
        }
    }
}
