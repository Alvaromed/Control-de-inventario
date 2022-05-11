using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Reporte
    {
        private D_Reporte obj_Reporte = new D_Reporte();
        public List<ReporteCompras> Compra(string fechaInicio,string fechaFin,int idProveedor)
        {
            return obj_Reporte.Compra(fechaInicio, fechaFin, idProveedor);
        }

        public List<ReporteVentas> Ventas(string fechaInicio, string fechaFin)
        {
            return obj_Reporte.Venta(fechaInicio, fechaFin);
        }
    }
}
