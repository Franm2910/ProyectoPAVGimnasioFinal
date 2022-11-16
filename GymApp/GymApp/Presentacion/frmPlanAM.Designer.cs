namespace GymApp.Presentacion
{
    partial class frmPlanAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanAM));
            this.gbxPlan = new System.Windows.Forms.GroupBox();
            this.lblIdPlan = new System.Windows.Forms.Label();
            this.txtIdPlan = new System.Windows.Forms.TextBox();
            this.gbxAlumno = new System.Windows.Forms.GroupBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtNumeroDNI = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.cbxAlumnos = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gbxPeriodo = new System.Windows.Forms.GroupBox();
            this.s = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.gbxDetallePlan = new System.Windows.Forms.GroupBox();
            this.dgvDetallePlan = new System.Windows.Forms.DataGridView();
            this.ColIdEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRepeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAddEjercicio = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbxPlan.SuspendLayout();
            this.gbxAlumno.SuspendLayout();
            this.gbxPeriodo.SuspendLayout();
            this.gbxDetallePlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePlan)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPlan
            // 
            this.gbxPlan.Controls.Add(this.lblIdPlan);
            this.gbxPlan.Controls.Add(this.txtIdPlan);
            this.gbxPlan.Location = new System.Drawing.Point(38, 22);
            this.gbxPlan.Name = "gbxPlan";
            this.gbxPlan.Size = new System.Drawing.Size(403, 58);
            this.gbxPlan.TabIndex = 0;
            this.gbxPlan.TabStop = false;
            this.gbxPlan.Text = "Plan";
            // 
            // lblIdPlan
            // 
            this.lblIdPlan.AutoSize = true;
            this.lblIdPlan.Location = new System.Drawing.Point(166, 22);
            this.lblIdPlan.Name = "lblIdPlan";
            this.lblIdPlan.Size = new System.Drawing.Size(38, 13);
            this.lblIdPlan.TabIndex = 1;
            this.lblIdPlan.Text = "#Plan:";
            // 
            // txtIdPlan
            // 
            this.txtIdPlan.Location = new System.Drawing.Point(210, 19);
            this.txtIdPlan.Name = "txtIdPlan";
            this.txtIdPlan.Size = new System.Drawing.Size(168, 20);
            this.txtIdPlan.TabIndex = 0;
            // 
            // gbxAlumno
            // 
            this.gbxAlumno.Controls.Add(this.lblDocumento);
            this.gbxAlumno.Controls.Add(this.lblAlumno);
            this.gbxAlumno.Controls.Add(this.txtNumeroDNI);
            this.gbxAlumno.Controls.Add(this.txtTipoDocumento);
            this.gbxAlumno.Controls.Add(this.cbxAlumnos);
            this.gbxAlumno.Location = new System.Drawing.Point(38, 86);
            this.gbxAlumno.Name = "gbxAlumno";
            this.gbxAlumno.Size = new System.Drawing.Size(403, 101);
            this.gbxAlumno.TabIndex = 1;
            this.gbxAlumno.TabStop = false;
            this.gbxAlumno.Text = "Alumno";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(94, 63);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(114, 22);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(45, 13);
            this.lblAlumno.TabIndex = 3;
            this.lblAlumno.Text = "Alumno:";
            // 
            // txtNumeroDNI
            // 
            this.txtNumeroDNI.Location = new System.Drawing.Point(250, 59);
            this.txtNumeroDNI.Name = "txtNumeroDNI";
            this.txtNumeroDNI.Size = new System.Drawing.Size(129, 20);
            this.txtNumeroDNI.TabIndex = 2;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(169, 59);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(65, 20);
            this.txtTipoDocumento.TabIndex = 1;
            // 
            // cbxAlumnos
            // 
            this.cbxAlumnos.FormattingEnabled = true;
            this.cbxAlumnos.Location = new System.Drawing.Point(170, 19);
            this.cbxAlumnos.Name = "cbxAlumnos";
            this.cbxAlumnos.Size = new System.Drawing.Size(208, 21);
            this.cbxAlumnos.TabIndex = 0;
            this.cbxAlumnos.SelectionChangeCommitted += new System.EventHandler(this.cbxAlumnos_SelectionChangeCommitted);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(113, 232);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(327, 88);
            this.txtDescripcion.TabIndex = 2;
            // 
            // gbxPeriodo
            // 
            this.gbxPeriodo.Controls.Add(this.s);
            this.gbxPeriodo.Controls.Add(this.lblFechaDesde);
            this.gbxPeriodo.Controls.Add(this.dtpHasta);
            this.gbxPeriodo.Controls.Add(this.dtpDesde);
            this.gbxPeriodo.Location = new System.Drawing.Point(38, 338);
            this.gbxPeriodo.Name = "gbxPeriodo";
            this.gbxPeriodo.Size = new System.Drawing.Size(403, 68);
            this.gbxPeriodo.TabIndex = 1;
            this.gbxPeriodo.TabStop = false;
            this.gbxPeriodo.Text = "Periodo";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(247, 16);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(68, 13);
            this.s.TabIndex = 3;
            this.s.Text = "Fecha Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(44, 15);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 2;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(250, 29);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(128, 20);
            this.dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(47, 29);
            this.dtpDesde.MinDate = new System.DateTime(2022, 10, 11, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(128, 20);
            this.dtpDesde.TabIndex = 0;
            this.dtpDesde.Value = new System.DateTime(2022, 10, 11, 16, 53, 29, 0);
            // 
            // gbxDetallePlan
            // 
            this.gbxDetallePlan.Controls.Add(this.dgvDetallePlan);
            this.gbxDetallePlan.Location = new System.Drawing.Point(38, 428);
            this.gbxDetallePlan.Name = "gbxDetallePlan";
            this.gbxDetallePlan.Size = new System.Drawing.Size(402, 169);
            this.gbxDetallePlan.TabIndex = 3;
            this.gbxDetallePlan.TabStop = false;
            this.gbxDetallePlan.Text = "Detalle";
            // 
            // dgvDetallePlan
            // 
            this.dgvDetallePlan.AllowUserToAddRows = false;
            this.dgvDetallePlan.AllowUserToDeleteRows = false;
            this.dgvDetallePlan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetallePlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetallePlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdEjercicio,
            this.ColNombreEjercicio,
            this.ColSeries,
            this.ColRepeticiones});
            this.dgvDetallePlan.Location = new System.Drawing.Point(6, 19);
            this.dgvDetallePlan.Name = "dgvDetallePlan";
            this.dgvDetallePlan.ReadOnly = true;
            this.dgvDetallePlan.Size = new System.Drawing.Size(390, 133);
            this.dgvDetallePlan.TabIndex = 0;
            this.dgvDetallePlan.DoubleClick += new System.EventHandler(this.dgvDetallePlan_DoubleClick);
            // 
            // ColIdEjercicio
            // 
            this.ColIdEjercicio.HeaderText = "#Ejercicio";
            this.ColIdEjercicio.Name = "ColIdEjercicio";
            this.ColIdEjercicio.ReadOnly = true;
            // 
            // ColNombreEjercicio
            // 
            this.ColNombreEjercicio.HeaderText = "Nombre";
            this.ColNombreEjercicio.Name = "ColNombreEjercicio";
            this.ColNombreEjercicio.ReadOnly = true;
            // 
            // ColSeries
            // 
            this.ColSeries.HeaderText = "Series";
            this.ColSeries.Name = "ColSeries";
            this.ColSeries.ReadOnly = true;
            this.ColSeries.Width = 74;
            // 
            // ColRepeticiones
            // 
            this.ColRepeticiones.HeaderText = "Repeticiones";
            this.ColRepeticiones.Name = "ColRepeticiones";
            this.ColRepeticiones.ReadOnly = true;
            this.ColRepeticiones.Width = 74;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(35, 232);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(38, 631);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 29);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(192, 631);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 29);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAddEjercicio
            // 
            this.btnAddEjercicio.Location = new System.Drawing.Point(341, 631);
            this.btnAddEjercicio.Name = "btnAddEjercicio";
            this.btnAddEjercicio.Size = new System.Drawing.Size(100, 29);
            this.btnAddEjercicio.TabIndex = 7;
            this.btnAddEjercicio.Text = "Agregar Ejercicio";
            this.btnAddEjercicio.UseVisualStyleBackColor = true;
            this.btnAddEjercicio.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 197);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 193);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(321, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // frmPlanAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 707);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAddEjercicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.gbxDetallePlan);
            this.Controls.Add(this.gbxPeriodo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.gbxAlumno);
            this.Controls.Add(this.gbxPlan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlanAM";
            this.Text = "frmPlanAM";
            this.Load += new System.EventHandler(this.frmPlanAM_Load);
            this.gbxPlan.ResumeLayout(false);
            this.gbxPlan.PerformLayout();
            this.gbxAlumno.ResumeLayout(false);
            this.gbxAlumno.PerformLayout();
            this.gbxPeriodo.ResumeLayout(false);
            this.gbxPeriodo.PerformLayout();
            this.gbxDetallePlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPlan;
        private System.Windows.Forms.GroupBox gbxAlumno;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox gbxPeriodo;
        private System.Windows.Forms.GroupBox gbxDetallePlan;
        private System.Windows.Forms.DataGridView dgvDetallePlan;
        private System.Windows.Forms.TextBox txtIdPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdEjercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreEjercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRepeticiones;
        private System.Windows.Forms.Label lblIdPlan;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtNumeroDNI;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.ComboBox cbxAlumnos;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAddEjercicio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}