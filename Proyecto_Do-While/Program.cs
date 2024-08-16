internal class Program
{
    static void Main(string[] args)
    {
        Random numero = new Random();
        int numeroAleatorio = numero.Next(0,100);
        Console.WriteLine("Digite un número para intentar adivinar el número escondido");
        int numeroDigitado;
        int cont=0;
        
        do
        {
            cont++;
            try
            {
                numeroDigitado = Int32.Parse(Console.ReadLine());
            }
            // catch (FormatException exception) *Tipos diferentes de exepciones
            // catch (Exception exception) Tipo general de e
            catch (Exception exception) when (exception.GetType() != typeof(FormatException))
            {
                Console.WriteLine("Ha ocurrido un error, se tomo como numero introducido el 0");
                numeroDigitado = 0;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Has introducido letras");
                numeroDigitado = 0;
            }
           
            if (numeroDigitado > numeroAleatorio) Console.WriteLine("Digite un número menor al anterior digitado");
            if (numeroDigitado < numeroAleatorio) Console.WriteLine("Digite un número mayor al anterior digitado");
        } while (numeroDigitado != numeroAleatorio);
        Console.WriteLine("Felicidades ha encontrado el número: " + numeroAleatorio);
        Console.WriteLine("Lo ha intentado: "+ cont);
        Console.ReadKey();
        
    }
}