using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio5_soria.Models;

namespace ejercicio5_soria.Views
{
    public class PrestamoView
    {
        public void MostrarPrestamos(List<Prestamo> prestamos)
        {
            foreach (var p in prestamos)
                Console.WriteLine(p);
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
