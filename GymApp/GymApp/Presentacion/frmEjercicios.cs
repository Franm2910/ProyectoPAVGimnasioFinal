using GymApp.Entidades;
using GymApp.Servicios;
using GymApp.Servicios.Interfaces;
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
    public partial class frmEjercicios : Form
    {
        IGrupoMuscularService GMservice = new GrupoMuscularService();
        IEjercicioService EJservice = new EjercicioService();
        enum Acciones
        {
            Alta,
            Modificacion,
            Consulta
        }
        private Acciones MiAccion;
        public frmEjercicios()
        {
            InitializeComponent();
        }

        private void frmEjercicios_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbGrupoMuscular, GMservice.RecuperarTodos());
        }
        private void CargarCombo(ComboBox combo, List<GrupoMuscular> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdGM";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtNombreEjercicio.Text == "" && cmbGrupoMuscular.SelectedIndex == -1)
            {
                CargarGrilla(grdEjercicio, EJservice.RecuperarTodos());
            }
            else
            {
                if (cmbGrupoMuscular.SelectedValue != null)
                {
                    CargarGrilla(grdEjercicio, EJservice.RecuperarFiltrados(txtNombreEjercicio.Text, (int)cmbGrupoMuscular.SelectedValue));
                }
                else
                {
                    CargarGrilla(grdEjercicio, EJservice.RecuperarFiltrados(txtNombreEjercicio.Text, null));
                }
            }
        }

        public void CargarGrilla(DataGridView grilla, List<Ejercicio> lista)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].IdEJ,
                    lista[i].Nombre,
                    lista[i].GrupoMuscular.Nombre
                    ) ;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cmbGrupoMuscular.SelectedIndex = -1;
            txtNombreEjercicio.Text = "";
            List<Ejercicio> lstej = new List<Ejercicio>();
            CargarGrilla(grdEjercicio, lstej);
            txtNombreEjercicio.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            frmEjerciciosAM frmEjAM = new frmEjerciciosAM(MiAccion.ToString(), null);
            frmEjAM.Show(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdEjercicio.CurrentRow != null) 
            {
                MiAccion = Acciones.Modificacion;
                frmEjerciciosAM frmEjAM = new frmEjerciciosAM(MiAccion.ToString(), (int)grdEjercicio.CurrentRow.Cells[0].Value);
                frmEjAM.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un ejercicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar este ejercicio ?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int rowsAff = EJservice.EliminarEjercicio((int)grdEjercicio.CurrentRow.Cells[0].Value);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Ejercicio eliminado.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el ejercicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                //EJService.BajaLogicaUsuario((int)grdUsuarios.CurrentRow.Cells[0].Value);
                List<Ejercicio> lstej = new List<Ejercicio>();
                CargarGrilla(grdEjercicio, lstej);
            }
        }

        private void grdEjercicio_DoubleClick(object sender, EventArgs e)
        {
            MiAccion = Acciones.Consulta;
            frmEjerciciosAM frmEjAM = new frmEjerciciosAM(MiAccion.ToString(), (int)grdEjercicio.CurrentRow.Cells[0].Value);
            frmEjAM.Show();
        }
    }
}
