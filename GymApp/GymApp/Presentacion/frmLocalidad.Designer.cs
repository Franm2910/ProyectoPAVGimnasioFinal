namespace GymApp.Presentacion
{
    partial class frmLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalidad));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grdLocalidad = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreEjercicio = new System.Windows.Forms.Label();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdLocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.Location = new System.Drawing.Point(246, 36);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(46, 47);
            this.btnConsultar.TabIndex = 49;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.BackgroundImage")));
            this.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(307, 36);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(46, 47);
            this.btnLimpiarFiltros.TabIndex = 50;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(307, 331);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 47);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Location = new System.Drawing.Point(102, 331);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 47);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(25, 331);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 47);
            this.btnNuevo.TabIndex = 45;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grdLocalidad
            // 
            this.grdLocalidad.AllowUserToAddRows = false;
            this.grdLocalidad.AllowUserToDeleteRows = false;
            this.grdLocalidad.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdLocalidad.ColumnHeadersHeight = 30;
            this.grdLocalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.ColLocalidad});
            this.grdLocalidad.GridColor = System.Drawing.SystemColors.Control;
            this.grdLocalidad.Location = new System.Drawing.Point(28, 97);
            this.grdLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.grdLocalidad.Name = "grdLocalidad";
            this.grdLocalidad.ReadOnly = true;
            this.grdLocalidad.RowHeadersWidth = 51;
            this.grdLocalidad.RowTemplate.Height = 24;
            this.grdLocalidad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdLocalidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLocalidad.Size = new System.Drawing.Size(325, 192);
            this.grdLocalidad.TabIndex = 44;
            // 
            // colId
            // 
            this.colId.HeaderText = "#ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // ColLocalidad
            // 
            this.ColLocalidad.HeaderText = "Nombre Localidad";
            this.ColLocalidad.MinimumWidth = 6;
            this.ColLocalidad.Name = "ColLocalidad";
            this.ColLocalidad.ReadOnly = true;
            this.ColLocalidad.Width = 300;
            // 
            // lblNombreEjercicio
            // 
            this.lblNombreEjercicio.AutoSize = true;
            this.lblNombreEjercicio.Location = new System.Drawing.Point(25, 38);
            this.lblNombreEjercicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEjercicio.Name = "lblNombreEjercicio";
            this.lblNombreEjercicio.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEjercicio.TabIndex = 40;
            this.lblNombreEjercicio.Text = "Nombre:";
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Location = new System.Drawing.Point(27, 54);
            this.txtNombreLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(159, 20);
            this.txtNombreLocalidad.TabIndex = 41;
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 401);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grdLocalidad);
            this.Controls.Add(this.lblNombreEjercicio);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocalidad";
            this.Text = "frmLocalidad";
            ((System.ComponentModel.ISupportInitialize)(this.grdLocalidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView grdLocalidad;
        private System.Windows.Forms.Label lblNombreEjercicio;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLocalidad;
    }
}