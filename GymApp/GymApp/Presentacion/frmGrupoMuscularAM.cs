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
    public partial class frmGrupoMuscularAM : Form
    {
        private string Accion;
        private int? IdGrupoMuscular;
        IGrupoMuscularService GMservice = new GrupoMuscularService();
        public frmGrupoMuscularAM(string MiAccion, int? IdGM)
        {
            InitializeComponent();
            txtIdGrupoMuscular.Enabled = false;
            Accion = MiAccion;
            this.Text = MiAccion;
            if (IdGM != null)
            {
                IdGrupoMuscular = IdGM;
            }
        }

        private void frmGrupoMuscularAM_Load(object sender, EventArgs e)
        {
            if (Accion == "Modificacion")
            {
                CargarCampos(GMservice.RecuperarUno((int)IdGrupoMuscular));
            }
        }
        private void CargarCampos(GrupoMuscular gm)
        {
            txtIdGrupoMuscular.Text = gm.IdGM.ToString();
            txtNombreGrupoMuscular.Text = gm.Nombre;
            txtDescripcion.Text = gm.Descripcion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GrupoMuscular gm = new GrupoMuscular();
            gm.Nombre = txtNombreGrupoMuscular.Text;
            gm.Descripcion = txtDescripcion.Text;
            if (txtNombreGrupoMuscular.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (Accion == "Alta")
                {
                    if (GMservice.AgregarGrupoMuscular(gm) == 1)
                        MessageBox.Show("Grupo muscular" + gm.Nombre + " agregado", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    else
                        MessageBox.Show("No se pudo agregar el grupo muscular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    gm.IdGM = (int)IdGrupoMuscular;
                    int resultado = GMservice.ActualizarGrupoMuscular(gm);
                    if (resultado == 1)
                        MessageBox.Show("Grupo muscular actualizado.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    else
                        MessageBox.Show("No se pudo actualizar el grupo muscular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
