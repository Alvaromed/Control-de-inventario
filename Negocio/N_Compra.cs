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
    public class N_Compra
    {

        private D_Compras objD_Compras = new D_Compras();

        public int Obtener()
        {
            return objD_Compras.Obtener();
        }

        public bool Registrar(Compra compra, DataTable detalleCompra, out string mensaje)
        {

            return objD_Compras.Registrar(compra, detalleCompra, out mensaje);

        }

        public Compra ObtenerCompra(string numero)
        {
            Compra compra = objD_Compras.ObtenerCompra(numero);
            if (compra.IdCompra != 0)
            {
                List<Detalle_Compra> detalle_Compra = objD_Compras.ObtenerDetalleCompra(compra.IdCompra);

                compra.objListDetalleCompra = detalle_Compra;
            }

            return compra;

        }
       
    }

}
