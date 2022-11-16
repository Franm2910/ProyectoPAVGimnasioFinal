namespace GymApp.Presentacion
{
    partial class frmPlanes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanes));
            this.gbxAlumno = new System.Windows.Forms.GroupBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.gbxPeriodo = new System.Windows.Forms.GroupBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.grdPlan = new System.Windows.Forms.DataGridView();
            this.ColIdPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxAlumno.SuspendLayout();
            this.gbxPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAlumno
            // 
            this.gbxAlumno.Controls.Add(this.lblNroDoc);
            this.gbxAlumno.Controls.Add(this.lblTipoDoc);
            this.gbxAlumno.Controls.Add(this.cmbTipoDoc);
            this.gbxAlumno.Controls.Add(this.txtNroDoc);
            this.gbxAlumno.Location = new System.Drawing.Point(25, 19);
            this.gbxAlumno.Name = "gbxAlumno";
            this.gbxAlumno.Size = new System.Drawing.Size(299, 71);
            this.gbxAlumno.TabIndex = 0;
            this.gbxAlumno.TabStop = false;
            this.gbxAlumno.Text = "Alumno";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(141, 23);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(102, 13);
            this.lblNroDoc.TabIndex = 3;
            this.lblNroDoc.Text = "Numero Documento";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(11, 21);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDoc.TabIndex = 2;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(14, 36);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(90, 21);
            this.cmbTipoDoc.TabIndex = 1;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(139, 35);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(153, 20);
            this.txtNroDoc.TabIndex = 0;
            // 
            // gbxPeriodo
            // 
            this.gbxPeriodo.Controls.Add(this.lblFechaHasta);
            this.gbxPeriodo.Controls.Add(this.lblFechaDesde);
            this.gbxPeriodo.Controls.Add(this.dtpHasta);
            this.gbxPeriodo.Controls.Add(this.dtpDesde);
            this.gbxPeriodo.Location = new System.Drawing.Point(335, 19);
            this.gbxPeriodo.Name = "gbxPeriodo";
            this.gbxPeriodo.Size = new System.Drawing.Size(299, 71);
            this.gbxPeriodo.TabIndex = 1;
            this.gbxPeriodo.TabStop = false;
            this.gbxPeriodo.Text = "Periodo";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(160, 18);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaHasta.TabIndex = 4;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(10, 18);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 2;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(163, 34);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(126, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(13, 34);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(126, 20);
            this.dtpDesde.TabIndex = 2;
            // 
            // grdPlan
            // 
            this.grdPlan.AllowUserToAddRows = false;
            this.grdPlan.AllowUserToDeleteRows = false;
            this.grdPlan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPlan.ColumnHeadersHeight = 30;
            this.grdPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdPlan,
            this.ColNombreAlumno,
            this.ColFechaDesde,
            this.ColFechaHasta});
            this.grdPlan.GridColor = System.Drawing.SystemColors.Control;
            this.grdPlan.Location = new System.Drawing.Point(70, 117);
            this.grdPlan.Margin = new System.Windows.Forms.Padding(2);
            this.grdPlan.Name = "grdPlan";
            this.grdPlan.ReadOnly = true;
            this.grdPlan.RowHeadersWidth = 51;
            this.grdPlan.RowTemplate.Height = 24;
            this.grdPlan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPlan.Size = new System.Drawing.Size(580, 238);
            this.grdPlan.TabIndex = 23;
            this.grdPlan.DoubleClick += new System.EventHandler(this.grdPlan_DoubleClick);
            // 
            // ColIdPlan
            // 
            this.ColIdPlan.HeaderText = "# Plan";
            this.ColIdPlan.MinimumWidth = 6;
            this.ColIdPlan.Name = "ColIdPlan";
            this.ColIdPlan.ReadOnly = true;
            this.ColIdPlan.Width = 115;
            // 
            // ColNombreAlumno
            // 
            this.ColNombreAlumno.HeaderText = "Nombre del Alumno";
            this.ColNombreAlumno.MinimumWidth = 6;
            this.ColNombreAlumno.Name = "ColNombreAlumno";
            this.ColNombreAlumno.ReadOnly = true;
            this.ColNombreAlumno.Width = 200;
            // 
            // ColFechaDesde
            // 
            this.ColFechaDesde.HeaderText = "Fecha Desde";
            this.ColFechaDesde.MinimumWidth = 6;
            this.ColFechaDesde.Name = "ColFechaDesde";
            this.ColFechaDesde.ReadOnly = true;
            this.ColFechaDesde.Width = 125;
            // 
            // ColFechaHasta
            // 
            this.ColFechaHasta.HeaderText = "Fecha Hasta";
            this.ColFechaHasta.Name = "ColFechaHasta";
            this.ColFechaHasta.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Location = new System.Drawing.Point(189, 379);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(46, 47);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(650, 379);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 47);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Location = new System.Drawing.Point(116, 379);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 47);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(39, 379);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 47);
            this.btnNuevo.TabIndex = 37;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::GymApp.Properties.Resources.buscar1;
            this.btnBuscar.Location = new System.Drawing.Point(661, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 38);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grdPlan);
            this.Controls.Add(this.gbxPeriodo);
            this.Controls.Add(this.gbxAlumno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlanes";
            this.Text = "Administrador de Planes";
            this.Load += new System.EventHandler(this.frmPlanes_Load);
            this.gbxAlumno.ResumeLayout(false);
            this.gbxAlumno.PerformLayout();
            this.gbxPeriodo.ResumeLayout(false);
            this.gbxPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAlumno;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.GroupBox gbxPeriodo;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DataGridView grdPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaHasta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
    }
}