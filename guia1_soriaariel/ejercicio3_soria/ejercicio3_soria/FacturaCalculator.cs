using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_soria
{
    public class FacturaCalculator
    {
        public decimal CalcularTotal(List<decimal> precios)
        {
            decimal total = 0;
            foreach (var precio in precios)
            {
                total += precio;
            }
            return total;
        }
    }
}
