namespace GymApp.Presentacion
{
    partial class frmEjercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjercicios));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grdEjercicio = new System.Windows.Forms.DataGridView();
            this.ColIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.lblNombreEjercicio = new System.Windows.Forms.Label();
            this.txtNombreEjercicio = new System.Windows.Forms.TextBox();
            this.cmbGrupoMuscular = new System.Windows.Forms.ComboBox();
            this.lblGrupoMuscular = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdEjercicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Location = new System.Drawing.Point(176, 358);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(46, 47);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(524, 358);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 47);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Location = new System.Drawing.Point(99, 358);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 47);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(22, 358);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 47);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.Location = new System.Drawing.Point(465, 46);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(46, 47);
            this.btnConsultar.TabIndex = 27;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grdEjercicio
            // 
            this.grdEjercicio.AllowUserToAddRows = false;
            this.grdEjercicio.AllowUserToDeleteRows = false;
            this.grdEjercicio.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEjercicio.ColumnHeadersHeight = 30;
            this.grdEjercicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdUsuario,
            this.ColNombreUsuario,
            this.ColPerfil});
            this.grdEjercicio.GridColor = System.Drawing.SystemColors.Control;
            this.grdEjercicio.Location = new System.Drawing.Point(25, 124);
            this.grdEjercicio.Margin = new System.Windows.Forms.Padding(2);
            this.grdEjercicio.Name = "grdEjercicio";
            this.grdEjercicio.ReadOnly = true;
            this.grdEjercicio.RowHeadersWidth = 51;
            this.grdEjercicio.RowTemplate.Height = 24;
            this.grdEjercicio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdEjercicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEjercicio.Size = new System.Drawing.Size(478, 192);
            this.grdEjercicio.TabIndex = 22;
            this.grdEjercicio.DoubleClick += new System.EventHandler(this.grdEjercicio_DoubleClick);
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
            this.ColNombreUsuario.HeaderText = "Nombre de Ejercicio";
            this.ColNombreUsuario.MinimumWidth = 6;
            this.ColNombreUsuario.Name = "ColNombreUsuario";
            this.ColNombreUsuario.ReadOnly = true;
            this.ColNombreUsuario.Width = 175;
            // 
            // ColPerfil
            // 
            this.ColPerfil.HeaderText = "Grupo Muscular";
            this.ColPerfil.MinimumWidth = 6;
            this.ColPerfil.Name = "ColPerfil";
            this.ColPerfil.ReadOnly = true;
            this.ColPerfil.Width = 125;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.BackgroundImage")));
            this.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(526, 46);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(46, 47);
            this.btnLimpiarFiltros.TabIndex = 28;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // lblNombreEjercicio
            // 
            this.lblNombreEjercicio.AutoSize = true;
            this.lblNombreEjercicio.Location = new System.Drawing.Point(23, 48);
            this.lblNombreEjercicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEjercicio.Name = "lblNombreEjercicio";
            this.lblNombreEjercicio.Size = new System.Drawing.Size(102, 13);
            this.lblNombreEjercicio.TabIndex = 23;
            this.lblNombreEjercicio.Text = "Nombre de Ejercicio";
            // 
            // txtNombreEjercicio
            // 
            this.txtNombreEjercicio.Location = new System.Drawing.Point(25, 64);
            this.txtNombreEjercicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEjercicio.Name = "txtNombreEjercicio";
            this.txtNombreEjercicio.Size = new System.Drawing.Size(159, 20);
            this.txtNombreEjercicio.TabIndex = 24;
            // 
            // cmbGrupoMuscular
            // 
            this.cmbGrupoMuscular.FormattingEnabled = true;
            this.cmbGrupoMuscular.Location = new System.Drawing.Point(235, 63);
            this.cmbGrupoMuscular.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrupoMuscular.Name = "cmbGrupoMuscular";
            this.cmbGrupoMuscular.Size = new System.Drawing.Size(159, 21);
            this.cmbGrupoMuscular.TabIndex = 26;
            // 
            // lblGrupoMuscular
            // 
            this.lblGrupoMuscular.AutoSize = true;
            this.lblGrupoMuscular.Location = new System.Drawing.Point(233, 46);
            this.lblGrupoMuscular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupoMuscular.Name = "lblGrupoMuscular";
            this.lblGrupoMuscular.Size = new System.Drawing.Size(85, 13);
            this.lblGrupoMuscular.TabIndex = 25;
            this.lblGrupoMuscular.Text = "Grupo Muscular:";
            // 
            // frmEjercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grdEjercicio);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.lblNombreEjercicio);
            this.Controls.Add(this.txtNombreEjercicio);
            this.Controls.Add(this.cmbGrupoMuscular);
            this.Controls.Add(this.lblGrupoMuscular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEjercicios";
            this.Text = "Administración de Ejercicios";
            this.Load += new System.EventHandler(this.frmEjercicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEjercicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView grdEjercicio;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label lblNombreEjercicio;
        private System.Windows.Forms.TextBox txtNombreEjercicio;
        private System.Windows.Forms.ComboBox cmbGrupoMuscular;
        private System.Windows.Forms.Label lblGrupoMuscular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPerfil;
    }
}