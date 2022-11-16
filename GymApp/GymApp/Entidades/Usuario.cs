using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario{ get; set; }
        public string Clave { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public Estado Estado { get; set; }
    }
}
