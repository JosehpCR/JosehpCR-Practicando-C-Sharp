// See https://aka.ms/new-console-template for more information
using System;
namespace Proyecto_UsoChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int numero = int.MaxValue;
                int resultado = numero + 20;
                Console.WriteLine(resultado);
            }
        }
    }
}

