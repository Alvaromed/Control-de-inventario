using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;


//La capa de negocio es la encargada de comunicar la proyecto "Datos" y el proyecto "Control de inventario" 
namespace Negocio
{
    public class N_Usuario
    {

        private D_Usuario objD_Usuario = new D_Usuario();

        public List<Usuario> List()
        {
            return objD_Usuario.List();
        }

        public int Registrar(Usuario usuario,out string mensaje)
        {
            //Validaciones
            mensaje = string.Empty;

            if (usuario.UsuarioLogin == "")
            {
                mensaje += "Introduce el nombre de usuario\n";
            }

            if (usuario.NombreCompleto == "")
            {
                mensaje += "Introduce el nombre\n ";
            }

            if (usuario.Pass == "")
            {
                mensaje += "Introduce la contraseña de usuario\n";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objD_Usuario.Registrar(usuario, out mensaje);

            }

        }


        public bool Edit(Usuario usuario, out string mensaje)
        {


            //Validaciones
            mensaje = string.Empty;

            if (usuario.UsuarioLogin == "")
            {
                mensaje += "Introduce el nombre de usuario\n";
            }

            if (usuario.NombreCompleto == "")
            {
                mensaje += "Introduce el nombre\n ";
            }

            if (usuario.Pass == "")
            {
                mensaje += "Introduce la contraseña de usuario\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {

               return objD_Usuario.Edit(usuario, out mensaje);

            }
        }

        public bool Delete(Usuario usuario, out string mensaje)
        {
            return objD_Usuario.Delete(usuario, out mensaje);
        }

    }
}
