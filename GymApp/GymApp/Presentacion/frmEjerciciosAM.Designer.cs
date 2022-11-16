namespace GymApp.Presentacion
{
    partial class frmEjerciciosAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjerciciosAM));
            this.grbAltaEjercicios = new System.Windows.Forms.GroupBox();
            this.btnAgregarGrupoMuscular = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNombreEjercicios = new System.Windows.Forms.Label();
            this.lblIdEjercicio = new System.Windows.Forms.Label();
            this.txtNombreEjercicio = new System.Windows.Forms.TextBox();
            this.txtIdEjercicio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbGrupoMuscular = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblGrupoMuscular = new System.Windows.Forms.Label();
            this.grbAltaEjercicios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAltaEjercicios
            // 
            this.grbAltaEjercicios.Controls.Add(this.btnAgregarGrupoMuscular);
            this.grbAltaEjercicios.Controls.Add(this.btnCancelar);
            this.grbAltaEjercicios.Controls.Add(this.btnAceptar);
            this.grbAltaEjercicios.Controls.Add(this.lblNombreEjercicios);
            this.grbAltaEjercicios.Controls.Add(this.lblIdEjercicio);
            this.grbAltaEjercicios.Controls.Add(this.txtNombreEjercicio);
            this.grbAltaEjercicios.Controls.Add(this.txtIdEjercicio);
            this.grbAltaEjercicios.Controls.Add(this.txtDescripcion);
            this.grbAltaEjercicios.Controls.Add(this.cmbGrupoMuscular);
            this.grbAltaEjercicios.Controls.Add(this.lblDescripcion);
            this.grbAltaEjercicios.Controls.Add(this.lblGrupoMuscular);
            this.grbAltaEjercicios.Location = new System.Drawing.Point(11, 11);
            this.grbAltaEjercicios.Margin = new System.Windows.Forms.Padding(2);
            this.grbAltaEjercicios.Name = "grbAltaEjercicios";
            this.grbAltaEjercicios.Padding = new System.Windows.Forms.Padding(2);
            this.grbAltaEjercicios.Size = new System.Drawing.Size(407, 326);
            this.grbAltaEjercicios.TabIndex = 12;
            this.grbAltaEjercicios.TabStop = false;
            this.grbAltaEjercicios.Text = "Ejercicio";
            // 
            // btnAgregarGrupoMuscular
            // 
            this.btnAgregarGrupoMuscular.Image = global::GymApp.Properties.Resources.nuevo1;
            this.btnAgregarGrupoMuscular.Location = new System.Drawing.Point(345, 199);
            this.btnAgregarGrupoMuscular.Name = "btnAgregarGrupoMuscular";
            this.btnAgregarGrupoMuscular.Size = new System.Drawing.Size(32, 27);
            this.btnAgregarGrupoMuscular.TabIndex = 13;
            this.btnAgregarGrupoMuscular.UseVisualStyleBackColor = true;
            this.btnAgregarGrupoMuscular.Click += new System.EventHandler(this.btnAgregarGrupoMuscular_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(254, 259);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(129, 259);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 28);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNombreEjercicios
            // 
            this.lblNombreEjercicios.AutoSize = true;
            this.lblNombreEjercicios.Location = new System.Drawing.Point(16, 76);
            this.lblNombreEjercicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEjercicios.Name = "lblNombreEjercicios";
            this.lblNombreEjercicios.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEjercicios.TabIndex = 2;
            this.lblNombreEjercicios.Text = "Nombre:";
            // 
            // lblIdEjercicio
            // 
            this.lblIdEjercicio.AutoSize = true;
            this.lblIdEjercicio.Location = new System.Drawing.Point(16, 37);
            this.lblIdEjercicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdEjercicio.Name = "lblIdEjercicio";
            this.lblIdEjercicio.Size = new System.Drawing.Size(28, 13);
            this.lblIdEjercicio.TabIndex = 10;
            this.lblIdEjercicio.Text = "# ID";
            // 
            // txtNombreEjercicio
            // 
            this.txtNombreEjercicio.Location = new System.Drawing.Point(129, 73);
            this.txtNombreEjercicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEjercicio.Name = "txtNombreEjercicio";
            this.txtNombreEjercicio.Size = new System.Drawing.Size(211, 20);
            this.txtNombreEjercicio.TabIndex = 1;
            // 
            // txtIdEjercicio
            // 
            this.txtIdEjercicio.Location = new System.Drawing.Point(129, 37);
            this.txtIdEjercicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEjercicio.Name = "txtIdEjercicio";
            this.txtIdEjercicio.Size = new System.Drawing.Size(211, 20);
            this.txtIdEjercicio.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(129, 107);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(211, 81);
            this.txtDescripcion.TabIndex = 2;
            // 
            // cmbGrupoMuscular
            // 
            this.cmbGrupoMuscular.FormattingEnabled = true;
            this.cmbGrupoMuscular.Location = new System.Drawing.Point(129, 202);
            this.cmbGrupoMuscular.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrupoMuscular.Name = "cmbGrupoMuscular";
            this.cmbGrupoMuscular.Size = new System.Drawing.Size(211, 21);
            this.cmbGrupoMuscular.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 107);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblGrupoMuscular
            // 
            this.lblGrupoMuscular.AutoSize = true;
            this.lblGrupoMuscular.Location = new System.Drawing.Point(16, 206);
            this.lblGrupoMuscular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupoMuscular.Name = "lblGrupoMuscular";
            this.lblGrupoMuscular.Size = new System.Drawing.Size(82, 13);
            this.lblGrupoMuscular.TabIndex = 7;
            this.lblGrupoMuscular.Text = "GrupoMuscular:";
            // 
            // frmEjerciciosAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 355);
            this.Controls.Add(this.grbAltaEjercicios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEjerciciosAM";
            this.Text = "frmEjerciciosAM";
            this.Load += new System.EventHandler(this.frmEjerciciosAM_Load);
            this.grbAltaEjercicios.ResumeLayout(false);
            this.grbAltaEjercicios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAltaEjercicios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombreEjercicios;
        private System.Windows.Forms.Label lblIdEjercicio;
        private System.Windows.Forms.TextBox txtNombreEjercicio;
        private System.Windows.Forms.TextBox txtIdEjercicio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbGrupoMuscular;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblGrupoMuscular;
        private System.Windows.Forms.Button btnAgregarGrupoMuscular;
    }
}