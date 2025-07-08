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
    public class PrestamoController
    {
        private readonly BibliotecaRepository _repo;
        private readonly PrestamoView _view;

        public PrestamoController(BibliotecaRepository repo, PrestamoView view)
        {
            _repo = repo;
            _view = view;
        }

        public void PrestarLibro(string isbn, string email)
        {
            var libro = _repo.Libros.FirstOrDefault(l => l.ISBN == isbn && l.Disponible);
            var usuario = _repo.Usuarios.FirstOrDefault(u => u.Email == email);

            if (libro == null || usuario == null)
            {
                _view.MostrarMensaje("Libro no disponible o usuario no encontrado.");
                return;
            }

            libro.Disponible = false;
            _repo.Prestamos.Add(new Prestamo { Libro = libro, Usuario = usuario, Fecha = DateTime.Now });

            _view.MostrarMensaje("Libro prestado exitosamente.");
        }

        public void DevolverLibro(string isbn)
        {
            var prestamo = _repo.Prestamos.FirstOrDefault(p => p.Libro.ISBN == isbn);
            if (prestamo == null)
            {
                _view.MostrarMensaje("No se encontró el préstamo.");
                return;
            }

            prestamo.Libro.Disponible = true;
            _repo.Prestamos.Remove(prestamo);

            _view.MostrarMensaje("Libro devuelto.");
        }

        public void ListarPrestamos()
        {
            _view.MostrarPrestamos(_repo.Prestamos);
        }
    }
}
