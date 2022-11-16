using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.Interfaces
{
    internal interface IPlanGym
    {
        PlanGym recuperarUno(int idPlan);
        List<PlanGym> recuperarTodos(string fechaDesde, string fechaHasta);
        List<PlanGym> recuperarFiltrados(long nroDoc, string fechaDesde, string fechaHasta);
        bool DarBajaPlan(int plan);
        bool ModificarConDetalle(PlanGym plan, List<DetallePlanGimnasio> ld);
        bool InsertarPlanConDetalle(PlanGym plan, List<DetallePlanGimnasio> ldp);
    }
}
