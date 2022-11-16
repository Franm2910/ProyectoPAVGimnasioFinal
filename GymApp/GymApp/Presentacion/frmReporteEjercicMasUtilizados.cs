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
    public partial class frmReporteEjercicioMasUtilizados : Form
    {
        IAlumnoService svAlumno = new AlumnoService();
        public frmReporteEjercicioMasUtilizados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alumno = cmbNombreAlumno.SelectedItem as Alumno;
            rpvEjercUtil.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("FechaDesde", dtpDesde.Value.ToString("dd/MM/yyyy")), new ReportParameter("FechaHasta", dtpHasta.Value.ToString("dd/MM/yyyy")) });

            if (cmbNombreAlumno.SelectedIndex == -1)
            {
                //DATASOURCE
                rpvEjercUtil.LocalReport.DataSources.Clear();
                rpvEjercUtil.LocalReport.DataSources.Add(new ReportDataSource("DTPlanesEjercicios", DBHelper.obtenerInstancia().consultar("SELECT e.IdEJ as 'numeroEjercicio', e.Nombre as 'nombreEjercicio', COUNT(dp.IdEjercicio) as 'cantidad' FROM PlanGim p JOIN DetallePlan dp ON (p.IdPlan = dp.IdPlan) JOIN Ejercicio e ON (e.IdEJ = dp.IdEjercicio) WHERE p.Estado = 1 AND p.FechaDesde >= '" + dtpDesde.Value.ToString("yyyy/MM/dd") + "' AND p.FechaHasta <= '" + dtpHasta.Value.ToString("yyyy/MM/dd") + "' GROUP BY e.IdEJ, e.Nombre ORDER BY cantidad DESC")));
                this.rpvEjercUtil.RefreshReport();
            }
            else
            {
                //DATASOURCE
                rpvEjercUtil.LocalReport.DataSources.Clear();
                rpvEjercUtil.LocalReport.DataSources.Add(new ReportDataSource("DTPlanesEjercicios", DBHelper.obtenerInstancia().consultar("SELECT e.IdEJ as 'numeroEjercicio', e.Nombre as 'nombreEjercicio', COUNT(dp.IdEjercicio) as 'cantidad' FROM PlanGim p JOIN DetallePlan dp ON (p.IdPlan = dp.IdPlan) JOIN Ejercicio e ON (e.IdEJ = dp.IdEjercicio) WHERE p.Estado = 1 AND p.FechaDesde >= '"+dtpDesde.Value.ToString("yyyy/MM/dd")+"' AND p.FechaHasta <= '" + dtpHasta.Value.ToString("yyyy/MM/dd")+"' AND p.NumDocAl = " + alumno.NroDocumento + " GROUP BY e.IdEJ, e.Nombre ORDER BY cantidad DESC")));
                this.rpvEjercUtil.RefreshReport();
            }

        }

        private void frmReporteEjercicioMasUtilizados_Load(object sender, EventArgs e)
        {

            CargarCombo(cmbNombreAlumno, svAlumno.RecuperarTodosNombApel());
            //
        }
        private void CargarCombo(ComboBox combo, List<Alumno> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "NroDocumento";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void lblNombreAlummno_Click(object sender, EventArgs e)
        {

        }

        private void cmbNombreAlumno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var alumno = cmbNombreAlumno.SelectedItem as Alumno;
            txtNumeroDoc.Text = alumno.NroDocumento.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
