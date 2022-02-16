using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Negocio
    {

        private D_Negocio objD_Negocio = new D_Negocio();

        public E_Negocio ObtenerDatos()
        {
            return objD_Negocio.ObtenerDatos();
        }

        public bool guardarDatos(E_Negocio negocio, out string mensaje)
        {
            //Validaciones
            mensaje = string.Empty;

            if (negocio.Nombre == "")
            {
                mensaje += "Introduce el nombre de la empresa\n";
            }

            if (negocio.RFC == "")
            {
                mensaje += "Introduce el RFC de la empresa\n ";
            }

            if (negocio.Direccion == "")
            {
                mensaje += "Introduce la dirección de la empresa\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objD_Negocio.guardarDatos(negocio, out mensaje);

            }

        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objD_Negocio.ObtenerLogo( out obtenido);
        }


        public bool actualizarLogo(byte[] imagen,out string mensaje)
        {
            return objD_Negocio.actualizarLogo(imagen,out mensaje);
        }
    }

}
