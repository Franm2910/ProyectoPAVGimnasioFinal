using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.DAOs
{
    internal class DetallePlanDao : IDetallePlan
    {
        public List<DetallePlanGimnasio> RecuperarTodos(int idPlan)
        {
            string consulta = "SELECT d.IdPlan, d.IdEjercicio, d.Repeticiones, d.Series, e.Nombre FROM DetallePlan d JOIN Ejercicio e ON d.IdEjercicio = e.IdEJ WHERE IdPlan =" + idPlan;
            return MapeoAListaDeDetallePlan(DBHelper.obtenerInstancia().consultar(consulta));
        }
        private DetallePlanGimnasio MapeoPlan(DataTable tabla)
        {
            DetallePlanGimnasio DetallePlan = new DetallePlanGimnasio();
            DetallePlan.IdPlan = (int)tabla.Rows[0]["IdPlan"];
            DetallePlan.Ejercicio.IdEJ = (int)tabla.Rows[0]["IdEjercicio"];
            DetallePlan.Ejercicio.Nombre = tabla.Rows[0]["Nombre"].ToString();
            DetallePlan.Repeticiones = (int)tabla.Rows[0]["Repeticiones"];
            DetallePlan.Series = (int)tabla.Rows[0]["Series"];
            return DetallePlan;
        }

        public List<DetallePlanGimnasio> MapeoAListaDeDetallePlan(DataTable tabla)
        {
            List<DetallePlanGimnasio> listDetalle = new List<DetallePlanGimnasio>();
            foreach (DataRow row in tabla.Rows)
            {
                DetallePlanGimnasio DetallePlan = new DetallePlanGimnasio();
                DetallePlan.IdPlan = (int)row["IdPlan"];
                DetallePlan.Ejercicio = new Ejercicio();
                DetallePlan.Ejercicio.IdEJ = (int)row["IdEjercicio"];
                DetallePlan.Ejercicio.Nombre = row["Nombre"].ToString();
                DetallePlan.Repeticiones = (int)row["Repeticiones"];
                DetallePlan.Series = (int)row["Series"];
                listDetalle.Add(DetallePlan);
            }
            return listDetalle;
        }

    }
}
