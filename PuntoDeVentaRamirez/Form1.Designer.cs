namespace PuntoDeVentaRamirez
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bnfGrPanelPrincipal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bnfbtnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfBtnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            bnfGrPanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnfbtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfBtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bnfGrPanelPrincipal
            // 
            bnfGrPanelPrincipal.BackColor = System.Drawing.SystemColors.Control;
            bnfGrPanelPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfGrPanelPrincipal.BackgroundImage")));
            bnfGrPanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bnfGrPanelPrincipal.Controls.Add(this.bnfbtnMinimizar);
            bnfGrPanelPrincipal.Controls.Add(this.bnfBtnCerrar);
            bnfGrPanelPrincipal.GradientBottomLeft = System.Drawing.Color.MediumPurple;
            bnfGrPanelPrincipal.GradientBottomRight = System.Drawing.Color.MediumPurple;
            bnfGrPanelPrincipal.GradientTopLeft = System.Drawing.Color.MediumPurple;
            bnfGrPanelPrincipal.GradientTopRight = System.Drawing.Color.White;
            bnfGrPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            bnfGrPanelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            bnfGrPanelPrincipal.Name = "bnfGrPanelPrincipal";
            bnfGrPanelPrincipal.Quality = 10;
            bnfGrPanelPrincipal.Size = new System.Drawing.Size(1366, 768);
            bnfGrPanelPrincipal.TabIndex = 0;
            bnfGrPanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.bnfGrPanelPrincipal_Paint);
            // 
            // bnfbtnMinimizar
            // 
            this.bnfbtnMinimizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bnfbtnMinimizar.Image = global::PuntoDeVentaRamirez.Properties.Resources.minimizar;
            this.bnfbtnMinimizar.ImageActive = null;
            this.bnfbtnMinimizar.Location = new System.Drawing.Point(1304, 13);
            this.bnfbtnMinimizar.Name = "bnfbtnMinimizar";
            this.bnfbtnMinimizar.Size = new System.Drawing.Size(16, 15);
            this.bnfbtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfbtnMinimizar.TabIndex = 4;
            this.bnfbtnMinimizar.TabStop = false;
            this.bnfbtnMinimizar.Zoom = 10;
            this.bnfbtnMinimizar.Click += new System.EventHandler(this.bnfbtnMinimizar_Click);
            // 
            // bnfBtnCerrar
            // 
            this.bnfBtnCerrar.BackColor = System.Drawing.Color.Red;
            this.bnfBtnCerrar.Image = global::PuntoDeVentaRamirez.Properties.Resources.cerrar;
            this.bnfBtnCerrar.ImageActive = null;
            this.bnfBtnCerrar.Location = new System.Drawing.Point(1326, 13);
            this.bnfBtnCerrar.Name = "bnfBtnCerrar";
            this.bnfBtnCerrar.Size = new System.Drawing.Size(16, 15);
            this.bnfBtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfBtnCerrar.TabIndex = 3;
            this.bnfBtnCerrar.TabStop = false;
            this.bnfBtnCerrar.Zoom = 10;
            this.bnfBtnCerrar.Click += new System.EventHandler(this.bnfBtnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(169)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1350, 768);
            this.Controls.Add(bnfGrPanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            bnfGrPanelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnfbtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfBtnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bnfbtnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton bnfBtnCerrar;
        private static Bunifu.Framework.UI.BunifuGradientPanel bnfGrPanelPrincipal;
    }
}

