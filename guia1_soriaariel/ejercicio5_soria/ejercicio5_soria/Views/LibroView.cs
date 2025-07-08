using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio5_soria.Models;

namespace ejercicio5_soria.Views
{
    public class LibroView
    {
        public Libro CrearLibro()
        {
            Console.Write("Título: ");
            var titulo = Console.ReadLine();
            Console.Write("Autor: ");
            var autor = Console.ReadLine();
            Console.Write("ISBN: ");
            var isbn = Console.ReadLine();

            return new Libro { Titulo = titulo, Autor = autor, ISBN = isbn };
        }

        public void MostrarLibros(List<Libro> libros)
        {
            foreach (var libro in libros)
                Console.WriteLine(libro);
        }

        public string PedirISBN()
        {
            Console.Write("Ingrese ISBN: ");
            return Console.ReadLine();
        }

        public Libro EditarLibro(Libro libro)
        {
            Console.Write($"Nuevo título ({libro.Titulo}): ");
            var titulo = Console.ReadLine();
            Console.Write($"Nuevo autor ({libro.Autor}): ");
            var autor = Console.ReadLine();

            libro.Titulo = string.IsNullOrWhiteSpace(titulo) ? libro.Titulo : titulo;
            libro.Autor = string.IsNullOrWhiteSpace(autor) ? libro.Autor : autor;

            return libro;
        }

    }
}
