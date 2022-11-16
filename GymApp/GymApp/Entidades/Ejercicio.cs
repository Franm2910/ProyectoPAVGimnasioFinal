using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public class Ejercicio
    {
        public int IdEJ { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public GrupoMuscular GrupoMuscular { get; set; }
    }
}
