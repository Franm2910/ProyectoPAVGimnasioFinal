using GymApp.Entidades;
using GymApp.Servicios.Implementaciones;
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
    public partial class frmPlanes : Form
    {
        ITipoDocumentoService tipoDocumentoService = new TipoDocumentoService();
        IPlanGymService svPlanGym = new PlanGymService();
        enum Acciones
        {
            Alta,
            Modificacion,
            Consulta
        }
        private Acciones miAccion;
        public frmPlanes()
        {
            InitializeComponent();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Alta;
            frmPlanAM frmPlanAM = new frmPlanAM(miAccion.ToString(), null);
            frmPlanAM.Show();
        }

        private void frmPlanes_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbTipoDoc, tipoDocumentoService.RecuperarTodos());
        }
        private void CargarCombo(ComboBox combo, List<TipoDocumento> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdTipoDoc";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNroDoc.Text == "" && cmbTipoDoc.SelectedIndex == -1)
            {
                CargarGrilla(grdPlan, svPlanGym.recuperarTodos(dtpDesde.Value.ToString("yyyy/MM/dd"), dtpHasta.Value.ToString("yyyy/MM/dd")));
            }
            else
            {
                if (txtNroDoc.Text == "")
                {
                    MessageBox.Show("Debe insertar un Número de Documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); 
                    return;
                }
                if (cmbTipoDoc.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elegir un tipo de documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                CargarGrilla(grdPlan, svPlanGym.recuperarFiltrados(long.Parse(txtNroDoc.Text), dtpDesde.Value.ToString("yyyy/MM/dd"), dtpHasta.Value.ToString("yyyy/MM/dd")));
            }
        }
        public void CargarGrilla(DataGridView grilla, List<PlanGym> lista)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].IdPlan,
                    lista[i].Alumno.Nombre + " " + lista[i].Alumno.Apellido,
                    lista[i].FechaDesde,
                    lista[i].FechaHasta
                    );
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdPlan.CurrentRow != null)
            {
                miAccion = Acciones.Modificacion;
                frmPlanAM frmPlanAM = new frmPlanAM(miAccion.ToString(), (int)grdPlan.CurrentRow.Cells[0].Value);
                frmPlanAM.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void grdPlan_DoubleClick(object sender, EventArgs e)
        {
            if (grdPlan.CurrentRow != null)
            {
                /* miAccion = Acciones.Consulta;
                 frmPlanAM frmPlanAM = new frmPlanAM(miAccion.ToString(), (int)grdPlan.CurrentRow.Cells[0].Value);
                 frmPlanAM.Show();*/
                frmPlanReporte frmPlanReporte = new frmPlanReporte((int)grdPlan.CurrentRow.Cells[0].Value);
                frmPlanReporte.Show();
            }
            else
            {
                MessageBox.Show("Debe elegir un plan primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdPlan.CurrentRow != null)
            {
                if (MessageBox.Show("Estas seguro de eliminar el Plan", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if ((svPlanGym.DarBajaPlan((int)grdPlan.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("Plan eliminado.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
