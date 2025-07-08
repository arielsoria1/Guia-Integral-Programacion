using System;
using System.Collections.Generic;

namespace ejercicio3_soria
{
    internal class Program
    {
        static void Main()
        {
            // Lista de precios simulada
            List<decimal> precios = new List<decimal> { 100.00m, 200.50m, 50.25m };

            // Calcular total
            var calculadora = new FacturaCalculator();
            decimal total = calculadora.CalcularTotal(precios);

            // Preparar contenido de la factura
            string contenidoFactura = $"Factura\n-----------\nTotal: ${total}";

            // Elegir tipo de impresión (digital o papel)
            IImprimible impresora = new ImpresoraDigital(); // Cambiar por: new ImpresoraPapel();
            var printer = new FacturaPrinter(impresora);
            printer.Imprimir(contenidoFactura);

            // Guardar la factura en archivo
            var saver = new FacturaSaver();
            saver.GuardarEnArchivo(contenidoFactura, "factura.txt");

            Console.WriteLine("Factura guardada correctamente.");

        }
    }
}
