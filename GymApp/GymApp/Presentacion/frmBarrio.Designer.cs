namespace GymApp.Presentacion
{
    partial class frmBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarrio));
            this.lblNombreEjercicio = new System.Windows.Forms.Label();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.lblGrupoMuscular = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grdBarrio = new System.Windows.Forms.DataGridView();
            this.ColIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreEjercicio
            // 
            this.lblNombreEjercicio.AutoSize = true;
            this.lblNombreEjercicio.Location = new System.Drawing.Point(22, 31);
            this.lblNombreEjercicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEjercicio.Name = "lblNombreEjercicio";
            this.lblNombreEjercicio.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEjercicio.TabIndex = 27;
            this.lblNombreEjercicio.Text = "Nombre:";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Location = new System.Drawing.Point(24, 47);
            this.txtNombreBarrio.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(159, 20);
            this.txtNombreBarrio.TabIndex = 28;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(234, 46);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(159, 21);
            this.cmbLocalidad.TabIndex = 30;
            // 
            // lblGrupoMuscular
            // 
            this.lblGrupoMuscular.AutoSize = true;
            this.lblGrupoMuscular.Location = new System.Drawing.Point(232, 29);
            this.lblGrupoMuscular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupoMuscular.Name = "lblGrupoMuscular";
            this.lblGrupoMuscular.Size = new System.Drawing.Size(56, 13);
            this.lblGrupoMuscular.TabIndex = 29;
            this.lblGrupoMuscular.Text = "Localidad:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(524, 324);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 47);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Location = new System.Drawing.Point(99, 324);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 47);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(22, 324);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 47);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grdBarrio
            // 
            this.grdBarrio.AllowUserToAddRows = false;
            this.grdBarrio.AllowUserToDeleteRows = false;
            this.grdBarrio.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdBarrio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdBarrio.ColumnHeadersHeight = 30;
            this.grdBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdUsuario,
            this.colNombreBarrio,
            this.ColLocalidad});
            this.grdBarrio.GridColor = System.Drawing.SystemColors.Control;
            this.grdBarrio.Location = new System.Drawing.Point(25, 90);
            this.grdBarrio.Margin = new System.Windows.Forms.Padding(2);
            this.grdBarrio.Name = "grdBarrio";
            this.grdBarrio.ReadOnly = true;
            this.grdBarrio.RowHeadersWidth = 51;
            this.grdBarrio.RowTemplate.Height = 24;
            this.grdBarrio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdBarrio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBarrio.Size = new System.Drawing.Size(478, 192);
            this.grdBarrio.TabIndex = 33;
            // 
            // ColIdUsuario
            // 
            this.ColIdUsuario.HeaderText = "# ID";
            this.ColIdUsuario.MinimumWidth = 6;
            this.ColIdUsuario.Name = "ColIdUsuario";
            this.ColIdUsuario.ReadOnly = true;
            this.ColIdUsuario.Width = 125;
            // 
            // colNombreBarrio
            // 
            this.colNombreBarrio.HeaderText = "Nombre de Barrio";
            this.colNombreBarrio.MinimumWidth = 6;
            this.colNombreBarrio.Name = "colNombreBarrio";
            this.colNombreBarrio.ReadOnly = true;
            this.colNombreBarrio.Width = 175;
            // 
            // ColLocalidad
            // 
            this.ColLocalidad.HeaderText = "Localidad";
            this.ColLocalidad.MinimumWidth = 6;
            this.ColLocalidad.Name = "ColLocalidad";
            this.ColLocalidad.ReadOnly = true;
            this.ColLocalidad.Width = 125;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.Location = new System.Drawing.Point(463, 29);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(46, 47);
            this.btnConsultar.TabIndex = 38;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.BackgroundImage")));
            this.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(524, 29);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(46, 47);
            this.btnLimpiarFiltros.TabIndex = 39;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // frmBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 386);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grdBarrio);
            this.Controls.Add(this.lblNombreEjercicio);
            this.Controls.Add(this.txtNombreBarrio);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.lblGrupoMuscular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBarrio";
            this.Text = "Barrio";
            this.Load += new System.EventHandler(this.frmBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBarrio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEjercicio;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label lblGrupoMuscular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView grdBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLocalidad;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}