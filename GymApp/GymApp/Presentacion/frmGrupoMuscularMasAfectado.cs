using GymApp.Datos;
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
    public partial class frmGrupoMuscularMasAfectado : Form
    {
        public frmGrupoMuscularMasAfectado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDoc.Text != "")
            {
                consultarAlumno();
                rptvGrupoMuscular.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("Alumno", lblAlumno.Text) });

                rptvGrupoMuscular.LocalReport.DataSources.Clear();
                rptvGrupoMuscular.LocalReport.DataSources.Add(new ReportDataSource("DataSetGM",
                    DBHelper.obtenerInstancia().consultar("select gm.Nombre, gm.Descripcion, count(*) as 'CantidadEjercicios' from PlanGim pg join DetallePlan dp on dp.IdPlan = pg.IdPlan join Ejercicio ej on ej.IdEJ = dp.IdEjercicio join GrupoMuscular gm on gm.IdGM = ej.IdGM  where pg.NumDocAl =" + int.Parse(txtNumeroDoc.Text) + " group by gm.Nombre, gm.Descripcion, pg.NumDocAl ORDER BY CantidadEjercicios DESC ")));
                //having count(*) >= ALL(select count(*) from Ejercicio ejer join DetallePlan detP on detP.IdEjercicio = ejer.IdEJ join PlanGim plg on plg.IdPlan = detP.IdPlan where plg.NumDocAl = pg.NumDocAl group by ejer.IdGM)

            }
            this.rptvGrupoMuscular.RefreshReport();
        }
        private void consultarAlumno()
        {
            DataTable alumno = DBHelper.obtenerInstancia().consultar("Select Nombre, Apellido from Alumno where NumDoc =" + int.Parse(txtNumeroDoc.Text));
            printLabel(alumno);
        }
        private void printLabel(DataTable tabla)
        {
            lblAlumno.Text = tabla.Rows[0]["Nombre"].ToString() + " " + tabla.Rows[0]["Apellido"].ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
