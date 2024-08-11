using System;


namespace Proyecto_ConversionTiposdeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Escriba su edad: ");
            int Edad2 = int.Parse(Console.ReadLine());// = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriba su nombre: ");
            string Nombre2 = Console.ReadLine();

            Console.Write("Escriba si esta casado: ");
            bool Casado2 = bool.Parse(Console.ReadLine());//= Convert.ToBoolean(Console.ReadLine());

            Console.Write("Escriba su sueldo: ");
            double Sueldo2 = double.Parse(Console.ReadLine());//= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Su edad es: " + Edad2 + " Su nombre es: " + Nombre2 + " Su estado de casado es: " + Casado2 + " Su sueldo es: " + Sueldo2);
        }
    }
}
