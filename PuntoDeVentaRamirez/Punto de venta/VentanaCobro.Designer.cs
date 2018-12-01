namespace PuntoDeVentaRamirez
{
    partial class VentanaCobro
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
            this.bnfTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfTipoDeCambio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfPagoDolares = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfPagoEnPesos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radDolares = new System.Windows.Forms.RadioButton();
            this.radPesos = new System.Windows.Forms.RadioButton();
            this.lblPago = new System.Windows.Forms.Label();
            this.bnfFltbtnCobrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblCambio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnfTotal
            // 
            this.bnfTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnfTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnfTotal.HintForeColor = System.Drawing.Color.Empty;
            this.bnfTotal.HintText = "";
            this.bnfTotal.isPassword = false;
            this.bnfTotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.bnfTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.bnfTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bnfTotal.LineThickness = 3;
            this.bnfTotal.Location = new System.Drawing.Point(119, 21);
            this.bnfTotal.Margin = new System.Windows.Forms.Padding(4);
            this.bnfTotal.Name = "bnfTotal";
            this.bnfTotal.Size = new System.Drawing.Size(425, 33);
            this.bnfTotal.TabIndex = 0;
            this.bnfTotal.Text = "Pago total";
            this.bnfTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnfTipoDeCambio
            // 
            this.bnfTipoDeCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfTipoDeCambio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnfTipoDeCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnfTipoDeCambio.HintForeColor = System.Drawing.Color.Empty;
            this.bnfTipoDeCambio.HintText = "";
            this.bnfTipoDeCambio.isPassword = false;
            this.bnfTipoDeCambio.LineFocusedColor = System.Drawing.Color.Blue;
            this.bnfTipoDeCambio.LineIdleColor = System.Drawing.Color.Gray;
            this.bnfTipoDeCambio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bnfTipoDeCambio.LineThickness = 3;
            this.bnfTipoDeCambio.Location = new System.Drawing.Point(254, 49);
            this.bnfTipoDeCambio.Margin = new System.Windows.Forms.Padding(4);
            this.bnfTipoDeCambio.Name = "bnfTipoDeCambio";
            this.bnfTipoDeCambio.Size = new System.Drawing.Size(227, 33);
            this.bnfTipoDeCambio.TabIndex = 3;
            this.bnfTipoDeCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnfTipoDeCambio.OnValueChanged += new System.EventHandler(this.bnfTipoDeCambio_OnValueChanged);
            this.bnfTipoDeCambio.MouseEnter += new System.EventHandler(this.bnfTipoDeCambio_MouseEnter);
            // 
            // bnfPagoDolares
            // 
            this.bnfPagoDolares.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfPagoDolares.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnfPagoDolares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnfPagoDolares.HintForeColor = System.Drawing.Color.Empty;
            this.bnfPagoDolares.HintText = "";
            this.bnfPagoDolares.isPassword = false;
            this.bnfPagoDolares.LineFocusedColor = System.Drawing.Color.Blue;
            this.bnfPagoDolares.LineIdleColor = System.Drawing.Color.Gray;
            this.bnfPagoDolares.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bnfPagoDolares.LineThickness = 3;
            this.bnfPagoDolares.Location = new System.Drawing.Point(254, 90);
            this.bnfPagoDolares.Margin = new System.Windows.Forms.Padding(4);
            this.bnfPagoDolares.Name = "bnfPagoDolares";
            this.bnfPagoDolares.Size = new System.Drawing.Size(227, 33);
            this.bnfPagoDolares.TabIndex = 4;
            this.bnfPagoDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnfPagoDolares.OnValueChanged += new System.EventHandler(this.bnfPagoDolares_OnValueChanged);
            this.bnfPagoDolares.MouseEnter += new System.EventHandler(this.bnfPagoDolares_MouseEnter);
            // 
            // bnfPagoEnPesos
            // 
            this.bnfPagoEnPesos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfPagoEnPesos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnfPagoEnPesos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnfPagoEnPesos.HintForeColor = System.Drawing.Color.Empty;
            this.bnfPagoEnPesos.HintText = "";
            this.bnfPagoEnPesos.isPassword = false;
            this.bnfPagoEnPesos.LineFocusedColor = System.Drawing.Color.Blue;
            this.bnfPagoEnPesos.LineIdleColor = System.Drawing.Color.Gray;
            this.bnfPagoEnPesos.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bnfPagoEnPesos.LineThickness = 3;
            this.bnfPagoEnPesos.Location = new System.Drawing.Point(254, 8);
            this.bnfPagoEnPesos.Margin = new System.Windows.Forms.Padding(4);
            this.bnfPagoEnPesos.Name = "bnfPagoEnPesos";
            this.bnfPagoEnPesos.Size = new System.Drawing.Size(227, 33);
            this.bnfPagoEnPesos.TabIndex = 5;
            this.bnfPagoEnPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnfPagoEnPesos.OnValueChanged += new System.EventHandler(this.bnfPagoEnPesos_OnValueChanged);
            this.bnfPagoEnPesos.MouseEnter += new System.EventHandler(this.bnfPagoEnPesos_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radDolares);
            this.groupBox1.Controls.Add(this.radPesos);
            this.groupBox1.Controls.Add(this.bnfTipoDeCambio);
            this.groupBox1.Controls.Add(this.bnfPagoDolares);
            this.groupBox1.Controls.Add(this.bnfPagoEnPesos);
            this.groupBox1.Location = new System.Drawing.Point(37, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago en";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pago en pesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pago en dolares:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de cambio:";
            // 
            // radDolares
            // 
            this.radDolares.AutoSize = true;
            this.radDolares.Location = new System.Drawing.Point(15, 42);
            this.radDolares.Name = "radDolares";
            this.radDolares.Size = new System.Drawing.Size(61, 17);
            this.radDolares.TabIndex = 1;
            this.radDolares.TabStop = true;
            this.radDolares.Text = "Dolares";
            this.radDolares.UseVisualStyleBackColor = true;
            // 
            // radPesos
            // 
            this.radPesos.AutoSize = true;
            this.radPesos.Location = new System.Drawing.Point(15, 19);
            this.radPesos.Name = "radPesos";
            this.radPesos.Size = new System.Drawing.Size(54, 17);
            this.radPesos.TabIndex = 0;
            this.radPesos.TabStop = true;
            this.radPesos.Text = "Pesos";
            this.radPesos.UseVisualStyleBackColor = true;
            this.radPesos.CheckedChanged += new System.EventHandler(this.radPesos_CheckedChanged);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(34, 37);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(82, 17);
            this.lblPago.TabIndex = 7;
            this.lblPago.Text = "Pago total:";
            // 
            // bnfFltbtnCobrar
            // 
            this.bnfFltbtnCobrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.bnfFltbtnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFltbtnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfFltbtnCobrar.BorderRadius = 0;
            this.bnfFltbtnCobrar.ButtonText = "Cobrar";
            this.bnfFltbtnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfFltbtnCobrar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfFltbtnCobrar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfFltbtnCobrar.Iconimage = null;
            this.bnfFltbtnCobrar.Iconimage_right = null;
            this.bnfFltbtnCobrar.Iconimage_right_Selected = null;
            this.bnfFltbtnCobrar.Iconimage_Selected = null;
            this.bnfFltbtnCobrar.IconMarginLeft = 0;
            this.bnfFltbtnCobrar.IconMarginRight = 0;
            this.bnfFltbtnCobrar.IconRightVisible = true;
            this.bnfFltbtnCobrar.IconRightZoom = 0D;
            this.bnfFltbtnCobrar.IconVisible = true;
            this.bnfFltbtnCobrar.IconZoom = 90D;
            this.bnfFltbtnCobrar.IsTab = false;
            this.bnfFltbtnCobrar.Location = new System.Drawing.Point(424, 237);
            this.bnfFltbtnCobrar.Name = "bnfFltbtnCobrar";
            this.bnfFltbtnCobrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFltbtnCobrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(90)))));
            this.bnfFltbtnCobrar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfFltbtnCobrar.selected = false;
            this.bnfFltbtnCobrar.Size = new System.Drawing.Size(120, 40);
            this.bnfFltbtnCobrar.TabIndex = 9;
            this.bnfFltbtnCobrar.Text = "Cobrar";
            this.bnfFltbtnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfFltbtnCobrar.Textcolor = System.Drawing.Color.White;
            this.bnfFltbtnCobrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfFltbtnCobrar.Click += new System.EventHandler(this.bnfFltbtnCobrar_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(288, 206);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(137, 17);
            this.lblCambio.TabIndex = 10;
            this.lblCambio.Text = "Cambio del cliente:";
            // 
            // VentanaCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.bnfFltbtnCobrar);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnfTotal);
            this.Name = "VentanaCobro";
            this.Size = new System.Drawing.Size(580, 280);
            this.Load += new System.EventHandler(this.VentanaCobro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfTotal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfTipoDeCambio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfPagoDolares;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfPagoEnPesos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDolares;
        private System.Windows.Forms.RadioButton radPesos;
        private System.Windows.Forms.Label lblPago;
        private Bunifu.Framework.UI.BunifuFlatButton bnfFltbtnCobrar;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
