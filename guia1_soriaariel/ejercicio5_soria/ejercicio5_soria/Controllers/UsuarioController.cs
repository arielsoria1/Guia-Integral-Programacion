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
    public class UsuarioController
    {
        private readonly BibliotecaRepository _repo;
        private readonly UsuarioView _view;

        public UsuarioController(BibliotecaRepository repo, UsuarioView view)
        {
            _repo = repo;
            _view = view;
        }

        public void AgregarUsuario()
        {
            var usuario = _view.CrearUsuario();
            _repo.Usuarios.Add(usuario);
        }

        public void ListarUsuarios()
        {
            _view.MostrarUsuarios(_repo.Usuarios);
        }

        public void EliminarUsuario()
        {
            var email = _view.PedirEmail();
            var usuario = _repo.Usuarios.FirstOrDefault(u => u.Email == email);
            if (usuario == null)
            {
                Console.WriteLine("Usuario no encontrado.");
                return;
            }

            _repo.Usuarios.Remove(usuario);
            Console.WriteLine("Usuario eliminado.");
        }

        public void EditarUsuario()
        {
            var email = _view.PedirEmail();
            var usuario = _repo.Usuarios.FirstOrDefault(u => u.Email == email);
            if (usuario == null)
            {
                Console.WriteLine("Usuario no encontrado.");
                return;
            }

            _view.EditarUsuario(usuario);
            Console.WriteLine("Usuario actualizado.");
        }

    }
}
