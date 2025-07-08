using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ejercicio4_soria
{
    public class ProductoRepository
    {
        private const string FilePath = "productos.json";
        private List<Producto> _productos = new();

        public ProductoRepository()
        {
            Cargar();
        }

        public List<Producto> ObtenerTodos()
        {
            return _productos;
        }

        public void Agregar(Producto producto)
        {
            _productos.Add(producto);
        }

        public void Eliminar(int id)
        {
            var prod = _productos.FirstOrDefault(p => p.Id == id);
            if (prod != null)
                _productos.Remove(prod);
        }

        public Producto BuscarPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public void Guardar()
        {
            var json = JsonSerializer.Serialize(_productos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        private void Cargar()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                var data = JsonSerializer.Deserialize<List<Producto>>(json);
                if (data != null)
                    _productos = data;
            }
        }
    }
}
