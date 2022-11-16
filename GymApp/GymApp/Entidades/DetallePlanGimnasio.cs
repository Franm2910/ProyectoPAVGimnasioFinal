using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public class DetallePlanGimnasio
    {
        public int IdPlan { get; set; }
        public Ejercicio Ejercicio { get; set; }
        public int Repeticiones { get; set; }
        public int Series { get; set; }
    }
}
