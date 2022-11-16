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
    public partial class frmGrupoMuscular : Form
    {
        IGrupoMuscularService GMService = new GrupoMuscularService();
        enum Acciones
        {
            Alta,
            Modificacion
        }
        private Acciones MiAccion;
        public frmGrupoMuscular()
        {
            InitializeComponent();
        }

        public void CargarGrilla(DataGridView grilla, List<GrupoMuscular> lista)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].IdGM,
                    lista[i].Nombre
                    );
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtNombreGrupoMuscular.Text == "")
            {
                CargarGrilla(grdGrupoMuscular, GMService.RecuperarTodos());
            }
            else
            {
                CargarGrilla(grdGrupoMuscular, GMService.RecuperarFiltrados(txtNombreGrupoMuscular.Text));
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtNombreGrupoMuscular.Text = "";
            List<GrupoMuscular> lstgm = new List<GrupoMuscular>();
            CargarGrilla(grdGrupoMuscular, lstgm);
            txtNombreGrupoMuscular.Focus();
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
            frmGrupoMuscularAM frmGMAM = new frmGrupoMuscularAM(MiAccion.ToString(), null);
            frmGMAM.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdGrupoMuscular.CurrentRow != null)
            {

                MiAccion = Acciones.Modificacion;
                int idGM = (int)grdGrupoMuscular.CurrentRow.Cells[0].Value;
                frmGrupoMuscularAM frmGrupoMuscularAM = new frmGrupoMuscularAM(MiAccion.ToString(), idGM);
                frmGrupoMuscularAM.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo muscular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdGrupoMuscular.CurrentRow != null)
            {

                if (MessageBox.Show("Estas seguro de eliminar el Grupo Muscular", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if ((GMService.DarDeBajaGrupoMuscular((int)grdGrupoMuscular.CurrentRow.Cells[0].Value)) == 1)
                    {
                        MessageBox.Show("Grupo muscular eliminado con éxito", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el grupo muscular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un grupo muscular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
