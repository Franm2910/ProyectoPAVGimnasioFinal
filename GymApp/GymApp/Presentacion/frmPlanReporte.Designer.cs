namespace GymApp.Presentacion
{
    partial class frmPlanReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanReporte));
            this.rpvPlan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvPlan
            // 
            this.rpvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvPlan.LocalReport.ReportEmbeddedResource = "GymApp.Reportes.rptPlanDetallado.rdlc";
            this.rpvPlan.Location = new System.Drawing.Point(0, 0);
            this.rpvPlan.Name = "rpvPlan";
            this.rpvPlan.ServerReport.BearerToken = null;
            this.rpvPlan.Size = new System.Drawing.Size(1004, 654);
            this.rpvPlan.TabIndex = 0;
            this.rpvPlan.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // frmPlanReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 654);
            this.Controls.Add(this.rpvPlan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlanReporte";
            this.Text = "Plan";
            this.Load += new System.EventHandler(this.frmPlanReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPlan;
    }
}