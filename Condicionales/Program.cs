using System;


namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double Sueldobasico = 250000;
            //double Sueldo2;
            //Console.WriteLine("Digite su sueldo");
            //Double.TryParse(Console.ReadLine(),out Sueldo2);
            //if (Sueldobasico>=Sueldo2)
            //{
            //    Console.WriteLine("Sueldo Alto");
            //}
            //else
            //{
            //    Console.WriteLine("Negativo");
            //}
            //Console.WriteLine("Tienes carnet?");
            //string respuesta = Console.ReadLine();
            //int comparar = String.Compare(respuesta,"si",true);
            //if (comparar == 0)
            //{
            //    Console.WriteLine("Afirmativo");
            //}
            //else
            //{
            //    Console.WriteLine("Negativo");
            //}
           
            int num1 =13; int num2 = 15;
            var Respuesta = new int();
            var resultado = Sumar(num1,num2,ref Respuesta);

            Edades();
            

        }
       static double Sumar(int n1, int n2, ref int resultado)
        {

            resultado = n1 + n2;
            n1 = 200;
            return 0.0;
        }
        static void Edades()
        {
            Console.WriteLine("Escribe tu edad");
            int Edad = Int32.Parse (Console.ReadLine());

            if (Edad < 18) Console.WriteLine("Usted es un niño");

            else if (Edad < 30) Console.WriteLine("Usted es un joven");
            else if (Edad < 60) Console.WriteLine("Usted es un señor");
            else
            {
                Console.WriteLine("Usted es viejo");
            }
        }




    }
}
