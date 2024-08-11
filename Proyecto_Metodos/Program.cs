using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 7; double valor2 = 8.3; double valor3 = 9.5;
            // Console.WriteLine(Suma(12.0,11.5));
            Console.WriteLine(SumaOpcional(valor1,valor2));
        }
        static double Suma(double v1, double v2)
        {
            return v1 + v2;
        }

        private static double SumaOpcional(int num1, double num2, double num3=0)
        {
            return num1 + num2 + num3;
        }

        static double Suma(int num1, double num2)
        {
            return num1 + num2;
         }
    }
}
