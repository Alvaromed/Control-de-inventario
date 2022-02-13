using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
 public class N_Proveedor
    {


        private D_Proveedor objD_Proveedor = new D_Proveedor();

        public List<Proveedor> List()
        {
            return objD_Proveedor.List();
        }

        public int Registrar(Proveedor proveedor, out string mensaje)
        {
            //Validaciones
            mensaje = string.Empty;

            if (proveedor.Documento == "")
            {
                mensaje += "Introduce el nombre de Proveedor\n";
            }

            if (proveedor.RazonSocial == "")
            {
                mensaje += "Introduce el nombre\n ";
            }

            if (proveedor.Telefono == "")
            {
                mensaje += "Introduce el teléfono del proveedor\n";
            }

            if (proveedor.Correo == "")
            {
                mensaje += "Introduce la contraseña de Proveedor\n";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objD_Proveedor.Registrar(proveedor, out mensaje);

            }

        }


        public bool Edit(Proveedor proveedor, out string mensaje)
        {


            //Validaciones
            mensaje = string.Empty;

            if (proveedor.Documento == "")
            {
                mensaje += "Introduce el nombre de Proveedor\n";
            }

            if (proveedor.RazonSocial == "")
            {
                mensaje += "Introduce el nombre\n ";
            }

            if (proveedor.Telefono == "")
            {
                mensaje += "Introduce el teléfono del proveedor\n";
            }

            if (proveedor.Correo == "")
            {
                mensaje += "Introduce la contraseña de Proveedor\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {

                return objD_Proveedor.Edit(proveedor, out mensaje);

            }
        }

        public bool Delete(Proveedor proveedor, out string mensaje)
        {
            return objD_Proveedor.Delete(proveedor, out mensaje);
        }

    }
}
