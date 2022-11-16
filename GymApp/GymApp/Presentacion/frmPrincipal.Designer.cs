namespace GymApp.Presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoMuscularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoPlanesPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejerciciosMasUtilzadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoMuscularMásAfectadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteToolStripMenuItem,
            this.planesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.alumnoToolStripMenuItem,
            this.grupoMuscularToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barrioToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // barrioToolStripMenuItem
            // 
            this.barrioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localidadToolStripMenuItem});
            this.barrioToolStripMenuItem.Name = "barrioToolStripMenuItem";
            this.barrioToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.barrioToolStripMenuItem.Text = "Barrio";
            this.barrioToolStripMenuItem.Click += new System.EventHandler(this.barrioToolStripMenuItem_Click);
            // 
            // localidadToolStripMenuItem
            // 
            this.localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            this.localidadToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.localidadToolStripMenuItem.Text = "Localidad";
            this.localidadToolStripMenuItem.Click += new System.EventHandler(this.localidadToolStripMenuItem_Click);
            // 
            // grupoMuscularToolStripMenuItem
            // 
            this.grupoMuscularToolStripMenuItem.Name = "grupoMuscularToolStripMenuItem";
            this.grupoMuscularToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.grupoMuscularToolStripMenuItem.Text = "Grupo Muscular";
            this.grupoMuscularToolStripMenuItem.Click += new System.EventHandler(this.grupoMuscularToolStripMenuItem_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planesToolStripMenuItem1,
            this.ejerciciosToolStripMenuItem});
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.planesToolStripMenuItem.Text = "Planes";
            // 
            // planesToolStripMenuItem1
            // 
            this.planesToolStripMenuItem1.Name = "planesToolStripMenuItem1";
            this.planesToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.planesToolStripMenuItem1.Text = "Planes";
            this.planesToolStripMenuItem1.Click += new System.EventHandler(this.planesToolStripMenuItem1_Click);
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            this.ejerciciosToolStripMenuItem.Click += new System.EventHandler(this.ejerciciosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoPlanesPorMesToolStripMenuItem,
            this.ejerciciosMasUtilzadosToolStripMenuItem,
            this.grupoMuscularMásAfectadoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listadoPlanesPorMesToolStripMenuItem
            // 
            this.listadoPlanesPorMesToolStripMenuItem.Name = "listadoPlanesPorMesToolStripMenuItem";
            this.listadoPlanesPorMesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.listadoPlanesPorMesToolStripMenuItem.Text = "Listado de planes";
            this.listadoPlanesPorMesToolStripMenuItem.Click += new System.EventHandler(this.listadoPlanesPorMesToolStripMenuItem_Click);
            // 
            // ejerciciosMasUtilzadosToolStripMenuItem
            // 
            this.ejerciciosMasUtilzadosToolStripMenuItem.Name = "ejerciciosMasUtilzadosToolStripMenuItem";
            this.ejerciciosMasUtilzadosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ejerciciosMasUtilzadosToolStripMenuItem.Text = "Ejercicios mas utilzados";
            this.ejerciciosMasUtilzadosToolStripMenuItem.Click += new System.EventHandler(this.ejerciciosMasUtilzadosToolStripMenuItem_Click);
            // 
            // grupoMuscularMásAfectadoToolStripMenuItem
            // 
            this.grupoMuscularMásAfectadoToolStripMenuItem.Name = "grupoMuscularMásAfectadoToolStripMenuItem";
            this.grupoMuscularMásAfectadoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.grupoMuscularMásAfectadoToolStripMenuItem.Text = "Grupo Muscular más afectado";
            this.grupoMuscularMásAfectadoToolStripMenuItem.Click += new System.EventHandler(this.grupoMuscularMásAfectadoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GymApp.Properties.Resources.LogoGim;
            this.pictureBox1.Location = new System.Drawing.Point(233, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 287);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoMuscularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoPlanesPorMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosMasUtilzadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoMuscularMásAfectadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}