using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5_soria.Models
{
    public class Prestamo
    {
        public Libro Libro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            return $"'{Libro.Titulo}' prestado a {Usuario.Nombre} el {Fecha.ToShortDateString()}";
        }
    }
}
