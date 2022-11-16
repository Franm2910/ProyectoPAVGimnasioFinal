using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Interfaces
{
    internal interface IPlanGymService
    {
        PlanGym recuperarUno(int idPlan);
        List<PlanGym> recuperarTodos(string FechaDesde, string FechaHasta);
        List<PlanGym> recuperarFiltrados(long nroDoc, string FechaDesde, string FechaHasta);
        bool DarBajaPlan(int plan);
        bool ModificarConDetalle(PlanGym plan, List<DetallePlanGimnasio> ld);
        bool InsertarPlanConDetalle(PlanGym plan, List<DetallePlanGimnasio> ldp);
    }
}
