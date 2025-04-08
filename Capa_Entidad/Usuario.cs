using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public required string Nombre { get; set;  }
        public required  string Apellidos { get; set; }
        public required string Correo { get; set;  }
        public required string Clave { get; set; }
        public bool Reestablecer { get; set;  }
        public bool Activo { get; set;  }
        public bool Eliminado { get; set; }
        public required string Fecha_Registro { get; set; }





    }
}
