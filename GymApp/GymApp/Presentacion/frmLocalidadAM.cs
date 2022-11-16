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
    public partial class frmLocalidadAM : Form
    {

        private string Accion;
        ILocalidadService Lservice = new LocalidadService();
        int? idLoc;
        public frmLocalidadAM(string MiAccion, int? idLoca)
        {
            InitializeComponent();
            Accion = MiAccion;
            this.Text = MiAccion;
            if (idLoca.HasValue)
            {
                idLoc = idLoca;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Accion == "Alta")
            {
                Localidad loc = new Localidad();
                loc.Nombre = txtNombreLocalidad.Text.ToString();
                int rowsAff = Lservice.InsertarUno(loc); 
                if (rowsAff > 0)
                {
                    MessageBox.Show("Localidad agregada.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                Localidad loc = new Localidad();
                loc.Nombre = txtNombreLocalidad.Text.ToString();
                loc.IdLocalidad = (int)idLoc;
                int rowsAff = Lservice.ActualizarLocalidad(loc);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Localidad actualizada.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la localidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLocalidadAM_Load(object sender, EventArgs e)
        {
            CargarCampos(Lservice.RecuperarUna((int)idLoc));
        }

        private void CargarCampos(Localidad localidad)
        {
            txtNombreLocalidad.Text = localidad.Nombre;
        }
    }
}