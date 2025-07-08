using System;

namespace ejercicio4_soria
{
    internal class Program
    {
        static void Main()
        {
            var repo = new ProductoRepository();
            var view = new ProductoView();
            var controller = new ProductoController(repo, view);

            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Ferretería de Ariel");
                Console.WriteLine("1) Agregar producto");
                Console.WriteLine("2) Eliminar producto");
                Console.WriteLine("3) Modificar producto");
                Console.WriteLine("4) Consultar productos");
                Console.WriteLine("0) Salir");
                Console.WriteLine("");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1: controller.Alta(); break;
                    case 2: controller.Baja(); break;
                    case 3: controller.Modificar(); break;
                    case 4: controller.Consultar(); break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("Presione ENTER para continuar...");
                    Console.ReadLine();
                }

            } while (opcion != 0);

            controller.Guardar();
            Console.WriteLine("Datos guardados. ¡Hasta luego!");
        }
    }
}
