namespace PuntoDeVentaRamirez
{
    partial class PanelAgregarPaquete
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bnfCstgridPaquetes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnfMtltxtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAgregarPaquete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnfCstgridPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // bnfCstgridPaquetes
            // 
            this.bnfCstgridPaquetes.AllowUserToAddRows = false;
            this.bnfCstgridPaquetes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnfCstgridPaquetes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bnfCstgridPaquetes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bnfCstgridPaquetes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bnfCstgridPaquetes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bnfCstgridPaquetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bnfCstgridPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bnfCstgridPaquetes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion});
            this.bnfCstgridPaquetes.DoubleBuffered = true;
            this.bnfCstgridPaquetes.EnableHeadersVisualStyles = false;
            this.bnfCstgridPaquetes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfCstgridPaquetes.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bnfCstgridPaquetes.Location = new System.Drawing.Point(36, 51);
            this.bnfCstgridPaquetes.Name = "bnfCstgridPaquetes";
            this.bnfCstgridPaquetes.ReadOnly = true;
            this.bnfCstgridPaquetes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bnfCstgridPaquetes.RowHeadersVisible = false;
            this.bnfCstgridPaquetes.Size = new System.Drawing.Size(500, 194);
            this.bnfCstgridPaquetes.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 349;
            // 
            // bnfMtltxtDescripcion
            // 
            this.bnfMtltxtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfMtltxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnfMtltxtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnfMtltxtDescripcion.HintForeColor = System.Drawing.Color.Empty;
            this.bnfMtltxtDescripcion.HintText = "";
            this.bnfMtltxtDescripcion.isPassword = false;
            this.bnfMtltxtDescripcion.LineFocusedColor = System.Drawing.Color.Blue;
            this.bnfMtltxtDescripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.bnfMtltxtDescripcion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bnfMtltxtDescripcion.LineThickness = 3;
            this.bnfMtltxtDescripcion.Location = new System.Drawing.Point(36, 11);
            this.bnfMtltxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.bnfMtltxtDescripcion.Name = "bnfMtltxtDescripcion";
            this.bnfMtltxtDescripcion.Size = new System.Drawing.Size(511, 33);
            this.bnfMtltxtDescripcion.TabIndex = 1;
            this.bnfMtltxtDescripcion.Text = "Descripción";
            this.bnfMtltxtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnfMtltxtDescripcion.OnValueChanged += new System.EventHandler(this.bnfMtltxtDescripcion_OnValueChanged);
            // 
            // btnAgregarPaquete
            // 
            this.btnAgregarPaquete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgregarPaquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.btnAgregarPaquete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarPaquete.BorderRadius = 0;
            this.btnAgregarPaquete.ButtonText = "Agregar paquete";
            this.btnAgregarPaquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPaquete.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarPaquete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarPaquete.Iconimage = null;
            this.btnAgregarPaquete.Iconimage_right = null;
            this.btnAgregarPaquete.Iconimage_right_Selected = null;
            this.btnAgregarPaquete.Iconimage_Selected = null;
            this.btnAgregarPaquete.IconMarginLeft = 0;
            this.btnAgregarPaquete.IconMarginRight = 0;
            this.btnAgregarPaquete.IconRightVisible = true;
            this.btnAgregarPaquete.IconRightZoom = 0D;
            this.btnAgregarPaquete.IconVisible = true;
            this.btnAgregarPaquete.IconZoom = 90D;
            this.btnAgregarPaquete.IsTab = false;
            this.btnAgregarPaquete.Location = new System.Drawing.Point(356, 252);
            this.btnAgregarPaquete.Name = "btnAgregarPaquete";
            this.btnAgregarPaquete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.btnAgregarPaquete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarPaquete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarPaquete.selected = false;
            this.btnAgregarPaquete.Size = new System.Drawing.Size(180, 25);
            this.btnAgregarPaquete.TabIndex = 2;
            this.btnAgregarPaquete.Text = "Agregar paquete";
            this.btnAgregarPaquete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarPaquete.Textcolor = System.Drawing.Color.White;
            this.btnAgregarPaquete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPaquete.Click += new System.EventHandler(this.btnAgregarPaquete_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelAgregarPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregarPaquete);
            this.Controls.Add(this.bnfMtltxtDescripcion);
            this.Controls.Add(this.bnfCstgridPaquetes);
            this.Name = "PanelAgregarPaquete";
            this.Size = new System.Drawing.Size(580, 280);
            this.Load += new System.EventHandler(this.PanelAgregarPaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnfCstgridPaquetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bnfCstgridPaquetes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfMtltxtDescripcion;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
