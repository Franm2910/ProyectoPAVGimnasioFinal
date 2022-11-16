namespace GymApp.Presentacion
{
    partial class frmEjercicioPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjercicioPlan));
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.txtGrupoMuscular = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gbxEjercicio = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblGrupoMuscular = new System.Windows.Forms.Label();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.gbxDetalleEjercicio = new System.Windows.Forms.GroupBox();
            this.lblRepeticiones = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtRepeticiones = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbxEjercicio.SuspendLayout();
            this.gbxDetalleEjercicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(129, 28);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(255, 21);
            this.cmbEjercicio.TabIndex = 0;
            this.cmbEjercicio.SelectionChangeCommitted += new System.EventHandler(this.cmbEjercicio_SelectionChangeCommitted);
            // 
            // txtGrupoMuscular
            // 
            this.txtGrupoMuscular.Location = new System.Drawing.Point(129, 75);
            this.txtGrupoMuscular.Name = "txtGrupoMuscular";
            this.txtGrupoMuscular.Size = new System.Drawing.Size(255, 20);
            this.txtGrupoMuscular.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(129, 117);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(254, 95);
            this.txtDescripcion.TabIndex = 2;
            // 
            // gbxEjercicio
            // 
            this.gbxEjercicio.Controls.Add(this.lblDescripcion);
            this.gbxEjercicio.Controls.Add(this.lblGrupoMuscular);
            this.gbxEjercicio.Controls.Add(this.lblEjercicio);
            this.gbxEjercicio.Controls.Add(this.txtDescripcion);
            this.gbxEjercicio.Controls.Add(this.txtGrupoMuscular);
            this.gbxEjercicio.Controls.Add(this.cmbEjercicio);
            this.gbxEjercicio.Location = new System.Drawing.Point(9, 8);
            this.gbxEjercicio.Name = "gbxEjercicio";
            this.gbxEjercicio.Size = new System.Drawing.Size(410, 242);
            this.gbxEjercicio.TabIndex = 3;
            this.gbxEjercicio.TabStop = false;
            this.gbxEjercicio.Text = "Ejercicio";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(22, 120);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblGrupoMuscular
            // 
            this.lblGrupoMuscular.AutoSize = true;
            this.lblGrupoMuscular.Location = new System.Drawing.Point(22, 78);
            this.lblGrupoMuscular.Name = "lblGrupoMuscular";
            this.lblGrupoMuscular.Size = new System.Drawing.Size(85, 13);
            this.lblGrupoMuscular.TabIndex = 4;
            this.lblGrupoMuscular.Text = "Grupo Muscular:";
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.Location = new System.Drawing.Point(22, 31);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(50, 13);
            this.lblEjercicio.TabIndex = 3;
            this.lblEjercicio.Text = "Ejercicio:";
            // 
            // gbxDetalleEjercicio
            // 
            this.gbxDetalleEjercicio.Controls.Add(this.lblRepeticiones);
            this.gbxDetalleEjercicio.Controls.Add(this.lblSerie);
            this.gbxDetalleEjercicio.Controls.Add(this.txtRepeticiones);
            this.gbxDetalleEjercicio.Controls.Add(this.txtSerie);
            this.gbxDetalleEjercicio.Location = new System.Drawing.Point(9, 263);
            this.gbxDetalleEjercicio.Name = "gbxDetalleEjercicio";
            this.gbxDetalleEjercicio.Size = new System.Drawing.Size(409, 83);
            this.gbxDetalleEjercicio.TabIndex = 4;
            this.gbxDetalleEjercicio.TabStop = false;
            this.gbxDetalleEjercicio.Text = "Serie y Repeticiones";
            // 
            // lblRepeticiones
            // 
            this.lblRepeticiones.AutoSize = true;
            this.lblRepeticiones.Location = new System.Drawing.Point(236, 23);
            this.lblRepeticiones.Name = "lblRepeticiones";
            this.lblRepeticiones.Size = new System.Drawing.Size(69, 13);
            this.lblRepeticiones.TabIndex = 3;
            this.lblRepeticiones.Text = "Repeticiones";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(44, 23);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(36, 13);
            this.lblSerie.TabIndex = 2;
            this.lblSerie.Text = "Series";
            // 
            // txtRepeticiones
            // 
            this.txtRepeticiones.Location = new System.Drawing.Point(236, 37);
            this.txtRepeticiones.Name = "txtRepeticiones";
            this.txtRepeticiones.Size = new System.Drawing.Size(135, 20);
            this.txtRepeticiones.TabIndex = 1;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(45, 37);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(135, 20);
            this.txtSerie.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(245, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 29);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(89, 373);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 29);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmEjercicioPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbxDetalleEjercicio);
            this.Controls.Add(this.gbxEjercicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEjercicioPlan";
            this.Text = "Agregar Ejercicio";
            this.Load += new System.EventHandler(this.frmEjercicioPlan_Load);
            this.gbxEjercicio.ResumeLayout(false);
            this.gbxEjercicio.PerformLayout();
            this.gbxDetalleEjercicio.ResumeLayout(false);
            this.gbxDetalleEjercicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEjercicio;
        private System.Windows.Forms.TextBox txtGrupoMuscular;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox gbxEjercicio;
        private System.Windows.Forms.GroupBox gbxDetalleEjercicio;
        private System.Windows.Forms.Label lblRepeticiones;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtRepeticiones;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblGrupoMuscular;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}