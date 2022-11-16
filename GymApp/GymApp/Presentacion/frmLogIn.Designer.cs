namespace GymApp.Presentacion
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picFondoLogIn = new System.Windows.Forms.PictureBox();
            this.picLogoGym = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoGym)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(53, 375);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(241, 36);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Entrar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(53, 276);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '·';
            this.txtClave.Size = new System.Drawing.Size(241, 32);
            this.txtClave.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(53, 202);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(241, 32);
            this.txtUsuario.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(53, 417);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(241, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(50, 260);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(50, 186);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario:";
            // 
            // picFondoLogIn
            // 
            this.picFondoLogIn.Image = global::GymApp.Properties.Resources.gym_durango;
            this.picFondoLogIn.Location = new System.Drawing.Point(1, 1);
            this.picFondoLogIn.Name = "picFondoLogIn";
            this.picFondoLogIn.Size = new System.Drawing.Size(341, 144);
            this.picFondoLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondoLogIn.TabIndex = 6;
            this.picFondoLogIn.TabStop = false;
            // 
            // picLogoGym
            // 
            this.picLogoGym.Image = global::GymApp.Properties.Resources.LogoGim;
            this.picLogoGym.Location = new System.Drawing.Point(114, 75);
            this.picLogoGym.Name = "picLogoGym";
            this.picLogoGym.Size = new System.Drawing.Size(110, 96);
            this.picLogoGym.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoGym.TabIndex = 7;
            this.picLogoGym.TabStop = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 484);
            this.Controls.Add(this.picLogoGym);
            this.Controls.Add(this.picFondoLogIn);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.picFondoLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoGym)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picFondoLogIn;
        private System.Windows.Forms.PictureBox picLogoGym;
    }
}