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
    public partial class frmUsuariosAM : Form
    {
        //SERVICIOS
        IUsuarioService UsuarioS = new UsuarioService();

        ITipoUsuarioService TipoUsuarioS = new TipoUsuarioService();

        IEstadoService EstadoS = new EstadoService();

        //ATRIBUTOS DE LA CLASE
        private string MiAccion;

        private frmUsuarios AdministrarUsuarios;

        private int? IdUsr;

        //CONSTRUCTOR
        public frmUsuariosAM(string action, int? IdUsuario, frmUsuarios formPadre)
        {
            InitializeComponent();
            this.Text = action + " de un Usuario";
            MiAccion = action;
            AdministrarUsuarios = formPadre;
            if (IdUsuario != null)
            {
                IdUsr = IdUsuario;
            }
        }

        private void frmUsuariosAM_Load(object sender, EventArgs e)
        {
            txtIdUsuario.Enabled = false;
            txtNombreUsuario.Focus();
            CargarCombo(cmbTipoUsuario, TipoUsuarioS.RecuperarTodos());
            CargarCombo(cmbEstado, EstadoS.RecuperarTodos());
            if (MiAccion == "Modificacion")
            {
                CargarCampos(UsuarioS.RecuperarUno((int)IdUsr));
            }
        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarCampos(Usuario usr)
        {
            txtIdUsuario.Text = usr.IdUsuario.ToString();
            txtNombreUsuario.Text = usr.NombreUsuario.ToString();
            txtClave.Text = usr.Clave.ToString();
            cmbTipoUsuario.SelectedValue = usr.TipoUsuario.IdTipoUsuario;
            cmbEstado.SelectedValue = usr.Estado.IdEstado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtClave.Text = "";
            cmbEstado.SelectedIndex = -1;
            cmbTipoUsuario.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Clave = txtClave.Text;
            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un estado, por favor intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                usuario.Estado = new Estado();
                usuario.Estado.IdEstado = (int)cmbEstado.SelectedValue;
            }
            if (cmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de Usuario, por favor intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                usuario.TipoUsuario = new TipoUsuario();
                usuario.TipoUsuario.IdTipoUsuario = (int)cmbTipoUsuario.SelectedValue;
            }

            if (MiAccion == "Modificacion")
            {
                usuario.IdUsuario = int.Parse(txtIdUsuario.Text);
                if (UsuarioS.Existe(txtNombreUsuario.Text, usuario.IdUsuario))
                {
                    MessageBox.Show("El nombre de usuario ingresado ya existe, por favor intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                    return;
                }
                else
                {
                    int rowsAff = UsuarioS.ActualizarUsuario(usuario);
                    if (rowsAff > 0)
                    {
                        MessageBox.Show("Usuario Actualizado", "Operación Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataGridView grdUsuarios = (DataGridView)AdministrarUsuarios.Controls["grdUsuarios"];
                        AdministrarUsuarios.CargarGrilla2(grdUsuarios, UsuarioS.RecuperarTodos());
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        Close();
                    }
                }
            }
            else
            {
                if (UsuarioS.Existe(txtNombreUsuario.Text, null))
                {
                    MessageBox.Show("El nombre de usuario ingresado ya existe, por favor intente de nuevo", "Error en la actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                    return;
                }
                else
                {
                    int rowsAff = UsuarioS.InsertarUsuario(usuario);
                    if (rowsAff > 0)
                    {
                        MessageBox.Show("Usuario insertado.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        DataGridView grdUsuarios = (DataGridView)AdministrarUsuarios.Controls["grdUsuarios"];
                        AdministrarUsuarios.CargarGrilla2(grdUsuarios, UsuarioS.RecuperarTodos());
                        AdministrarUsuarios.AlternarBotones(true);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); Close();
                    }
                }
            }
        }
    }
}
