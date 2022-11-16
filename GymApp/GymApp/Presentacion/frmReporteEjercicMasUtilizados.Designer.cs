namespace GymApp.Presentacion
{
    partial class frmReporteEjercicioMasUtilizados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteEjercicioMasUtilizados));
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.gbxPeriodo = new System.Windows.Forms.GroupBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.gbxAlumno = new System.Windows.Forms.GroupBox();
            this.cmbNombreAlumno = new System.Windows.Forms.ComboBox();
            this.lblNombreAlummno = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rpvEjercUtil = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbxFiltros.SuspendLayout();
            this.gbxPeriodo.SuspendLayout();
            this.gbxAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.gbxPeriodo);
            this.gbxFiltros.Controls.Add(this.gbxAlumno);
            this.gbxFiltros.Location = new System.Drawing.Point(15, 9);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(772, 92);
            this.gbxFiltros.TabIndex = 0;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Alumno y periodo";
            // 
            // gbxPeriodo
            // 
            this.gbxPeriodo.Controls.Add(this.lblFechaHasta);
            this.gbxPeriodo.Controls.Add(this.lblFechaDesde);
            this.gbxPeriodo.Controls.Add(this.dtpHasta);
            this.gbxPeriodo.Controls.Add(this.dtpDesde);
            this.gbxPeriodo.Location = new System.Drawing.Point(433, 11);
            this.gbxPeriodo.Name = "gbxPeriodo";
            this.gbxPeriodo.Size = new System.Drawing.Size(315, 71);
            this.gbxPeriodo.TabIndex = 11;
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
            this.gbxAlumno.Controls.Add(this.cmbNombreAlumno);
            this.gbxAlumno.Controls.Add(this.lblNombreAlummno);
            this.gbxAlumno.Controls.Add(this.lblNroDoc);
            this.gbxAlumno.Controls.Add(this.lblTipoDoc);
            this.gbxAlumno.Controls.Add(this.txtNumeroDoc);
            this.gbxAlumno.Location = new System.Drawing.Point(25, 11);
            this.gbxAlumno.Name = "gbxAlumno";
            this.gbxAlumno.Size = new System.Drawing.Size(372, 71);
            this.gbxAlumno.TabIndex = 10;
            this.gbxAlumno.TabStop = false;
            this.gbxAlumno.Text = "Alumno";
            // 
            // cmbNombreAlumno
            // 
            this.cmbNombreAlumno.FormattingEnabled = true;
            this.cmbNombreAlumno.Location = new System.Drawing.Point(199, 33);
            this.cmbNombreAlumno.Name = "cmbNombreAlumno";
            this.cmbNombreAlumno.Size = new System.Drawing.Size(167, 21);
            this.cmbNombreAlumno.TabIndex = 5;
            this.cmbNombreAlumno.SelectionChangeCommitted += new System.EventHandler(this.cmbNombreAlumno_SelectionChangeCommitted);
            // 
            // lblNombreAlummno
            // 
            this.lblNombreAlummno.AutoSize = true;
            this.lblNombreAlummno.Location = new System.Drawing.Point(203, 18);
            this.lblNombreAlummno.Name = "lblNombreAlummno";
            this.lblNombreAlummno.Size = new System.Drawing.Size(92, 13);
            this.lblNombreAlummno.TabIndex = 4;
            this.lblNombreAlummno.Text = "Nombre y Apellido";
            this.lblNombreAlummno.Click += new System.EventHandler(this.lblNombreAlummno_Click);
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
            this.txtNumeroDoc.Enabled = false;
            this.txtNumeroDoc.Location = new System.Drawing.Point(9, 35);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(153, 20);
            this.txtNumeroDoc.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(238, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(173, 35);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rpvEjercUtil
            // 
            this.rpvEjercUtil.LocalReport.ReportEmbeddedResource = "GymApp.Reportes.rptEjerciciosMasUsadoEnPeriodo.rdlc";
            this.rpvEjercUtil.Location = new System.Drawing.Point(12, 148);
            this.rpvEjercUtil.Name = "rpvEjercUtil";
            this.rpvEjercUtil.ServerReport.BearerToken = null;
            this.rpvEjercUtil.Size = new System.Drawing.Size(775, 432);
            this.rpvEjercUtil.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(417, 107);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmReporteEjercicioMasUtilizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rpvEjercUtil);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbxFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteEjercicioMasUtilizados";
            this.Text = "Reporte de ejercicios más utilizados";
            this.Load += new System.EventHandler(this.frmReporteEjercicioMasUtilizados_Load);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxPeriodo.ResumeLayout(false);
            this.gbxPeriodo.PerformLayout();
            this.gbxAlumno.ResumeLayout(false);
            this.gbxAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.GroupBox gbxPeriodo;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox gbxAlumno;
        private System.Windows.Forms.Label lblNombreAlummno;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer rpvEjercUtil;
        private System.Windows.Forms.ComboBox cmbNombreAlumno;
        private System.Windows.Forms.Button btnSalir;
    }
}