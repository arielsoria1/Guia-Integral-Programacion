using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5_soria.Models
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public bool Disponible { get; set; } = true;

        public override string ToString()
        {
            return $"{Titulo} - {Autor} (ISBN: {ISBN}) - {(Disponible ? "Disponible" : "Prestado")}";
        }
    }
}
