using GymApp.Datos;
using GymApp.Entidades;
using GymApp.Servicios.Implementaciones;
using GymApp.Servicios.Interfaces;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GymApp.Presentacion
{
    public partial class frmPlanReporte : Form
    {
        IPlanGymService svPlan = new PlanGymService();
        PlanGym plan = new PlanGym();
        public frmPlanReporte(int idPlan)
        {
            plan = svPlan.recuperarUno(idPlan);
            InitializeComponent();
        }

        private void frmPlanReporte_Load(object sender, EventArgs e)
        {
            rpvPlan.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("Desde", plan.FechaDesde.ToString()), new ReportParameter("Hasta", plan.FechaHasta.ToString()), new ReportParameter("alumno", plan.Alumno.Nombre + " " + plan.Alumno.Apellido), new ReportParameter("titulo", plan.Nombre) });
            //DATASOURCE
            rpvPlan.LocalReport.DataSources.Clear();
            rpvPlan.LocalReport.DataSources.Add(new ReportDataSource("DTDetallePlan", DBHelper.obtenerInstancia().consultar("SELECT d.IdEjercicio, d.Series, d.Repeticiones, e.Nombre, e.Descripcion FROM DetallePlan d JOIN Ejercicio e ON(d.IdEjercicio = e.IdEJ) WHERE d.IdPlan = "+ plan.IdPlan)));
            this.rpvPlan.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
