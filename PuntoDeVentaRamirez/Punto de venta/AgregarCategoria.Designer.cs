namespace PuntoDeVentaRamirez
{
    partial class AgregarCategoria
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
            this.bnftxtCategoria = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfFLbtnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bnftxtCategoria
            // 
            this.bnftxtCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtCategoria.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtCategoria.HintText = "";
            this.bnftxtCategoria.isPassword = false;
            this.bnftxtCategoria.LineFocusedColor = System.Drawing.Color.Blue;
            this.bnftxtCategoria.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtCategoria.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bnftxtCategoria.LineThickness = 3;
            this.bnftxtCategoria.Location = new System.Drawing.Point(32, 88);
            this.bnftxtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtCategoria.Name = "bnftxtCategoria";
            this.bnftxtCategoria.Size = new System.Drawing.Size(516, 33);
            this.bnftxtCategoria.TabIndex = 8;
            this.bnftxtCategoria.Text = "Categoría";
            this.bnftxtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnfFLbtnAgregar
            // 
            this.bnfFLbtnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFLbtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFLbtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfFLbtnAgregar.BorderRadius = 0;
            this.bnfFLbtnAgregar.ButtonText = "Agregar";
            this.bnfFLbtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfFLbtnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfFLbtnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfFLbtnAgregar.Iconimage = null;
            this.bnfFLbtnAgregar.Iconimage_right = null;
            this.bnfFLbtnAgregar.Iconimage_right_Selected = null;
            this.bnfFLbtnAgregar.Iconimage_Selected = null;
            this.bnfFLbtnAgregar.IconMarginLeft = 0;
            this.bnfFLbtnAgregar.IconMarginRight = 0;
            this.bnfFLbtnAgregar.IconRightVisible = true;
            this.bnfFLbtnAgregar.IconRightZoom = 0D;
            this.bnfFLbtnAgregar.IconVisible = true;
            this.bnfFLbtnAgregar.IconZoom = 90D;
            this.bnfFLbtnAgregar.IsTab = false;
            this.bnfFLbtnAgregar.Location = new System.Drawing.Point(232, 207);
            this.bnfFLbtnAgregar.Name = "bnfFLbtnAgregar";
            this.bnfFLbtnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFLbtnAgregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(90)))));
            this.bnfFLbtnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfFLbtnAgregar.selected = false;
            this.bnfFLbtnAgregar.Size = new System.Drawing.Size(106, 35);
            this.bnfFLbtnAgregar.TabIndex = 7;
            this.bnfFLbtnAgregar.Text = "Agregar";
            this.bnfFLbtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfFLbtnAgregar.Textcolor = System.Drawing.Color.White;
            this.bnfFLbtnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfFLbtnAgregar.Click += new System.EventHandler(this.bnfFLbtnAgregar_Click);
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bnftxtCategoria);
            this.Controls.Add(this.bnfFLbtnAgregar);
            this.Name = "AgregarCategoria";
            this.Size = new System.Drawing.Size(580, 280);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtCategoria;
        private Bunifu.Framework.UI.BunifuFlatButton bnfFLbtnAgregar;
    }
}
