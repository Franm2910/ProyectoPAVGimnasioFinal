namespace GymApp.Presentacion
{
    partial class frmReporteListado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteListado));
            this.rpvPlan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnListo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dsListadoPlanes = new GymApp.Reportes.dsListadoPlanes();
            this.dTPlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxPlan = new System.Windows.Forms.GroupBox();
            this.txtNombrePlan = new System.Windows.Forms.TextBox();
            this.lblNombrePlan = new System.Windows.Forms.Label();
            this.lblNumeroPlan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroPlan = new System.Windows.Forms.TextBox();
            this.gbxPeriodo = new System.Windows.Forms.GroupBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.gbxAlumno = new System.Windows.Forms.GroupBox();
            this.txtNombreAlummno = new System.Windows.Forms.TextBox();
            this.lblNombreAlummno = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPlanesBindingSource)).BeginInit();
            this.gbxPlan.SuspendLayout();
            this.gbxPeriodo.SuspendLayout();
            this.gbxAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvPlan
            // 
            this.rpvPlan.LocalReport.ReportEmbeddedResource = "GymApp.Reportes.rptListadoPlan.rdlc";
            this.rpvPlan.Location = new System.Drawing.Point(12, 244);
            this.rpvPlan.Name = "rpvPlan";
            this.rpvPlan.ServerReport.BearerToken = null;
            this.rpvPlan.Size = new System.Drawing.Size(776, 284);
            this.rpvPlan.TabIndex = 0;
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(628, 534);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(147, 37);
            this.btnListo.TabIndex = 1;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(178, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(374, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Generar listado de planes por mes";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(591, 162);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(103, 27);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dsListadoPlanes
            // 
            this.dsListadoPlanes.DataSetName = "dsListadoPlanes";
            this.dsListadoPlanes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTPlanesBindingSource
            // 
            this.dTPlanesBindingSource.DataMember = "DTPlanes";
            this.dTPlanesBindingSource.DataSource = this.dsListadoPlanes;
            // 
            // gbxPlan
            // 
            this.gbxPlan.Controls.Add(this.txtNombrePlan);
            this.gbxPlan.Controls.Add(this.lblNombrePlan);
            this.gbxPlan.Controls.Add(this.lblNumeroPlan);
            this.gbxPlan.Controls.Add(this.label3);
            this.gbxPlan.Controls.Add(this.txtNumeroPlan);
            this.gbxPlan.Location = new System.Drawing.Point(39, 139);
            this.gbxPlan.Name = "gbxPlan";
            this.gbxPlan.Size = new System.Drawing.Size(372, 71);
            this.gbxPlan.TabIndex = 10;
            this.gbxPlan.TabStop = false;
            this.gbxPlan.Text = "Plan";
            // 
            // txtNombrePlan
            // 
            this.txtNombrePlan.Location = new System.Drawing.Point(213, 37);
            this.txtNombrePlan.Name = "txtNombrePlan";
            this.txtNombrePlan.Size = new System.Drawing.Size(153, 20);
            this.txtNombrePlan.TabIndex = 5;
            // 
            // lblNombrePlan
            // 
            this.lblNombrePlan.AutoSize = true;
            this.lblNombrePlan.Location = new System.Drawing.Point(213, 18);
            this.lblNombrePlan.Name = "lblNombrePlan";
            this.lblNombrePlan.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePlan.TabIndex = 4;
            this.lblNombrePlan.Text = "Nombre";
            // 
            // lblNumeroPlan
            // 
            this.lblNumeroPlan.AutoSize = true;
            this.lblNumeroPlan.Location = new System.Drawing.Point(6, 19);
            this.lblNumeroPlan.Name = "lblNumeroPlan";
            this.lblNumeroPlan.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroPlan.TabIndex = 3;
            this.lblNumeroPlan.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // txtNumeroPlan
            // 
            this.txtNumeroPlan.Location = new System.Drawing.Point(9, 35);
            this.txtNumeroPlan.Name = "txtNumeroPlan";
            this.txtNumeroPlan.Size = new System.Drawing.Size(153, 20);
            this.txtNumeroPlan.TabIndex = 0;
            // 
            // gbxPeriodo
            // 
            this.gbxPeriodo.Controls.Add(this.lblFechaHasta);
            this.gbxPeriodo.Controls.Add(this.lblFechaDesde);
            this.gbxPeriodo.Controls.Add(this.dtpHasta);
            this.gbxPeriodo.Controls.Add(this.dtpDesde);
            this.gbxPeriodo.Location = new System.Drawing.Point(447, 62);
            this.gbxPeriodo.Name = "gbxPeriodo";
            this.gbxPeriodo.Size = new System.Drawing.Size(315, 71);
            this.gbxPeriodo.TabIndex = 9;
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
            // gbxAlumno
            // 
            this.gbxAlumno.Controls.Add(this.txtNombreAlummno);
            this.gbxAlumno.Controls.Add(this.lblNombreAlummno);
            this.gbxAlumno.Controls.Add(this.lblNroDoc);
            this.gbxAlumno.Controls.Add(this.lblTipoDoc);
            this.gbxAlumno.Controls.Add(this.txtNumeroDoc);
            this.gbxAlumno.Location = new System.Drawing.Point(39, 62);
            this.gbxAlumno.Name = "gbxAlumno";
            this.gbxAlumno.Size = new System.Drawing.Size(372, 71);
            this.gbxAlumno.TabIndex = 8;
            this.gbxAlumno.TabStop = false;
            this.gbxAlumno.Text = "Alumno";
            // 
            // txtNombreAlummno
            // 
            this.txtNombreAlummno.Location = new System.Drawing.Point(213, 37);
            this.txtNombreAlummno.Name = "txtNombreAlummno";
            this.txtNombreAlummno.Size = new System.Drawing.Size(153, 20);
            this.txtNombreAlummno.TabIndex = 5;
            // 
            // lblNombreAlummno
            // 
            this.lblNombreAlummno.AutoSize = true;
            this.lblNombreAlummno.Location = new System.Drawing.Point(213, 18);
            this.lblNombreAlummno.Name = "lblNombreAlummno";
            this.lblNombreAlummno.Size = new System.Drawing.Size(44, 13);
            this.lblNombreAlummno.TabIndex = 4;
            this.lblNombreAlummno.Text = "Nombre";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(6, 19);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(102, 13);
            this.lblNroDoc.TabIndex = 3;
            this.lblNroDoc.Text = "Número Documento";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(11, 23);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(0, 13);
            this.lblTipoDoc.TabIndex = 2;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(9, 35);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(153, 20);
            this.txtNumeroDoc.TabIndex = 0;
            this.txtNumeroDoc.TextChanged += new System.EventHandler(this.txtNumeroDoc_TextChanged);
            // 
            // frmReporteListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.gbxPlan);
            this.Controls.Add(this.gbxPeriodo);
            this.Controls.Add(this.gbxAlumno);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.rpvPlan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteListado";
            this.Text = "Listado de planes";
            this.Load += new System.EventHandler(this.frmReporteListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPlanesBindingSource)).EndInit();
            this.gbxPlan.ResumeLayout(false);
            this.gbxPlan.PerformLayout();
            this.gbxPeriodo.ResumeLayout(false);
            this.gbxPeriodo.PerformLayout();
            this.gbxAlumno.ResumeLayout(false);
            this.gbxAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPlan;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.BindingSource dTPlanesBindingSource;
        private Reportes.dsListadoPlanes dsListadoPlanes;
        private System.Windows.Forms.GroupBox gbxPlan;
        private System.Windows.Forms.TextBox txtNombrePlan;
        private System.Windows.Forms.Label lblNombrePlan;
        private System.Windows.Forms.Label lblNumeroPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroPlan;
        private System.Windows.Forms.GroupBox gbxPeriodo;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox gbxAlumno;
        private System.Windows.Forms.TextBox txtNombreAlummno;
        private System.Windows.Forms.Label lblNombreAlummno;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtNumeroDoc;
    }
}