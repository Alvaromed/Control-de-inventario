using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class Compra
    {
        public int IdCompra { get; set; }
        public Usuario objUsuario { get; set; }
        public Proveedor objProveedor { get; set; }
        public string TipoDocumento{ get; set; }
        public string NumeroDocumento{ get; set; }
        public decimal MontoTotal { get; set; }
        public List<Detalle_Compra> objListDetalleCompra { get; set; }
        public string fechaRegistro { get; set; }
    }
}
