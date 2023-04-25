using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class CompraDetalle
    {
        //propiedades
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        //composicion simple
        public Producto MiProducto { get; set; }

        public CompraDetalle()
        {
            MiProducto = new Producto();
        }
    }
}
