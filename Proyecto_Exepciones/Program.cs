
namespace Proyecto_Exepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el numero de un mes del año");
            int NumeroMes = int.Parse(Console.ReadLine());
            try
            {
               Console.WriteLine(NombreDelMes(NumeroMes)); 
               Console.WriteLine("Se continua ejecutando el programa");
            }
            catch (Exception e)
            {
               Console.WriteLine("El mensaje de error es: " + e.Message);
            }
        }
        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                
                default:
                    throw new ArgumentOutOfRangeException();
            }
    
        }
    
    }
}


