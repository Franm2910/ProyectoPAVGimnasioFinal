using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public  class Alumno
    {
        public long NroDocumento { get; set; }
        public TipoDocumento TipoDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DiaNacimiento { get; set; }
        public int MesNacimiento { get; set; }
        public int AnioNacimiento { get; set; } 
        public long Telefono { get; set; }
        public string Email { get; set; }
        public long TelefonoEmergencia { get; set; }
        public int Numero { get; set; }
        public string Calle { get; set; }
        public Barrio Barrio { get; set; }

    }
}
