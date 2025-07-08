using ejercicio5_soria.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ejercicio5_soria.Data
{

    public class BibliotecaRepository
    {
        private const string Archivo = "Data/biblioteca.json";

        public List<Libro> Libros { get; set; } = new();
        public List<Usuario> Usuarios { get; set; } = new();
        public List<Prestamo> Prestamos { get; set; } = new();

        public BibliotecaRepository()
        {
            Cargar();
        }

        public void Guardar()
        {
            Directory.CreateDirectory("Data");
            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Archivo, json);
        }

        private void Cargar()
        {
            if (File.Exists(Archivo))
            {
                var json = File.ReadAllText(Archivo);

                using var doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                if (root.TryGetProperty("Libros", out var librosJson))
                {
                    Libros = JsonSerializer.Deserialize<List<Libro>>(librosJson.GetRawText());
                }

                if (root.TryGetProperty("Usuarios", out var usuariosJson))
                {
                    Usuarios = JsonSerializer.Deserialize<List<Usuario>>(usuariosJson.GetRawText());
                }

                if (root.TryGetProperty("Prestamos", out var prestamosJson))
                {
                    Prestamos = JsonSerializer.Deserialize<List<Prestamo>>(prestamosJson.GetRawText());
                }
            }
        }

    }
}
