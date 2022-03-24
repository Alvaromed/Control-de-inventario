using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Venta
    {

        private D_Venta objD_Venta = new D_Venta();


        public bool RestarStock(int idProducto,int cantidad)
        {
            return objD_Venta.RestarStock(idProducto, cantidad);
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            return objD_Venta.SumarStock(idProducto, cantidad);
        }

        public int Obtener()
        {
            return objD_Venta.Obtener();
        }

        public bool Registrar(Venta venta, DataTable detalleVenta, out string mensaje)
        {

            return objD_Venta.Registrar(venta, detalleVenta, out mensaje);

        }
    }
}
