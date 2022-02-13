using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidad;

namespace Negocio
{
    public class N_Producto
    {


        private D_Productos objD_Productos = new D_Productos();

        public List<Producto> List()
        {
            return objD_Productos.List();
        }

        public int Registrar(Producto productos, out string mensaje)
        {
            //Validaciones
            mensaje = string.Empty;

            if (productos.Codigo == "")
            {
                mensaje += "Introduce el codigo de producto\n";
            }

            if (productos.Nombre == "")
            {
                mensaje += "Introduce el nombre del producto\n ";
            }

            if (productos.Descripcion == "")
            {
                mensaje += "Introduce la descripción del producto\n";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objD_Productos.Registrar(productos, out mensaje);

            }

        }


        public bool Edit(Producto productos, out string mensaje)
        {


            //Validaciones
            mensaje = string.Empty;


            if (productos.Codigo == "")
            {
                mensaje += "Introduce el codigo de producto\n";
            }

            if (productos.Nombre == "")
            {
                mensaje += "Introduce el nombre del producto\n ";
            }

            if (productos.Descripcion == "")
            {
                mensaje += "Introduce la descripción del producto\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {

                return objD_Productos.Edit(productos, out mensaje);

            }
        }

        public bool Delete(Producto productos, out string mensaje)
        {
            return objD_Productos.Delete(productos, out mensaje);
        }

    }
}
