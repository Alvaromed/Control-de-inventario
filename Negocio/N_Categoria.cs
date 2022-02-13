using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidad;


namespace Negocio
{
    public class N_Categoria
    {
        private D_Categoria objD_Categoria = new D_Categoria();

        public List<Categoria> List()
        {
            return objD_Categoria.List();
        }

        public int Registrar(Categoria Categoria, out string mensaje)
        {
            //Validaciones
            mensaje = string.Empty;

            if (Categoria.NombreCategoria == "")
            {
                mensaje += "Introduce el nombre de Categoria\n";
            }

           

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objD_Categoria.Registrar(Categoria, out mensaje);

            }

        }


        public bool Edit(Categoria Categoria, out string mensaje)
        {


            //Validaciones
            mensaje = string.Empty;

            if (Categoria.NombreCategoria == "")
            {
                mensaje += "Introduce el nombre de Categoria\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {

                return objD_Categoria.Edit(Categoria, out mensaje);

            }
        }

        public bool Delete(Categoria Categoria, out string mensaje)
        {
            return objD_Categoria.Delete(Categoria, out mensaje);
        }

    }
}
