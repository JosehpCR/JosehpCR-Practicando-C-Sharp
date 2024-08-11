using System;


namespace Proyecto_DatosPrimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int edad1 = 22;
            string nombre1 = "Camilo";
            bool casado = false;
            double sueldo = 1000000;
           Console.WriteLine("Mi edad es: " + edad1);
            Console.WriteLine("Mi nombre es: " + nombre1);
            Console.WriteLine("Me encuentro casado? = " + casado);
            Console.WriteLine("Tengo un sueldo de: " + sueldo);
          
            Console.Write("Escriba su edad: ");
            int Edad2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba su nombre: ");
            string Nombre2 = Console.ReadLine();
            Console.Write("Escriba si esta casado: ");
            bool Casado2= Convert.ToBoolean(Console.ReadLine());
            Console.Write("Escriba su sueldo: ");
            double Sueldo2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Su edad es: " + Edad2 + " Su nombre es: " + Nombre2 + " Su estado de casado es: " + Casado2 + " Su sueldo es: " + Sueldo2);
             */
            dynamic Contenido;

            Contenido = "Bienvenido al sistema";
            string frase = Contenido;
            Console.WriteLine(frase);

            Contenido = 12;

            int num1 = Contenido;
            Console.WriteLine(num1);

            Console.ReadKey();

        }
    }
}
