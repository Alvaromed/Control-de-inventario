﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Permiso
    {
        public int IdPermiso { get; set; }
        public Rol objRol { get; set; }
        public string  NombreMenu{ get; set; }
        public string FechaCreacion { get; set; }

    }
}
