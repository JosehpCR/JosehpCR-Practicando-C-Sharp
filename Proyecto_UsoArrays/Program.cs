// See https://aka.ms/new-console-template for more information

namespace Proyecto_UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] edades;

            edades = new int[4];

            edades[0] = 15;
            edades[1] = 20;
            edades[2] = 25;
            edades[3] = 30;
            
            Console.WriteLine(edades[4]);

            var valores = new[] { 20, 23.2, 26, 35 };
            
            //Array de objetos
            Empleado Ana = new Empleado("Ana", 27);
            Empleado[] arrayEmpleados = new Empleado [2];
            arrayEmpleados[0] = new Empleado("Sara", 37);
            arrayEmpleados[1] = Ana;
            
            //Array de tipos o clases anónimas
            var personas = new[]
            {
                new{Nombre="Juan",Edad=19},
                new{Nombre="Daniel",Edad=20},
                new{Nombre="Andres",Edad=21}
            };


        }
    }

    class Empleado
    {
        public Empleado(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        private string nombre;
        private int edad;
        
    }
}