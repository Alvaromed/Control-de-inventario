using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Datos;
using Entidad;

namespace Negocio
{
    public class N_Rol
    {
        private D_Rol objD_Rol = new D_Rol();

        public List<Rol> List()
        {
            return objD_Rol.List();
        }
    }
}
