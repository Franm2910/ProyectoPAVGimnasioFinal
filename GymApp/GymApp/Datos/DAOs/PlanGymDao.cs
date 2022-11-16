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

    internal class PlanGymDao : IPlanGym
    {
        public List<PlanGym> recuperarTodos(string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT p.IdPlan, p.Nombre, p.Descripcion, p.FechaDesde, p.FechaHasta, p.NumDocAl, p.TipoDocAl, a.Nombre as NombreAlumno, a.Apellido FROM PlanGim p JOIN Alumno a ON p.NumDocAl= a.NumDoc WHERE FechaDesde >='" + fechaDesde + "' AND FechaHasta <='" + fechaHasta+"' AND Estado = 1";
            return MapeoListaPlan(DBHelper.obtenerInstancia().consultar(consulta));
        }
        public List<PlanGym> recuperarFiltrados(long nroDoc, string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT p.IdPlan, p.Nombre, p.Descripcion, p.FechaDesde, p.FechaHasta, p.NumDocAl, p.TipoDocAl, a.Nombre as NombreAlumno, a.Apellido FROM PlanGim p JOIN Alumno a ON p.NumDocAl= a.NumDoc WHERE p.FechaDesde >='" + fechaDesde + "' AND p.FechaHasta <='" + fechaHasta + "' AND p.NumDocAl =" + nroDoc +"AND Estado = 1";
            return MapeoListaPlan(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public PlanGym recuperarUno(int idPlan)
        {
            string consulta = "SELECT p.IdPlan, p.Nombre, p.Descripcion, p.FechaDesde, p.FechaHasta, p.NumDocAl, p.TipoDocAl, a.Nombre as NombreAlumno, a.Apellido FROM PlanGim p JOIN Alumno a ON p.NumDocAl= a.NumDoc WHERE IdPlan =" + idPlan + "AND Estado = 1";
            return MapeoPlan(DBHelper.obtenerInstancia().consultar(consulta));
        }

        //Baja Plan
        public bool DarBajaPlan(int plan)
        {
            string consutla = "UPDATE PlanGim SET Estado = 0 WHERE IdPlan = " + plan;
            if (DBHelper.obtenerInstancia().actualizar(consutla) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        // Transaccion Modificacion Plan ---------------------------------
        public bool ModificarConDetalle(PlanGym plan, List<DetallePlanGimnasio> ld)
        {
            bool aux = false;
            //Modificar Plan
            string consultaModifPlan = "UPDATE PlanGim SET Descripcion = '" + plan.Descripcion + "', FechaHasta = '" + plan.FechaHasta + "' WHERE IdPlan = "+ plan.IdPlan;
            DBHelper.obtenerInstancia().conectarConTransaccion();
            DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaModifPlan);
            //Modificar Detalle
                //Eliminar todos los detalles
            string consultaElimDetalles = "DELETE FROM DetallePlan WHERE IdPlan = " + plan.IdPlan;
            DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaElimDetalles);
            //Agregar los nuevos detalles
            for (int i = 0; i < ld.Count; i++)
            {
                DetallePlanGimnasio detalle = ld[i];
                string consultaDetalle = "INSERT INTO DetallePlan (IdPlan,IdEjercicio, Repeticiones, Series) VALUES (" + plan.IdPlan + "," + detalle.Ejercicio.IdEJ + "," + detalle.Repeticiones + "," + detalle.Series + ")";
                DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaDetalle);
            }
            aux = DBHelper.obtenerInstancia().desconectar();
            return aux;
        }

        //Transaccion Plan -------------------------------------------------

        public bool InsertarPlanConDetalle(PlanGym plan, List<DetallePlanGimnasio> ldp)
        {
            bool aux = false;

            //Insertar Plan
            string consultaPlan = "INSERT INTO PlanGim (Nombre, Descripcion, FechaDesde, FechaHasta, NumDocAl, TipoDocAl,Estado) VALUES ('" + plan.Nombre + "','" + plan.Descripcion + "','" + plan.FechaDesde + "','" + plan.FechaHasta + "'," + plan.Alumno.NroDocumento + "," + plan.Alumno.TipoDoc.IdTipoDoc + ", 1)";
            DBHelper.obtenerInstancia().conectarConTransaccion();
            DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaPlan);
            //Recuperar la Id del plan
            var nuevoId = DBHelper.obtenerInstancia().ConsultaSQLScalar("SELECT @@IDENTITY");
            plan.IdPlan = Convert.ToInt32(nuevoId);
            //Insertar detalles:
            for (int i = 0; i < ldp.Count; i++)
            {
                DetallePlanGimnasio detalle = ldp[i];
                string consultaDetalle = "INSERT INTO DetallePlan (IdPlan,IdEjercicio, Repeticiones, Series) VALUES (" + plan.IdPlan + "," + detalle.Ejercicio.IdEJ + "," + detalle.Repeticiones + "," + detalle.Series + ")";
                DBHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaDetalle);
            }
            aux = DBHelper.obtenerInstancia().desconectar();
            return aux;
        }


        //Mapeos-----------------------------------------------------------------
        private PlanGym MapeoPlan(DataTable tabla)
        {
            PlanGym plan = new PlanGym();
            plan.IdPlan = (int)tabla.Rows[0]["IdPlan"];
            plan.Descripcion = tabla.Rows[0]["Descripcion"].ToString();
            plan.Nombre = tabla.Rows[0]["Nombre"].ToString();
            plan.FechaDesde = (DateTime)tabla.Rows[0]["FechaDesde"];
            plan.FechaHasta = (DateTime)tabla.Rows[0]["FechaHasta"];
            plan.Alumno = new Alumno();
            plan.Alumno.Nombre = tabla.Rows[0]["NombreAlumno"].ToString();
            plan.Alumno.Apellido = tabla.Rows[0]["Apellido"].ToString();
            plan.Alumno.NroDocumento = (long)tabla.Rows[0]["NumDocAl"];
            plan.Alumno.TipoDoc = new TipoDocumento();
            plan.Alumno.TipoDoc.IdTipoDoc = (int)tabla.Rows[0]["TipoDocAl"];
            return plan;
        }
        private List<PlanGym> MapeoListaPlan(DataTable tabla)
        {
            List<PlanGym> listplan = new List<PlanGym>();
            foreach (DataRow row in tabla.Rows)
            {
                PlanGym plan = new PlanGym();
                plan.IdPlan = (int)row["IdPlan"];
                plan.Descripcion = row["Descripcion"].ToString();
                plan.Nombre = row["Nombre"].ToString();
                plan.FechaDesde = (DateTime)row["FechaDesde"];
                plan.FechaHasta = (DateTime)row["FechaHasta"];
                plan.Alumno = new Alumno();
                plan.Alumno.Nombre = row["NombreAlumno"].ToString();
                plan.Alumno.Apellido = row["Apellido"].ToString();
                plan.Alumno.NroDocumento = (long)row["NumDocAl"];
                plan.Alumno.TipoDoc = new TipoDocumento();
                plan.Alumno.TipoDoc.IdTipoDoc = (int)row["TipoDocAl"];
                listplan.Add(plan);
            }
            return listplan;
        }

    }
}
