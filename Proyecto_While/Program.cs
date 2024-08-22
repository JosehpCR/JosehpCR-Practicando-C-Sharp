using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0,100);
            Console.WriteLine("Digite un número para intentar adivinar el número escondido");
            int numeroDigitado = 101;
            int cont=0;
            
            while (numeroDigitado != numeroAleatorio)
            {
                cont++;
                numeroDigitado = Int32.Parse(Console.ReadLine());
                if (numeroDigitado > numeroAleatorio) Console.WriteLine("Digite un número menor al anterior digitado");
                
                if (numeroDigitado < numeroAleatorio) Console.WriteLine("Digite un número mayor al anterior digitado");
            }
            Console.WriteLine("Felicidades ha encontrado el número: " + numeroAleatorio);
            Console.WriteLine("Lo ha intentado: "+ cont);
            Console.ReadKey();
            
            
        }
    }
}
