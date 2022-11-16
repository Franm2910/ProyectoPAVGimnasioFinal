using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public class Barrio
    {
        public int IdBarrio { get; set; }
        public string Nombre { get; set; }
        public Localidad Localidad { get; set; }
    }
}
