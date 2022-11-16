namespace GymApp.Presentacion
{
    partial class frmGrupoMuscular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupoMuscular));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grdGrupoMuscular = new System.Windows.Forms.DataGridView();
            this.ColIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.lblNombreGrupoMuscular = new System.Windows.Forms.Label();
            this.txtNombreGrupoMuscular = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupoMuscular)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Location = new System.Drawing.Point(184, 336);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(46, 47);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(532, 336);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 47);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Location = new System.Drawing.Point(107, 336);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 47);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(30, 336);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 47);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.Location = new System.Drawing.Point(473, 24);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(46, 47);
            this.btnConsultar.TabIndex = 38;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grdGrupoMuscular
            // 
            this.grdGrupoMuscular.AllowUserToAddRows = false;
            this.grdGrupoMuscular.AllowUserToDeleteRows = false;
            this.grdGrupoMuscular.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdGrupoMuscular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdGrupoMuscular.ColumnHeadersHeight = 30;
            this.grdGrupoMuscular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdUsuario,
            this.ColNombreUsuario});
            this.grdGrupoMuscular.GridColor = System.Drawing.SystemColors.Control;
            this.grdGrupoMuscular.Location = new System.Drawing.Point(33, 102);
            this.grdGrupoMuscular.Margin = new System.Windows.Forms.Padding(2);
            this.grdGrupoMuscular.Name = "grdGrupoMuscular";
            this.grdGrupoMuscular.ReadOnly = true;
            this.grdGrupoMuscular.RowHeadersWidth = 51;
            this.grdGrupoMuscular.RowTemplate.Height = 24;
            this.grdGrupoMuscular.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdGrupoMuscular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGrupoMuscular.Size = new System.Drawing.Size(478, 192);
            this.grdGrupoMuscular.TabIndex = 33;
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
            this.ColNombreUsuario.HeaderText = "Nombre de Gupo Muscular";
            this.ColNombreUsuario.MinimumWidth = 6;
            this.ColNombreUsuario.Name = "ColNombreUsuario";
            this.ColNombreUsuario.ReadOnly = true;
            this.ColNombreUsuario.Width = 175;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.BackgroundImage")));
            this.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(534, 24);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(46, 47);
            this.btnLimpiarFiltros.TabIndex = 39;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // lblNombreGrupoMuscular
            // 
            this.lblNombreGrupoMuscular.AutoSize = true;
            this.lblNombreGrupoMuscular.Location = new System.Drawing.Point(31, 35);
            this.lblNombreGrupoMuscular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreGrupoMuscular.Name = "lblNombreGrupoMuscular";
            this.lblNombreGrupoMuscular.Size = new System.Drawing.Size(137, 13);
            this.lblNombreGrupoMuscular.TabIndex = 34;
            this.lblNombreGrupoMuscular.Text = "Nombre de Grupo Muscular";
            // 
            // txtNombreGrupoMuscular
            // 
            this.txtNombreGrupoMuscular.Location = new System.Drawing.Point(33, 51);
            this.txtNombreGrupoMuscular.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreGrupoMuscular.Name = "txtNombreGrupoMuscular";
            this.txtNombreGrupoMuscular.Size = new System.Drawing.Size(159, 20);
            this.txtNombreGrupoMuscular.TabIndex = 35;
            // 
            // frmGrupoMuscular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 404);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grdGrupoMuscular);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.lblNombreGrupoMuscular);
            this.Controls.Add(this.txtNombreGrupoMuscular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrupoMuscular";
            this.Text = "Administrador Grupo Muscular";
            ((System.ComponentModel.ISupportInitialize)(this.grdGrupoMuscular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView grdGrupoMuscular;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label lblNombreGrupoMuscular;
        private System.Windows.Forms.TextBox txtNombreGrupoMuscular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreUsuario;
    }
}