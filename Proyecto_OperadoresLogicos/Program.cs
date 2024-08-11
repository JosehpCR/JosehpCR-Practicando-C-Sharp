using System;


namespace Proyecto_OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 11;
            int Num2 = 10;
            if (Num2 == 10 && Num1 == 11)
            {
                Console.WriteLine("Afirmativo");
            }
            if (Num2 == Num1 || Num1 == 11)
            {
                Console.WriteLine("Afirmativo");
            }
            if (!(Num2 == Num1 || Num1 == 11))
            {
                Console.WriteLine("Afirmativo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
            Console.ReadKey();

            Console.Write("Holaaa Maaaaaaaaa");

        }
    }
}
