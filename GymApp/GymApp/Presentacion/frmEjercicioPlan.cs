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
    public partial class frmEjercicioPlan : Form
    {
        public DetallePlanGimnasio detalle;
        public bool flag = false; 
        IEjercicioService svEjercicioService = new EjercicioService();
        public frmEjercicioPlan()
        {
            InitializeComponent();
        }

        private void frmEjercicioPlan_Load(object sender, EventArgs e)
        {
           
            CargarCombo(cmbEjercicio, svEjercicioService.RecuperarTodos());
            txtGrupoMuscular.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void CargarCombo(ComboBox combo, List<Ejercicio> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdEJ";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbEjercicio.SelectedIndex == -1 || txtSerie.Text == "" || txtRepeticiones.Text == "")
            {
                MessageBox.Show("Error en la introduccion de datos", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (Int32.Parse(txtSerie.Text) <= 0 || Int32.Parse(txtRepeticiones.Text) <= 0)
            {
                MessageBox.Show("Debe insertar un numero positivo para las series y repeticiones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                detalle = new DetallePlanGimnasio();
                detalle.Ejercicio = new Ejercicio();
                detalle.Ejercicio = cmbEjercicio.SelectedItem as Ejercicio;
                detalle.Series = Int32.Parse(txtSerie.Text);
                detalle.Repeticiones = Int32.Parse(txtRepeticiones.Text);
                flag = true;
                this.Close();
            }
        }

        private void cmbEjercicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var ejercicio = cmbEjercicio.SelectedItem as Ejercicio;
            txtGrupoMuscular.Text = ejercicio.GrupoMuscular.Nombre;
            txtDescripcion.Text = ejercicio.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            flag = false;
            this.Close();
        }
    }
}
