
namespace GymApp.Presentacion
{
    partial class frmGrupoMuscularMasAfectado
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupoMuscularMasAfectado));
            this.dsGrupoMuscularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGrupoMuscular = new GymApp.Reportes.dsGrupoMuscular();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxAlumno = new System.Windows.Forms.GroupBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.rptvGrupoMuscular = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupoMuscularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupoMuscular)).BeginInit();
            this.gbxAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsGrupoMuscularBindingSource
            // 
            this.dsGrupoMuscularBindingSource.DataSource = this.dsGrupoMuscular;
            this.dsGrupoMuscularBindingSource.Position = 0;
            // 
            // dsGrupoMuscular
            // 
            this.dsGrupoMuscular.DataSetName = "dsGrupoMuscular";
            this.dsGrupoMuscular.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(406, 31);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Grupo Muscular más Afectado";
            // 
            // gbxAlumno
            // 
            this.gbxAlumno.Controls.Add(this.lblAlumno);
            this.gbxAlumno.Controls.Add(this.lblNroDoc);
            this.gbxAlumno.Controls.Add(this.lblTipoDoc);
            this.gbxAlumno.Controls.Add(this.btnBuscar);
            this.gbxAlumno.Controls.Add(this.txtNumeroDoc);
            this.gbxAlumno.Location = new System.Drawing.Point(12, 87);
            this.gbxAlumno.Name = "gbxAlumno";
            this.gbxAlumno.Size = new System.Drawing.Size(530, 77);
            this.gbxAlumno.TabIndex = 15;
            this.gbxAlumno.TabStop = false;
            this.gbxAlumno.Text = "Alumno";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(198, 31);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(0, 25);
            this.lblAlumno.TabIndex = 13;
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
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(446, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 20);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(9, 35);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(153, 20);
            this.txtNumeroDoc.TabIndex = 0;
            // 
            // rptvGrupoMuscular
            // 
            reportDataSource1.Name = "DataSetGM";
            reportDataSource1.Value = this.dsGrupoMuscularBindingSource;
            this.rptvGrupoMuscular.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvGrupoMuscular.LocalReport.ReportEmbeddedResource = "GymApp.Reportes.rptGrupoMuscular.rdlc";
            this.rptvGrupoMuscular.Location = new System.Drawing.Point(12, 178);
            this.rptvGrupoMuscular.Name = "rptvGrupoMuscular";
            this.rptvGrupoMuscular.ServerReport.BearerToken = null;
            this.rptvGrupoMuscular.Size = new System.Drawing.Size(776, 355);
            this.rptvGrupoMuscular.TabIndex = 17;
            this.rptvGrupoMuscular.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(685, 142);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 22);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmGrupoMuscularMasAfectado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rptvGrupoMuscular);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxAlumno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrupoMuscularMasAfectado";
            this.Text = "Reporte de Grupos Musculares mas afectados";
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupoMuscularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrupoMuscular)).EndInit();
            this.gbxAlumno.ResumeLayout(false);
            this.gbxAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxAlumno;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private Microsoft.Reporting.WinForms.ReportViewer rptvGrupoMuscular;
        private System.Windows.Forms.BindingSource dsGrupoMuscularBindingSource;
        private Reportes.dsGrupoMuscular dsGrupoMuscular;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Button btnSalir;
    }
}