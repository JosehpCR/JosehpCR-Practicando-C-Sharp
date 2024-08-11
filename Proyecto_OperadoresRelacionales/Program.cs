using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_OperadoresRelacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 10;
            int Num2 = 11;
            bool Operaciones;
            Operaciones = Num1 < Num2;
            Console.WriteLine("Num 1 es menor que Num?" + (Operaciones));
            Operaciones = Num1 > Num2;
            Console.WriteLine("Num 1 es mayor que Num?" + (Operaciones));
            Operaciones = Num1 <= Num2;
            Console.WriteLine("Num 1 es menor o igual que Num?" + (Operaciones));
            Operaciones = Num1 >= Num2;
            Console.WriteLine("Num 1 es mayor o igual que Num?" + (Operaciones));
            Operaciones = Num1 == Num2;
            Console.WriteLine("Num 1 es igual que Num?" + Operaciones);
            Operaciones = Num1 != Num2;
            Console.WriteLine("Num 1 es diferente que Num?" + (Operaciones));

            Console.ReadKey();
        }
    }
}
