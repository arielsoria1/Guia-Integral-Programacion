using System;
using ejercicio5_soria.Data;
using ejercicio5_soria.Views;
using ejercicio5_soria.Controllers;
namespace ejercicio5_soria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new BibliotecaRepository();

            var libroController = new LibroController(repo, new LibroView());
            var usuarioController = new UsuarioController(repo, new UsuarioView());
            var prestamoController = new PrestamoController(repo, new PrestamoView());

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Biblioteca de Ariel");
                Console.WriteLine("1) Agregar libro");
                Console.WriteLine("2) Agregar usuario");
                Console.WriteLine("3) Mostrar libros disponibles");
                Console.WriteLine("4) Mostrar usuarios");
                Console.WriteLine("5) Prestar libro");
                Console.WriteLine("6) Devolver libro");
                Console.WriteLine("7) Mostrar préstamos");
                Console.WriteLine("8) Editar libro");
                Console.WriteLine("9) Eliminar libro");
                Console.WriteLine("10) Editar usuario");
                Console.WriteLine("11) Eliminar usuario");
                Console.WriteLine("0) Salir");
                Console.WriteLine("");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: libroController.AgregarLibro(); break;
                    case 2: usuarioController.AgregarUsuario(); break;
                    case 3: libroController.ListarDisponibles(); break;
                    case 4: usuarioController.ListarUsuarios(); break;
                    case 5:
                        Console.Write("ISBN: ");
                        var isbn = Console.ReadLine();
                        Console.Write("Email: ");
                        var email = Console.ReadLine();
                        prestamoController.PrestarLibro(isbn, email);
                        break;
                    case 6:
                        Console.Write("ISBN: ");
                        var isbnDev = Console.ReadLine();
                        prestamoController.DevolverLibro(isbnDev);
                        break;
                    case 7: prestamoController.ListarPrestamos(); break;
                    case 8: libroController.EditarLibro(); break;
                    case 9: libroController.EliminarLibro(); break;
                    case 10: usuarioController.EditarUsuario(); break;
                    case 11: usuarioController.EliminarUsuario(); break;

                }

                if (opcion != 0)
                {
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                }

            } while (opcion != 0);

            repo.Guardar();
            Console.WriteLine("Datos guardados"); ;
        }
    }
}
