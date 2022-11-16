using GymApp.Datos;
using GymApp.Entidades;
using GymApp.Reportes;
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
    public partial class frmReporteListado : Form
    {
        IPlanGymService svPlanGym = new PlanGymService();
        IAlumnoService AlumnoService = new AlumnoService();

        public frmReporteListado()
        {
            InitializeComponent();
        }

        private void frmReporteListado_Load(object sender, EventArgs e)
        {
            
            //this.rpvPlan.RefreshReport();

           
        }

        private void cargarCombo(ComboBox combo, List<Mes> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Numero";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            rpvPlan.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("Desde", dtpDesde.Value.ToString("dd/MM/yyyy")), new ReportParameter("Hasta",dtpHasta.Value.ToString("dd/MM/yyyy")), new ReportParameter("nombre","--"), new ReportParameter("nro","--") });
            //DATASOURCE
            rpvPlan.LocalReport.DataSources.Clear();
            //       rpvPlan.LocalReport.DataSources.Add(new ReportDataSource("DTPlanes", DBHelper.obtenerInstancia().consultar("SELECT p.IdPlan as 'numeroPlan', p.Nombre as 'nombrePlan', a.Nombre + a.Apellido as 'nombreAlumno', p.FechaDesde, p.FechaHasta, p.Estado FROM PlanGim p JOIN Alumno a ON (p.NumDocAl = a.NumDoc) WHERE MONTH(p.FechaDesde) = " + (cmbMes.SelectedIndex + 1))));


            string consulta = "SELECT p.IdPlan as 'numeroPlan', p.Nombre as 'nombrePlan', a.Nombre + a.Apellido as 'nombreAlumno', p.FechaDesde, p.FechaHasta, p.Estado FROM PlanGim p JOIN Alumno a ON (p.NumDocAl = a.NumDoc) WHERE p.FechaDesde >= '" + dtpDesde.Value.ToString("yyyy/MM/dd") + "' AND p.FechaHasta <= '" + dtpHasta.Value.ToString("yyyy/MM/dd") + "'";
            if (txtNombreAlummno.Text == "" && txtNumeroDoc.Text == "" && txtNombrePlan.Text == "" && txtNumeroPlan.Text == "")
            {

                rpvPlan.LocalReport.DataSources.Add(new ReportDataSource("DTPlanes", DBHelper.obtenerInstancia().consultar(consulta)));

            }
            else
            {
                if (txtNumeroPlan.Text != "")
                {
                    consulta = consulta + " AND p.IdPlan = " + txtNumeroPlan.Text;
                }
                if (txtNombrePlan.Text != "")
                {
                    consulta = consulta + " AND p.Nombre LIKE '%" + txtNombrePlan.Text + "%'";
                }
                if (txtNumeroDoc.Text != "")
                {
                    consulta = consulta + " AND a.NumDoc = " + txtNumeroDoc.Text;
                     
                }
                if (txtNombreAlummno.Text != "")
                {
                    consulta = consulta + " AND ((a.Nombre LIKE '%" + txtNombreAlummno.Text + "%') OR (a.Apellido LIKE '%" + txtNombreAlummno.Text + "%'))";
                }
                rpvPlan.LocalReport.DataSources.Add(new ReportDataSource("DTPlanes", DBHelper.obtenerInstancia().consultar(consulta)));





            }
            rpvPlan.RefreshReport();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroDoc_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
