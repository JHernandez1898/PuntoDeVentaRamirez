namespace PuntoDeVentaRamirez
{
    partial class PantallaGastos
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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblCantidad = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDescripcion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bnfDtmpkFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bnfCstgrDetalles = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnfEDtg = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfMtltxtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfMtltxtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfFltbtnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnfCstgrDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bunifuCards1.Controls.Add(this.bnfFltbtnAgregar);
            this.bunifuCards1.Controls.Add(this.bnfMtltxtCantidad);
            this.bunifuCards1.Controls.Add(this.bnfMtltxtDescripcion);
            this.bunifuCards1.Controls.Add(this.lblCantidad);
            this.bunifuCards1.Controls.Add(this.lblDescripcion);
            this.bunifuCards1.Controls.Add(this.bnfDtmpkFecha);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(95, 34);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(331, 385);
            this.bunifuCards1.TabIndex = 0;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(15, 138);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 17);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(15, 41);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(93, 17);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            // 
            // bnfDtmpkFecha
            // 
            this.bnfDtmpkFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfDtmpkFecha.BorderRadius = 0;
            this.bnfDtmpkFecha.ForeColor = System.Drawing.Color.White;
            this.bnfDtmpkFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bnfDtmpkFecha.FormatCustom = null;
            this.bnfDtmpkFecha.Location = new System.Drawing.Point(12, 225);
            this.bnfDtmpkFecha.Name = "bnfDtmpkFecha";
            this.bnfDtmpkFecha.Size = new System.Drawing.Size(303, 36);
            this.bnfDtmpkFecha.TabIndex = 3;
            this.bnfDtmpkFecha.Value = new System.DateTime(2018, 11, 12, 21, 20, 32, 197);
            // 
            // bnfCstgrDetalles
            // 
            this.bnfCstgrDetalles.AllowUserToAddRows = false;
            this.bnfCstgrDetalles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnfCstgrDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bnfCstgrDetalles.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bnfCstgrDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bnfCstgrDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bnfCstgrDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bnfCstgrDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bnfCstgrDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.cantidad});
            this.bnfCstgrDetalles.DoubleBuffered = true;
            this.bnfCstgrDetalles.EnableHeadersVisualStyles = false;
            this.bnfCstgrDetalles.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfCstgrDetalles.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bnfCstgrDetalles.Location = new System.Drawing.Point(504, 34);
            this.bnfCstgrDetalles.Name = "bnfCstgrDetalles";
            this.bnfCstgrDetalles.ReadOnly = true;
            this.bnfCstgrDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bnfCstgrDetalles.RowHeadersVisible = false;
            this.bnfCstgrDetalles.Size = new System.Drawing.Size(751, 504);
            this.bnfCstgrDetalles.TabIndex = 1;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 600;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 150;
            // 
            // bnfEDtg
            // 
            this.bnfEDtg.ElipseRadius = 5;
            this.bnfEDtg.TargetControl = this.bnfCstgrDetalles;
            // 
            // bnfMtltxtDescripcion
            // 
            this.bnfMtltxtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfMtltxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnfMtltxtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnfMtltxtDescripcion.HintForeColor = System.Drawing.Color.Empty;
            this.bnfMtltxtDescripcion.HintText = "";
            this.bnfMtltxtDescripcion.isPassword = false;
            this.bnfMtltxtDescripcion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfMtltxtDescripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.bnfMtltxtDescripcion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfMtltxtDescripcion.LineThickness = 3;
            this.bnfMtltxtDescripcion.Location = new System.Drawing.Point(17, 62);
            this.bnfMtltxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.bnfMtltxtDescripcion.Name = "bnfMtltxtDescripcion";
            this.bnfMtltxtDescripcion.Size = new System.Drawing.Size(297, 33);
            this.bnfMtltxtDescripcion.TabIndex = 6;
            this.bnfMtltxtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnfMtltxtCantidad
            // 
            this.bnfMtltxtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfMtltxtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnfMtltxtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnfMtltxtCantidad.HintForeColor = System.Drawing.Color.Empty;
            this.bnfMtltxtCantidad.HintText = "";
            this.bnfMtltxtCantidad.isPassword = false;
            this.bnfMtltxtCantidad.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfMtltxtCantidad.LineIdleColor = System.Drawing.Color.Gray;
            this.bnfMtltxtCantidad.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfMtltxtCantidad.LineThickness = 3;
            this.bnfMtltxtCantidad.Location = new System.Drawing.Point(17, 159);
            this.bnfMtltxtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.bnfMtltxtCantidad.Name = "bnfMtltxtCantidad";
            this.bnfMtltxtCantidad.Size = new System.Drawing.Size(297, 33);
            this.bnfMtltxtCantidad.TabIndex = 7;
            this.bnfMtltxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnfFltbtnAgregar
            // 
            this.bnfFltbtnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFltbtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFltbtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfFltbtnAgregar.BorderRadius = 0;
            this.bnfFltbtnAgregar.ButtonText = "Agregar";
            this.bnfFltbtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfFltbtnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.bnfFltbtnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfFltbtnAgregar.Iconimage = null;
            this.bnfFltbtnAgregar.Iconimage_right = null;
            this.bnfFltbtnAgregar.Iconimage_right_Selected = null;
            this.bnfFltbtnAgregar.Iconimage_Selected = null;
            this.bnfFltbtnAgregar.IconMarginLeft = 0;
            this.bnfFltbtnAgregar.IconMarginRight = 0;
            this.bnfFltbtnAgregar.IconRightVisible = true;
            this.bnfFltbtnAgregar.IconRightZoom = 0D;
            this.bnfFltbtnAgregar.IconVisible = true;
            this.bnfFltbtnAgregar.IconZoom = 90D;
            this.bnfFltbtnAgregar.IsTab = false;
            this.bnfFltbtnAgregar.Location = new System.Drawing.Point(48, 297);
            this.bnfFltbtnAgregar.Name = "bnfFltbtnAgregar";
            this.bnfFltbtnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFltbtnAgregar.OnHovercolor = System.Drawing.Color.Gray;
            this.bnfFltbtnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfFltbtnAgregar.selected = false;
            this.bnfFltbtnAgregar.Size = new System.Drawing.Size(241, 48);
            this.bnfFltbtnAgregar.TabIndex = 8;
            this.bnfFltbtnAgregar.Text = "Agregar";
            this.bnfFltbtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfFltbtnAgregar.Textcolor = System.Drawing.Color.White;
            this.bnfFltbtnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.bnfFltbtnAgregar;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.bnfDtmpkFecha;
            // 
            // PantallaGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bnfCstgrDetalles);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "PantallaGastos";
            this.Size = new System.Drawing.Size(1350, 689);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnfCstgrDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bnfCstgrDetalles;
        private Bunifu.Framework.UI.BunifuDatepicker bnfDtmpkFecha;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCantidad;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private Bunifu.Framework.UI.BunifuElipse bnfEDtg;
        private Bunifu.Framework.UI.BunifuFlatButton bnfFltbtnAgregar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfMtltxtCantidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfMtltxtDescripcion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}
