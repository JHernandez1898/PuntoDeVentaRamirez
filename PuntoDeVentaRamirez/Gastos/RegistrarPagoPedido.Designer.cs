namespace PuntoDeVentaRamirez
{
    partial class RegistrarPagoPedido
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
            this.bnftxtNumeroCheque = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfbtnRegistrarPago = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfdtmDeposito = new Bunifu.Framework.UI.BunifuDatepicker();
            this.SuspendLayout();
            // 
            // bnftxtNumeroCheque
            // 
            this.bnftxtNumeroCheque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtNumeroCheque.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtNumeroCheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtNumeroCheque.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtNumeroCheque.HintText = "";
            this.bnftxtNumeroCheque.isPassword = false;
            this.bnftxtNumeroCheque.LineFocusedColor = System.Drawing.Color.Blue;
            this.bnftxtNumeroCheque.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtNumeroCheque.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bnftxtNumeroCheque.LineThickness = 3;
            this.bnftxtNumeroCheque.Location = new System.Drawing.Point(34, 28);
            this.bnftxtNumeroCheque.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtNumeroCheque.Name = "bnftxtNumeroCheque";
            this.bnftxtNumeroCheque.Size = new System.Drawing.Size(508, 33);
            this.bnftxtNumeroCheque.TabIndex = 0;
            this.bnftxtNumeroCheque.Text = "Número de cheque";
            this.bnftxtNumeroCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnfbtnRegistrarPago
            // 
            this.bnfbtnRegistrarPago.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(80)))));
            this.bnfbtnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfbtnRegistrarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfbtnRegistrarPago.BorderRadius = 0;
            this.bnfbtnRegistrarPago.ButtonText = "Registrar Pago";
            this.bnfbtnRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfbtnRegistrarPago.DisabledColor = System.Drawing.Color.Gray;
            this.bnfbtnRegistrarPago.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfbtnRegistrarPago.Iconimage = null;
            this.bnfbtnRegistrarPago.Iconimage_right = null;
            this.bnfbtnRegistrarPago.Iconimage_right_Selected = null;
            this.bnfbtnRegistrarPago.Iconimage_Selected = null;
            this.bnfbtnRegistrarPago.IconMarginLeft = 0;
            this.bnfbtnRegistrarPago.IconMarginRight = 0;
            this.bnfbtnRegistrarPago.IconRightVisible = true;
            this.bnfbtnRegistrarPago.IconRightZoom = 0D;
            this.bnfbtnRegistrarPago.IconVisible = true;
            this.bnfbtnRegistrarPago.IconZoom = 90D;
            this.bnfbtnRegistrarPago.IsTab = false;
            this.bnfbtnRegistrarPago.Location = new System.Drawing.Point(174, 199);
            this.bnfbtnRegistrarPago.Name = "bnfbtnRegistrarPago";
            this.bnfbtnRegistrarPago.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfbtnRegistrarPago.OnHovercolor = System.Drawing.Color.Gray;
            this.bnfbtnRegistrarPago.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfbtnRegistrarPago.selected = false;
            this.bnfbtnRegistrarPago.Size = new System.Drawing.Size(241, 48);
            this.bnfbtnRegistrarPago.TabIndex = 2;
            this.bnfbtnRegistrarPago.Text = "Registrar Pago";
            this.bnfbtnRegistrarPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfbtnRegistrarPago.Textcolor = System.Drawing.Color.White;
            this.bnfbtnRegistrarPago.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfbtnRegistrarPago.Click += new System.EventHandler(this.bnfbtnRegistrarPago_Click);
            // 
            // bnfdtmDeposito
            // 
            this.bnfdtmDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfdtmDeposito.BorderRadius = 0;
            this.bnfdtmDeposito.ForeColor = System.Drawing.Color.White;
            this.bnfdtmDeposito.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bnfdtmDeposito.FormatCustom = null;
            this.bnfdtmDeposito.Location = new System.Drawing.Point(34, 97);
            this.bnfdtmDeposito.Name = "bnfdtmDeposito";
            this.bnfdtmDeposito.Size = new System.Drawing.Size(508, 36);
            this.bnfdtmDeposito.TabIndex = 3;
            this.bnfdtmDeposito.Value = new System.DateTime(2018, 12, 1, 11, 57, 7, 723);
            // 
            // RegistrarPagoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bnfdtmDeposito);
            this.Controls.Add(this.bnfbtnRegistrarPago);
            this.Controls.Add(this.bnftxtNumeroCheque);
            this.Name = "RegistrarPagoPedido";
            this.Size = new System.Drawing.Size(580, 280);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtNumeroCheque;
        private Bunifu.Framework.UI.BunifuFlatButton bnfbtnRegistrarPago;
        private Bunifu.Framework.UI.BunifuDatepicker bnfdtmDeposito;
    }
}
