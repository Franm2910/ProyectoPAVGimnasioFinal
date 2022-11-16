namespace GymApp.Presentacion
{
    partial class frmGrupoMuscularAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupoMuscularAM));
            this.grbAltaGrupoMuscular = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNombreEjercicios = new System.Windows.Forms.Label();
            this.lblIdEjercicio = new System.Windows.Forms.Label();
            this.txtNombreGrupoMuscular = new System.Windows.Forms.TextBox();
            this.txtIdGrupoMuscular = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grbAltaGrupoMuscular.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAltaGrupoMuscular
            // 
            this.grbAltaGrupoMuscular.Controls.Add(this.btnCancelar);
            this.grbAltaGrupoMuscular.Controls.Add(this.btnAceptar);
            this.grbAltaGrupoMuscular.Controls.Add(this.lblNombreEjercicios);
            this.grbAltaGrupoMuscular.Controls.Add(this.lblIdEjercicio);
            this.grbAltaGrupoMuscular.Controls.Add(this.txtNombreGrupoMuscular);
            this.grbAltaGrupoMuscular.Controls.Add(this.txtIdGrupoMuscular);
            this.grbAltaGrupoMuscular.Controls.Add(this.txtDescripcion);
            this.grbAltaGrupoMuscular.Controls.Add(this.lblDescripcion);
            this.grbAltaGrupoMuscular.Location = new System.Drawing.Point(11, 11);
            this.grbAltaGrupoMuscular.Margin = new System.Windows.Forms.Padding(2);
            this.grbAltaGrupoMuscular.Name = "grbAltaGrupoMuscular";
            this.grbAltaGrupoMuscular.Padding = new System.Windows.Forms.Padding(2);
            this.grbAltaGrupoMuscular.Size = new System.Drawing.Size(370, 247);
            this.grbAltaGrupoMuscular.TabIndex = 13;
            this.grbAltaGrupoMuscular.TabStop = false;
            this.grbAltaGrupoMuscular.Text = "Grupo Muscular";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(254, 202);
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
            this.btnAceptar.Location = new System.Drawing.Point(129, 202);
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
            // txtNombreGrupoMuscular
            // 
            this.txtNombreGrupoMuscular.Location = new System.Drawing.Point(129, 73);
            this.txtNombreGrupoMuscular.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreGrupoMuscular.Name = "txtNombreGrupoMuscular";
            this.txtNombreGrupoMuscular.Size = new System.Drawing.Size(211, 20);
            this.txtNombreGrupoMuscular.TabIndex = 1;
            // 
            // txtIdGrupoMuscular
            // 
            this.txtIdGrupoMuscular.Location = new System.Drawing.Point(129, 37);
            this.txtIdGrupoMuscular.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdGrupoMuscular.Name = "txtIdGrupoMuscular";
            this.txtIdGrupoMuscular.Size = new System.Drawing.Size(211, 20);
            this.txtIdGrupoMuscular.TabIndex = 0;
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
            // frmGrupoMuscularAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 270);
            this.Controls.Add(this.grbAltaGrupoMuscular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrupoMuscularAM";
            this.Text = "frmGrupoMuscularAM";
            this.Load += new System.EventHandler(this.frmGrupoMuscularAM_Load);
            this.grbAltaGrupoMuscular.ResumeLayout(false);
            this.grbAltaGrupoMuscular.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAltaGrupoMuscular;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombreEjercicios;
        private System.Windows.Forms.Label lblIdEjercicio;
        private System.Windows.Forms.TextBox txtNombreGrupoMuscular;
        private System.Windows.Forms.TextBox txtIdGrupoMuscular;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}