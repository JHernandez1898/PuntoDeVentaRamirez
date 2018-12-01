namespace PuntoDeVentaRamirez
{
    partial class PantallaReportes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaReportes));
            this.bnfFechaInferior = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bnfFechaSuperior = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bnfbtnGenerarVentas = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelReporte = new System.Windows.Forms.Panel();
            this.crvVisorReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblFechaInicial = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFechaFinal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnfFechaInferior
            // 
            this.bnfFechaInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFechaInferior.BorderRadius = 0;
            this.bnfFechaInferior.ForeColor = System.Drawing.Color.White;
            this.bnfFechaInferior.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bnfFechaInferior.FormatCustom = null;
            this.bnfFechaInferior.Location = new System.Drawing.Point(37, 74);
            this.bnfFechaInferior.Name = "bnfFechaInferior";
            this.bnfFechaInferior.Size = new System.Drawing.Size(341, 36);
            this.bnfFechaInferior.TabIndex = 5;
            this.bnfFechaInferior.Value = new System.DateTime(2018, 11, 12, 22, 7, 37, 565);
            // 
            // bnfFechaSuperior
            // 
            this.bnfFechaSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFechaSuperior.BorderRadius = 0;
            this.bnfFechaSuperior.ForeColor = System.Drawing.Color.White;
            this.bnfFechaSuperior.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bnfFechaSuperior.FormatCustom = null;
            this.bnfFechaSuperior.Location = new System.Drawing.Point(37, 162);
            this.bnfFechaSuperior.Name = "bnfFechaSuperior";
            this.bnfFechaSuperior.Size = new System.Drawing.Size(341, 36);
            this.bnfFechaSuperior.TabIndex = 6;
            this.bnfFechaSuperior.Value = new System.DateTime(2018, 11, 12, 22, 7, 37, 565);
            // 
            // bnfbtnGenerarVentas
            // 
            this.bnfbtnGenerarVentas.ActiveBorderThickness = 1;
            this.bnfbtnGenerarVentas.ActiveCornerRadius = 20;
            this.bnfbtnGenerarVentas.ActiveFillColor = System.Drawing.Color.DarkGray;
            this.bnfbtnGenerarVentas.ActiveForecolor = System.Drawing.Color.White;
            this.bnfbtnGenerarVentas.ActiveLineColor = System.Drawing.Color.DarkGray;
            this.bnfbtnGenerarVentas.BackColor = System.Drawing.Color.Transparent;
            this.bnfbtnGenerarVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfbtnGenerarVentas.BackgroundImage")));
            this.bnfbtnGenerarVentas.ButtonText = "Generar reporte de ventas";
            this.bnfbtnGenerarVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfbtnGenerarVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfbtnGenerarVentas.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGenerarVentas.IdleBorderThickness = 1;
            this.bnfbtnGenerarVentas.IdleCornerRadius = 20;
            this.bnfbtnGenerarVentas.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfbtnGenerarVentas.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bnfbtnGenerarVentas.IdleLineColor = System.Drawing.Color.Transparent;
            this.bnfbtnGenerarVentas.Location = new System.Drawing.Point(37, 220);
            this.bnfbtnGenerarVentas.Margin = new System.Windows.Forms.Padding(5);
            this.bnfbtnGenerarVentas.Name = "bnfbtnGenerarVentas";
            this.bnfbtnGenerarVentas.Size = new System.Drawing.Size(341, 65);
            this.bnfbtnGenerarVentas.TabIndex = 9;
            this.bnfbtnGenerarVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfbtnGenerarVentas.Click += new System.EventHandler(this.bnfbtnGenerarVentas_Click);
            // 
            // panelReporte
            // 
            this.panelReporte.Controls.Add(this.crvVisorReportes);
            this.panelReporte.Location = new System.Drawing.Point(421, 45);
            this.panelReporte.Name = "panelReporte";
            this.panelReporte.Size = new System.Drawing.Size(900, 641);
            this.panelReporte.TabIndex = 5;
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
            this.crvVisorReportes.Size = new System.Drawing.Size(900, 641);
            this.crvVisorReportes.TabIndex = 1;
            this.crvVisorReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvVisorReportes.ToolPanelWidth = 150;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFechaInicial.Location = new System.Drawing.Point(33, 45);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(109, 19);
            this.lblFechaInicial.TabIndex = 16;
            this.lblFechaInicial.Text = "Fecha inicial";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFechaFinal.Location = new System.Drawing.Point(33, 127);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(97, 19);
            this.lblFechaFinal.TabIndex = 17;
            this.lblFechaFinal.Text = "Fecha final";
            // 
            // PantallaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.bnfbtnGenerarVentas);
            this.Controls.Add(this.panelReporte);
            this.Controls.Add(this.bnfFechaSuperior);
            this.Controls.Add(this.bnfFechaInferior);
            this.Name = "PantallaReportes";
            this.Size = new System.Drawing.Size(1350, 689);
            this.Load += new System.EventHandler(this.PantallaReportes_Load);
            this.panelReporte.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDatepicker bnfFechaInferior;
        private Bunifu.Framework.UI.BunifuDatepicker bnfFechaSuperior;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfbtnGenerarVentas;
        private System.Windows.Forms.Panel panelReporte;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisorReportes;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFechaInicial;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFechaFinal;
    }
}
