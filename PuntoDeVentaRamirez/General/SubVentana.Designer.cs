namespace PuntoDeVentaRamirez
{
    partial class SubVentana
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
            this.pnlVentanita = new System.Windows.Forms.Panel();
            this.bnfbtnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfBtnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bnfElipVentana = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnfbtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfBtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVentanita
            // 
            this.pnlVentanita.BackColor = System.Drawing.Color.White;
            this.pnlVentanita.Location = new System.Drawing.Point(10, 22);
            this.pnlVentanita.Name = "pnlVentanita";
            this.pnlVentanita.Size = new System.Drawing.Size(580, 280);
            this.pnlVentanita.TabIndex = 0;
            // 
            // bnfbtnMinimizar
            // 
            this.bnfbtnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.bnfbtnMinimizar.Image = global::PuntoDeVentaRamirez.Properties.Resources.minimizar;
            this.bnfbtnMinimizar.ImageActive = null;
            this.bnfbtnMinimizar.Location = new System.Drawing.Point(547, 1);
            this.bnfbtnMinimizar.Name = "bnfbtnMinimizar";
            this.bnfbtnMinimizar.Size = new System.Drawing.Size(19, 19);
            this.bnfbtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfbtnMinimizar.TabIndex = 4;
            this.bnfbtnMinimizar.TabStop = false;
            this.bnfbtnMinimizar.Zoom = 10;
            this.bnfbtnMinimizar.Click += new System.EventHandler(this.bnfbtnMinimizar_Click);
            // 
            // bnfBtnCerrar
            // 
            this.bnfBtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.bnfBtnCerrar.Image = global::PuntoDeVentaRamirez.Properties.Resources.cerrar;
            this.bnfBtnCerrar.ImageActive = null;
            this.bnfBtnCerrar.Location = new System.Drawing.Point(565, 1);
            this.bnfBtnCerrar.Name = "bnfBtnCerrar";
            this.bnfBtnCerrar.Size = new System.Drawing.Size(25, 19);
            this.bnfBtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfBtnCerrar.TabIndex = 3;
            this.bnfBtnCerrar.TabStop = false;
            this.bnfBtnCerrar.Zoom = 10;
            this.bnfBtnCerrar.Click += new System.EventHandler(this.bnfBtnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(15, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 19);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // bnfElipVentana
            // 
            this.bnfElipVentana.ElipseRadius = 5;
            this.bnfElipVentana.TargetControl = this;
            // 
            // SubVentana
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(169)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(600, 315);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.bnfbtnMinimizar);
            this.Controls.Add(this.bnfBtnCerrar);
            this.Controls.Add(this.pnlVentanita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubVentana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubVentana";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SubVentana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnfbtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfBtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVentanita;
        private Bunifu.Framework.UI.BunifuImageButton bnfbtnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton bnfBtnCerrar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitulo;
        private Bunifu.Framework.UI.BunifuElipse bnfElipVentana;
    }
}