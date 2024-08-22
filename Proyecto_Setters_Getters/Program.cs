
namespace Proyecto_Setters_Getters;

class Program
{
    static void Main(string[] args)
    {
        Coche coche1 = new Coche(4, false, true, 453, 534);
        Console.WriteLine(coche1.GetInfoCoche());

    }

    class Coche
    {
        private int ruedas;
        private bool climatizador;
        private bool tapiceria;
        private double ancho;
        private double largo;
        
        public Coche(int ruedas, bool climatizador, bool tapiceria, double ancho, double largo)
        {
            this.ruedas = ruedas;
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
            this.ancho = ancho;
            this.largo = largo;
        }
        public string GetInfoCoche()
        {
            return "Ruedas: " + ruedas + "\nClimatizador: " + climatizador + "\nTapiceria: " + tapiceria +
                   "\nAncho: " + ancho + "\nLargo: " + largo;
        }
        
    }
}

