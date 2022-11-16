using GymApp.Entidades;
using GymApp.Servicios.Interfaces;
using GymApp.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymApp.Servicios.Implementaciones;

namespace GymApp.Presentacion
{
    public partial class frmBarrioAM : Form
    {
        private string Accion;
        private int? idBar;
        IBarrioService Brservice = new BarrioService();
        ILocalidadService LService = new LocalidadService();

        public frmBarrioAM(string MiAccion, int? IdBr)
        {
            InitializeComponent();
            Accion = MiAccion;
            this.Text = MiAccion;
            if (IdBr != null)
            {
                idBar = IdBr;
            }
        }

        private void frmBarrioAM_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbLocalidad, LService.RecuperarTodos());
            if (Accion == "Modificacion")
            {
                CargarCampos(Brservice.RecuperarUno((int)idBar));
            }
        }

        private void CargarCampos(Barrio br)
        {
            txtIdBarrio.Text = br.IdBarrio.ToString();
            txtNombreBarrio.Text = br.Nombre.ToString();
            cmbLocalidad.SelectedValue = br.Localidad.IdLocalidad;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Accion == "Alta")
            {
                Barrio br = new Barrio();
                br.Nombre = txtNombreBarrio.Text.ToString();
                br.Localidad = new Localidad();
                br.Localidad.IdLocalidad = (int)cmbLocalidad.SelectedValue;
                int rowsAff = Brservice.InsertarUno(br);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Barrio Creado");
                    this.Close();
                }
            }
            else
            {
                Barrio br = new Barrio();
                br.IdBarrio = int.Parse( txtIdBarrio.Text);
                br.Nombre = txtNombreBarrio.Text.ToString();
                br.Localidad = new Localidad();
                br.Localidad.IdLocalidad = (int)cmbLocalidad.SelectedValue;
                int rowsAff = Brservice.ActualizarBarrio(br);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Barrio modificado.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCombo(ComboBox combo, List<Localidad> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdLocalidad";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
