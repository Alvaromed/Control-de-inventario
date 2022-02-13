using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Detalle_Venta
    {
        public  int IdDetalleVenta { get; set; }
        public Producto objProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal subTotal { get; set; }
        public string fechRegistro { get; set; }
    }
}
