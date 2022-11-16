
namespace GymApp.Presentacion
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.ColIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Location = new System.Drawing.Point(183, 349);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(46, 47);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(737, 349);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 47);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Location = new System.Drawing.Point(106, 349);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 47);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(29, 349);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 47);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.Location = new System.Drawing.Point(678, 37);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(46, 47);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUserToAddRows = false;
            this.grdUsuarios.AllowUserToDeleteRows = false;
            this.grdUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUsuarios.ColumnHeadersHeight = 30;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdUsuario,
            this.ColNombreUsuario,
            this.ColClave,
            this.ColPerfil,
            this.ColEstado});
            this.grdUsuarios.GridColor = System.Drawing.SystemColors.Control;
            this.grdUsuarios.Location = new System.Drawing.Point(32, 115);
            this.grdUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.RowHeadersWidth = 51;
            this.grdUsuarios.RowTemplate.Height = 24;
            this.grdUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsuarios.Size = new System.Drawing.Size(753, 192);
            this.grdUsuarios.TabIndex = 11;

            // 
            // ColIdUsuario
            // 
            this.ColIdUsuario.HeaderText = "# ID";
            this.ColIdUsuario.MinimumWidth = 6;
            this.ColIdUsuario.Name = "ColIdUsuario";
            this.ColIdUsuario.ReadOnly = true;
            this.ColIdUsuario.Width = 125;
            // 
            // ColNombreUsuario
            // 
            this.ColNombreUsuario.HeaderText = "Nombre de Usuario";
            this.ColNombreUsuario.MinimumWidth = 6;
            this.ColNombreUsuario.Name = "ColNombreUsuario";
            this.ColNombreUsuario.ReadOnly = true;
            this.ColNombreUsuario.Width = 175;
            // 
            // ColClave
            // 
            this.ColClave.HeaderText = "Clave";
            this.ColClave.MinimumWidth = 6;
            this.ColClave.Name = "ColClave";
            this.ColClave.ReadOnly = true;
            this.ColClave.Width = 125;
            // 
            // ColPerfil
            // 
            this.ColPerfil.HeaderText = "Perfil";
            this.ColPerfil.MinimumWidth = 6;
            this.ColPerfil.Name = "ColPerfil";
            this.ColPerfil.ReadOnly = true;
            this.ColPerfil.Width = 125;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.MinimumWidth = 6;
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            this.ColEstado.Width = 125;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.BackgroundImage")));
            this.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(739, 37);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(46, 47);
            this.btnLimpiarFiltros.TabIndex = 17;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click_1);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(30, 39);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblNombreUsuario.TabIndex = 12;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(32, 55);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(159, 20);
            this.txtNombreUsuario.TabIndex = 13;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(242, 54);
            this.cmbTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(159, 21);
            this.cmbTipoUsuario.TabIndex = 15;

            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(240, 37);
            this.lblTipoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(30, 13);
            this.lblTipoUsuario.TabIndex = 14;
            this.lblTipoUsuario.Text = "Perfil";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 432);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grdUsuarios);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblTipoUsuario;
    }
}