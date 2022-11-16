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
    public partial class frmUsuarios : Form
    {
        //SERVICIOS
        IUsuarioService UsuarioS = new UsuarioService();

        ITipoUsuarioService TipoUsuarioS = new TipoUsuarioService();

        //ATRIBUTOS
        enum Acciones
        {
            None,
            Alta,
            Consulta,
            Modificacion
        }

        Acciones MiAccion;

        //CONSTRUCTOR
        public frmUsuarios()
        {
            InitializeComponent();
        }
        //MÉTODOS
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbTipoUsuario, TipoUsuarioS.RecuperarTodos());
            txtNombreUsuario.Focus();
            MiAccion = Acciones.None;
            AlternarBotones(false);
        }
        public void AlternarBotones(bool to)
        {
            btnEditar.Enabled = to;
            btnEliminar.Enabled = to;
        }
        public void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(
                    tabla.Rows[i]["IdUsuario"],
                    tabla.Rows[i]["NombreUsuario"],
                    tabla.Rows[i]["Clave"],
                    tabla.Rows[i]["Perfil"],
                    tabla.Rows[i]["Estado"]
                    );
            }
        }
        public void CargarGrilla2(DataGridView grilla, List<Usuario> lista)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].IdUsuario,
                    lista[i].NombreUsuario,
                    lista[i].Clave,
                    lista[i].TipoUsuario.Descripcion,
                    lista[i].Estado.Nombre
                    );
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

        private void AbrirFrmUsuariosAM(string accion, int? IdUsuario, frmUsuarios form)
        {
            frmUsuariosAM FrmUsuariosAM = new frmUsuariosAM(accion, IdUsuario, this);
            FrmUsuariosAM.Show();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            if (cmbTipoUsuario.SelectedIndex == -1 && txtNombreUsuario.Text == "")
            {
                CargarGrilla2(grdUsuarios, UsuarioS.RecuperarTodos());
            }
            else
            {
                if (cmbTipoUsuario.SelectedValue != null)
                {
                    CargarGrilla2(grdUsuarios, UsuarioS.RecuperarFiltrados(txtNombreUsuario.Text, (int)cmbTipoUsuario.SelectedValue));
                }
                else
                {
                    CargarGrilla2(grdUsuarios, UsuarioS.RecuperarFiltrados(txtNombreUsuario.Text, null));
                }
            }
            if (grdUsuarios.Rows.Count > 0)
            {
                AlternarBotones(true);
            }
        }

        private void btnLimpiarFiltros_Click_1(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = "";
            cmbTipoUsuario.SelectedIndex = -1;
            CargarGrilla2(grdUsuarios, UsuarioS.RecuperarTodos());
            txtNombreUsuario.Focus();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (grdUsuarios.CurrentRow.Cells[4].Value.ToString() == "Inhabilitado")
            {
                MessageBox.Show("Este usuario ya esta dado de baja, por favor intente con otro", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Está seguro de eliminar este usuario ?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UsuarioS.BajaLogicaUsuario((int)grdUsuarios.CurrentRow.Cells[0].Value);
                    CargarGrilla2(grdUsuarios, UsuarioS.RecuperarTodos());
                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (grdUsuarios.CurrentRow != null)
            {
                MiAccion = Acciones.Modificacion;
                AbrirFrmUsuariosAM(MiAccion.ToString(), (int)grdUsuarios.CurrentRow.Cells[0].Value, this);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            AbrirFrmUsuariosAM(MiAccion.ToString(), null, this);
        }
    }
}
