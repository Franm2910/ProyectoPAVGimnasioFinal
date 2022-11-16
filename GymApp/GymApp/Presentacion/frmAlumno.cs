using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using GymApp.Servicios;
using GymApp.Servicios.Implementaciones;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections;
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
    public partial class frmAlumno : Form
    {
        IAlumnoService AlumnoService = new AlumnoService();
        enum Acciones
        {
            Alta,
            Modificacion
        }
        private Acciones MiAccion;
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            this.LimpiarFiltro();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtNroDni.Text == "")
            {
                CargarGrilla(grdAlumno, AlumnoService.RecuperarTodos());
            }
            else
            {
                if (txtNroDni.Text == "")
                {
                    CargarGrilla(grdAlumno, AlumnoService.RecuperarFiltrados(txtNombre.Text, null));
                }
                else
                {
                    CargarGrilla(grdAlumno, AlumnoService.RecuperarFiltrados(txtNombre.Text, int.Parse(txtNroDni.Text)));
                }
            }
        }

        private void CargarGrilla(DataGridView grdAlumno, List<Alumno> alumnos)
        {
            grdAlumno.Rows.Clear();
            string FechaNacimiento;
            for (int i = 0; i < alumnos.Count; i++)
            {
                FechaNacimiento = alumnos[i].DiaNacimiento.ToString() + "/" + alumnos[i].MesNacimiento.ToString() + '/' + alumnos[i].AnioNacimiento.ToString();
                grdAlumno.Rows.Add(
                    alumnos[i].Nombre,
                    alumnos[i].Apellido,
                    FechaNacimiento,
                    alumnos[i].NroDocumento
                    );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            frmAlumnoAM frmAlAM = new frmAlumnoAM(MiAccion.ToString(), null);
            frmAlAM.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Modificacion;
            if (grdAlumno.CurrentRow != null)
            {
                frmAlumnoAM frmAlumnoAM = new frmAlumnoAM(MiAccion.ToString(), (long)grdAlumno.CurrentRow.Cells[3].Value);
                this.LimpiarFiltro();
                frmAlumnoAM.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdAlumno.CurrentRow != null)
            {
                int rowsAff = AlumnoService.BajaLogica((long)grdAlumno.CurrentRow.Cells[3].Value);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Alumno dado de baja.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("No se pudo dar de baja el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        // Funcion para limpiar los filtros
        private void LimpiarFiltro()
        {
            txtNombre.Text = "";
            txtNroDni.Text = "";
            List<Alumno> lstAl = new List<Alumno>();
            CargarGrilla(grdAlumno, lstAl);
            txtNombre.Focus();
        }
    }
}
