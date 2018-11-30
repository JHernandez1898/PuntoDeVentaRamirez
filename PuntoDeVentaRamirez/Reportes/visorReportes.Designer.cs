namespace PuntoDeVentaRamirez.Reportes
{
    partial class visorReportes
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
            this.crvVisorReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVisorReportes
            // 
            this.crvVisorReportes.ActiveViewIndex = -1;
            this.crvVisorReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisorReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisorReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisorReportes.Location = new System.Drawing.Point(0, 0);
            this.crvVisorReportes.Name = "crvVisorReportes";
            this.crvVisorReportes.ShowCloseButton = false;
            this.crvVisorReportes.ShowCopyButton = false;
            this.crvVisorReportes.ShowGroupTreeButton = false;
            this.crvVisorReportes.ShowLogo = false;
            this.crvVisorReportes.ShowParameterPanelButton = false;
            this.crvVisorReportes.Size = new System.Drawing.Size(624, 441);
            this.crvVisorReportes.TabIndex = 0;
            this.crvVisorReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvVisorReportes.ToolPanelWidth = 150;
            // 
            // visorReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.crvVisorReportes);
            this.Name = "visorReportes";
            this.ShowIcon = false;
            this.Text = "Visor de reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisorReportes;
    }
}