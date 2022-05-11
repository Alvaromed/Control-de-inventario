using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public  class ReporteVentas
    {
        public string FechaRegistro { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string MontoTotal { get; set; }
        public string Usuario { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string NombreCategoria { get; set; }
        public string PrecioVenta { get; set; }
        public string Cantidad { get; set; }
        public string SubTotal { get; set; }
    }
}
