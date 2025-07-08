using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio5_soria.Data;
using ejercicio5_soria.Models;
using ejercicio5_soria.Views;


namespace ejercicio5_soria.Controllers
{
    public class LibroController
    {
        private readonly BibliotecaRepository _repo;
        private readonly LibroView _view;

        public LibroController(BibliotecaRepository repo, LibroView view)
        {
            _repo = repo;
            _view = view;
        }

        public void AgregarLibro()
        {
            var libro = _view.CrearLibro();
            _repo.Libros.Add(libro);
        }

        public void ListarDisponibles()
        {
            var disponibles = _repo.Libros.Where(l => l.Disponible).ToList();
            _view.MostrarLibros(disponibles);
        }

        public void EliminarLibro()
        {
            var isbn = _view.PedirISBN();
            var libro = _repo.Libros.FirstOrDefault(l => l.ISBN == isbn);
            if (libro == null)
            {
                Console.WriteLine("Libro no encontrado.");
                return;
            }

            _repo.Libros.Remove(libro);
            Console.WriteLine("Libro eliminado.");
        }

        public void EditarLibro()
        {
            var isbn = _view.PedirISBN();
            var libro = _repo.Libros.FirstOrDefault(l => l.ISBN == isbn);
            if (libro == null)
            {
                Console.WriteLine("Libro no encontrado.");
                return;
            }

            _view.EditarLibro(libro);
            Console.WriteLine("Libro actualizado.");
        }

    }
}
