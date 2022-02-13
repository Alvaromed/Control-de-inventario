using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidad;

namespace Negocio
{
   public class N_Permiso
    {
        private D_Permiso objD_Permiso = new D_Permiso();

        public List<Permiso> List(int idUsuario)
        {
            return objD_Permiso.List(idUsuario);
        }
    }
}
