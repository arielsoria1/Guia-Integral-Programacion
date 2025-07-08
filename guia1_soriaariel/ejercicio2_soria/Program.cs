using System;

namespace ejercicio2_soria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro("Pipo");
            Animal gato = new Gato("Pipa");

            Console.WriteLine(perro.Presentarse());
            Console.WriteLine(gato.Presentarse());
        }
    }
}
