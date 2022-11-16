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
    public partial class frmLogIn : Form
    {
        IUsuarioService usrService= new UsuarioService();
        Usuario usuario = new Usuario();  
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == string.Empty) 
            {
                MessageBox.Show("Debe ingresar un Usuario...");
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtClave.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una Contraseña...");
                this.txtClave.Focus();
                return;
            }
            usuario = usrService.ValidarUsuario(txtUsuario.Text);
            if (usuario != null)
            {
                if (usuario.Clave == txtClave.Text)
                {
                    MessageBox.Show("Ingreso correcto", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Authorization.IdTipoUsuario = usuario.TipoUsuario.IdTipoUsuario;
                    frmPrincipal frmPrincipal = new frmPrincipal();
                    frmPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtClave.Text = string.Empty;
                    this.txtClave.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }
    }
}
