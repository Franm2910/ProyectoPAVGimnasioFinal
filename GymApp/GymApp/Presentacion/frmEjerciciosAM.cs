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
    public partial class frmEjerciciosAM : Form
    {
        private string Accion;
        private int? idEjer;
        IEjercicioService EJservice = new EjercicioService();
        IGrupoMuscularService GMservice = new GrupoMuscularService();
       
        public frmEjerciciosAM(string MiAccion, int? idEj)
        {
            InitializeComponent();
            txtIdEjercicio.Enabled = false;
            Accion = MiAccion;
            this.Text = MiAccion;
            if (idEj != null)
            {
                idEjer = idEj;
            }
        }
        private void frmEjerciciosAM_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbGrupoMuscular, GMservice.RecuperarTodos());
            if (Accion == "Modificacion")
            {
                CargarCampos(EJservice.RecuperarUno((int)idEjer));
            }
            if (Accion == "Consulta")
            {
                CargarCampos(EJservice.RecuperarUno((int)idEjer));
                txtDescripcion.Enabled = false;
                txtNombreEjercicio.Enabled = false;
                cmbGrupoMuscular.Enabled = false;
                btnAgregarGrupoMuscular.Enabled = false;
            }
        }

        private void CargarCampos(Ejercicio ej)
        {
            txtIdEjercicio.Text = ej.IdEJ.ToString();
            txtNombreEjercicio.Text = ej.Nombre;
            txtDescripcion.Text = ej.Descripcion;
            cmbGrupoMuscular.SelectedValue = ej.GrupoMuscular.IdGM;
        }

        private void CargarCombo(ComboBox combo, List<GrupoMuscular> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdGM";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Accion == "Alta")
            {
                Ejercicio ej = new Ejercicio();
                ej.Nombre = txtNombreEjercicio.Text;
                ej.Descripcion = txtDescripcion.Text;
                ej.GrupoMuscular = new GrupoMuscular();
                ej.GrupoMuscular.IdGM = (int)cmbGrupoMuscular.SelectedValue;
                int rowsAff = EJservice.InsertarUno(ej);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Ejercicio creado.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            if (Accion == "Modificacion")
            { 
                Ejercicio ej = new Ejercicio();
                ej.IdEJ = int.Parse(txtIdEjercicio.Text);
                ej.Nombre = txtNombreEjercicio.Text;
                ej.Descripcion = txtDescripcion.Text;
                ej.GrupoMuscular = new GrupoMuscular();
                ej.GrupoMuscular.IdGM = (int)cmbGrupoMuscular.SelectedValue;

                int rowsAff = EJservice.ActualizarEjercicio(ej);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Ejercicio actualizado.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el ejercicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                this.Close();
            }
            this.Close();
        }

        private void btnAgregarGrupoMuscular_Click(object sender, EventArgs e)
        {
            frmGrupoMuscularAM frmGrupoMuscularAM = new frmGrupoMuscularAM("Alta",null);
            frmGrupoMuscularAM.Show();
            CargarCombo(cmbGrupoMuscular, GMservice.RecuperarTodos());
        }
    }
}
