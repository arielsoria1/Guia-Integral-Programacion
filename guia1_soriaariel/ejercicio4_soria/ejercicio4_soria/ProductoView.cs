using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4_soria
{
    public class ProductoView
    {
        public Producto CrearProducto()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());

            return new Producto
            {
                Id = id,
                Nombre = nombre,
                Precio = precio,
                Stock = stock
            };
        }

        public void MostrarProductos(System.Collections.Generic.List<Producto> productos)
        {
            foreach (var p in productos)
                Console.WriteLine(p);
        }

        public int PedirId()
        {
            Console.Write("Ingrese el ID: ");
            return int.Parse(Console.ReadLine());
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public void EditarProducto(Producto producto)
        {
            Console.WriteLine("Deje vacío si no desea modificar un campo.");

            Console.Write($"Nombre actual: {producto.Nombre} => ");
            string nombre = Console.ReadLine();
            if (!string.IsNullOrEmpty(nombre)) producto.Nombre = nombre;

            Console.Write($"Precio actual: {producto.Precio} => ");
            string precioStr = Console.ReadLine();
            if (!string.IsNullOrEmpty(precioStr)) producto.Precio = decimal.Parse(precioStr);

            Console.Write($"Stock actual: {producto.Stock} => ");
            string stockStr = Console.ReadLine();
            if (!string.IsNullOrEmpty(stockStr)) producto.Stock = int.Parse(stockStr);
        }
    }
}
