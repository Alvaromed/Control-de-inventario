using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string UsuarioLogin { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo{ get; set; }
        public string Pass { get; set; }
        public Rol objRol { get; set; }
        public bool Estado { get; set; }
        public string FechaCreacion { get; set; }
    }
}
