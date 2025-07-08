using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio5_soria.Models;

namespace ejercicio5_soria.Views
{
    public class UsuarioView
    {
        public Usuario CrearUsuario()
        {
            Console.Write("Nombre: ");
            var nombre = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();

            return new Usuario { Nombre = nombre, Email = email };
        }

        public void MostrarUsuarios(List<Usuario> usuarios)
        {
            foreach (var usuario in usuarios)
                Console.WriteLine(usuario);
        }

        public string PedirEmail()
        {
            Console.Write("Ingrese email: ");
            return Console.ReadLine();
        }

        public Usuario EditarUsuario(Usuario usuario)
        {
            Console.Write($"Nuevo nombre ({usuario.Nombre}): ");
            var nombre = Console.ReadLine();

            usuario.Nombre = string.IsNullOrWhiteSpace(nombre) ? usuario.Nombre : nombre;
            return usuario;
        }

    }
}
