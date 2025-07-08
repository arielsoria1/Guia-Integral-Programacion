using System;

namespace ejercicio1_soria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crea un ciudadano
            Ciudadano ciudadano = new Ciudadano("Juan Pérez", "12345678", 15);

            // muestra saludo
            Console.WriteLine(ciudadano.Saludar());

            // edad valida?
            Console.WriteLine("¿Edad mayor a 0? " + (ciudadano.TieneEdadValida() ? "Sí" : "No"));

            // mayor de edad?
            Console.WriteLine("¿Es mayor de edad? " + (ciudadano.EsMayorDeEdad() ? "Sí" : "No"));

        }
    }
}
