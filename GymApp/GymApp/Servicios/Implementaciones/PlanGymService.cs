using GymApp.Datos.DAOs;
using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Implementaciones
{
    internal class PlanGymService : IPlanGymService
    {
        IPlanGym dao = new PlanGymDao();

        public bool InsertarPlanConDetalle(PlanGym plan, List<DetallePlanGimnasio> ldp)
        {
            return dao.InsertarPlanConDetalle(plan, ldp);
        }

        public bool ModificarConDetalle(PlanGym plan, List<DetallePlanGimnasio> ld)
        {
            return dao.ModificarConDetalle(plan,ld);
        }

        public List<PlanGym> recuperarFiltrados(long nroDoc, string FechaDesde, string FechaHasta)
        {
            return dao.recuperarFiltrados(nroDoc, FechaDesde, FechaHasta);
        }

        public List<PlanGym> recuperarTodos(string FechaDesde, string FechaHasta)
        {
            return dao.recuperarTodos(FechaDesde, FechaHasta);
        }

        public PlanGym recuperarUno(int idPlan)
        {
            return dao.recuperarUno(idPlan);
        }
        public bool DarBajaPlan(int plan)
        {
            return dao.DarBajaPlan(plan);
        }
    }
}
