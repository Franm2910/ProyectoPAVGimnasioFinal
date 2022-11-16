using GymApp.Entidades;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ejerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEjercicios frmEjercicios = new frmEjercicios();
            frmEjercicios.Show();
            this.Hide();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuario = new frmUsuarios();
            frmUsuario.Show();
            this.Hide();
        }

        private void grupoMuscularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupoMuscular frmGrupoMuscular = new frmGrupoMuscular();
            frmGrupoMuscular.Show();
            this.Hide();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlumno = new frmAlumno();
            frmAlumno.Show();
            this.Hide();
        }

        private void planesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPlanes frmPlanes = new frmPlanes();
            frmPlanes.Show();
            this.Hide();
        }
        private void barrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarrio frmBarrio = new frmBarrio();
            frmBarrio.Show();
            this.Hide();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidad frmLocalidad = new frmLocalidad();
            frmLocalidad.Show();
            this.Hide();
        }

        private void listadoPlanesPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteListado frmReporte = new frmReporteListado();
            frmReporte.Show();
            this.Hide();
        }

        private void ejerciciosMasUtilzadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteEjercicioMasUtilizados frmReporte = new frmReporteEjercicioMasUtilizados();
            frmReporte.Show();
            this.Hide();
        }

        private void grupoMuscularMásAfectadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupoMuscularMasAfectado frmReporteGM = new frmGrupoMuscularMasAfectado();
            frmReporteGM.Show();
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (Authorization.IdTipoUsuario == 1)
            {
                usuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                usuarioToolStripMenuItem.Visible = false;
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization.IdTipoUsuario = null;
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
            this.Hide();
        }
    }
}
