namespace PuntoDeVentaRamirez
{
    partial class CrearPaquete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bnfCstgrdArticulos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCriterios = new System.Windows.Forms.GroupBox();
            this.bnfMtltxtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bnfCstgridPaquete = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bnfMtltxNombrePaquete = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfTlbtnEliminar = new Bunifu.Framework.UI.BunifuTileButton();
            this.bnfTlbtnAgregar = new Bunifu.Framework.UI.BunifuTileButton();
            this.bnfCrear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnflblTotalGigante = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bnfCstgrdArticulos)).BeginInit();
            this.grpCriterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnfCstgridPaquete)).BeginInit();
            this.SuspendLayout();
            // 
            // bnfCstgrdArticulos
            // 
            this.bnfCstgrdArticulos.AllowUserToAddRows = false;
            this.bnfCstgrdArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnfCstgrdArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bnfCstgrdArticulos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bnfCstgrdArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bnfCstgrdArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bnfCstgrdArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bnfCstgrdArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bnfCstgrdArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripción,
            this.precio});
            this.bnfCstgrdArticulos.DoubleBuffered = true;
            this.bnfCstgrdArticulos.EnableHeadersVisualStyles = false;
            this.bnfCstgrdArticulos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfCstgrdArticulos.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bnfCstgrdArticulos.Location = new System.Drawing.Point(48, 130);
            this.bnfCstgrdArticulos.Name = "bnfCstgrdArticulos";
            this.bnfCstgrdArticulos.ReadOnly = true;
            this.bnfCstgrdArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bnfCstgrdArticulos.RowHeadersVisible = false;
            this.bnfCstgrdArticulos.Size = new System.Drawing.Size(500, 500);
            this.bnfCstgrdArticulos.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descripción
            // 
            this.descripción.HeaderText = "Descripción";
            this.descripción.Name = "descripción";
            this.descripción.ReadOnly = true;
            this.descripción.Width = 300;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 99;
            // 
            // grpCriterios
            // 
            this.grpCriterios.Controls.Add(this.bnfMtltxtDescripcion);
            this.grpCriterios.Location = new System.Drawing.Point(48, 56);
            this.grpCriterios.Name = "grpCriterios";
            this.grpCriterios.Size = new System.Drawing.Size(510, 68);
            this.grpCriterios.TabIndex = 2;
            this.grpCriterios.TabStop = false;
            this.grpCriterios.Text = "Criterios de búsqueda";
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
            this.bnfMtltxtDescripcion.Location = new System.Drawing.Point(7, 20);
            this.bnfMtltxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.bnfMtltxtDescripcion.Name = "bnfMtltxtDescripcion";
            this.bnfMtltxtDescripcion.Size = new System.Drawing.Size(493, 33);
            this.bnfMtltxtDescripcion.TabIndex = 1;
            this.bnfMtltxtDescripcion.Text = "Descripción";
            this.bnfMtltxtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bnfMtltxtDescripcion.OnValueChanged += new System.EventHandler(this.bnfMtltxtDescripcion_OnValueChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.bnfCstgrdArticulos;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(787, 79);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 13);
            this.bunifuCustomLabel1.TabIndex = 4;
            // 
            // bnfCstgridPaquete
            // 
            this.bnfCstgridPaquete.AllowUserToAddRows = false;
            this.bnfCstgridPaquete.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnfCstgridPaquete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bnfCstgridPaquete.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bnfCstgridPaquete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bnfCstgridPaquete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bnfCstgridPaquete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bnfCstgridPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bnfCstgridPaquete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.cantidad});
            this.bnfCstgridPaquete.DoubleBuffered = true;
            this.bnfCstgridPaquete.EnableHeadersVisualStyles = false;
            this.bnfCstgridPaquete.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfCstgridPaquete.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bnfCstgridPaquete.Location = new System.Drawing.Point(685, 130);
            this.bnfCstgridPaquete.Name = "bnfCstgridPaquete";
            this.bnfCstgridPaquete.ReadOnly = true;
            this.bnfCstgridPaquete.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bnfCstgridPaquete.RowHeadersVisible = false;
            this.bnfCstgridPaquete.Size = new System.Drawing.Size(500, 500);
            this.bnfCstgridPaquete.TabIndex = 7;
            // 
            // bnfMtltxNombrePaquete
            // 
            this.bnfMtltxNombrePaquete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnfMtltxNombrePaquete.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnfMtltxNombrePaquete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnfMtltxNombrePaquete.HintForeColor = System.Drawing.Color.Empty;
            this.bnfMtltxNombrePaquete.HintText = "";
            this.bnfMtltxNombrePaquete.isPassword = false;
            this.bnfMtltxNombrePaquete.LineFocusedColor = System.Drawing.Color.Blue;
            this.bnfMtltxNombrePaquete.LineIdleColor = System.Drawing.Color.Gray;
            this.bnfMtltxNombrePaquete.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bnfMtltxNombrePaquete.LineThickness = 3;
            this.bnfMtltxNombrePaquete.Location = new System.Drawing.Point(685, 79);
            this.bnfMtltxNombrePaquete.Margin = new System.Windows.Forms.Padding(4);
            this.bnfMtltxNombrePaquete.Name = "bnfMtltxNombrePaquete";
            this.bnfMtltxNombrePaquete.Size = new System.Drawing.Size(500, 33);
            this.bnfMtltxNombrePaquete.TabIndex = 11;
            this.bnfMtltxNombrePaquete.Text = "Nombre del paquete";
            this.bnfMtltxNombrePaquete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnfTlbtnEliminar
            // 
            this.bnfTlbtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bnfTlbtnEliminar.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bnfTlbtnEliminar.colorActive = System.Drawing.Color.IndianRed;
            this.bnfTlbtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTlbtnEliminar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bnfTlbtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.bnfTlbtnEliminar.Image = global::PuntoDeVentaRamirez.Properties.Resources.eliminar100;
            this.bnfTlbtnEliminar.ImagePosition = 14;
            this.bnfTlbtnEliminar.ImageZoom = 45;
            this.bnfTlbtnEliminar.LabelPosition = 51;
            this.bnfTlbtnEliminar.LabelText = "Eliminar del paquete";
            this.bnfTlbtnEliminar.Location = new System.Drawing.Point(555, 259);
            this.bnfTlbtnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.bnfTlbtnEliminar.Name = "bnfTlbtnEliminar";
            this.bnfTlbtnEliminar.Size = new System.Drawing.Size(121, 117);
            this.bnfTlbtnEliminar.TabIndex = 10;
            this.bnfTlbtnEliminar.Click += new System.EventHandler(this.bnfTlbtnEliminar_Click);
            // 
            // bnfTlbtnAgregar
            // 
            this.bnfTlbtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnfTlbtnAgregar.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnfTlbtnAgregar.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bnfTlbtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTlbtnAgregar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bnfTlbtnAgregar.ForeColor = System.Drawing.Color.Black;
            this.bnfTlbtnAgregar.Image = global::PuntoDeVentaRamirez.Properties.Resources.añadirnegro;
            this.bnfTlbtnAgregar.ImagePosition = 14;
            this.bnfTlbtnAgregar.ImageZoom = 45;
            this.bnfTlbtnAgregar.LabelPosition = 51;
            this.bnfTlbtnAgregar.LabelText = "Agregar al paquete";
            this.bnfTlbtnAgregar.Location = new System.Drawing.Point(555, 130);
            this.bnfTlbtnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnfTlbtnAgregar.Name = "bnfTlbtnAgregar";
            this.bnfTlbtnAgregar.Size = new System.Drawing.Size(121, 119);
            this.bnfTlbtnAgregar.TabIndex = 9;
            this.bnfTlbtnAgregar.Click += new System.EventHandler(this.bnfTlbtnAgregar_Click);
            // 
            // bnfCrear
            // 
            this.bnfCrear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(100)))), ((int)(((byte)(90)))));
            this.bnfCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfCrear.BorderRadius = 0;
            this.bnfCrear.ButtonText = "Crear";
            this.bnfCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfCrear.DisabledColor = System.Drawing.Color.Gray;
            this.bnfCrear.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfCrear.Iconimage = null;
            this.bnfCrear.Iconimage_right = null;
            this.bnfCrear.Iconimage_right_Selected = null;
            this.bnfCrear.Iconimage_Selected = null;
            this.bnfCrear.IconMarginLeft = 0;
            this.bnfCrear.IconMarginRight = 0;
            this.bnfCrear.IconRightVisible = true;
            this.bnfCrear.IconRightZoom = 0D;
            this.bnfCrear.IconVisible = true;
            this.bnfCrear.IconZoom = 90D;
            this.bnfCrear.IsTab = false;
            this.bnfCrear.Location = new System.Drawing.Point(1059, 706);
            this.bnfCrear.Name = "bnfCrear";
            this.bnfCrear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfCrear.OnHovercolor = System.Drawing.SystemColors.ControlDark;
            this.bnfCrear.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfCrear.selected = false;
            this.bnfCrear.Size = new System.Drawing.Size(126, 32);
            this.bnfCrear.TabIndex = 6;
            this.bnfCrear.Text = "Crear";
            this.bnfCrear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfCrear.Textcolor = System.Drawing.Color.White;
            this.bnfCrear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfCrear.Click += new System.EventHandler(this.bnfCrear_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.bnfCstgridPaquete;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.bnfTlbtnEliminar;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            this.bunifuElipse4.TargetControl = this.bnfTlbtnAgregar;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 5;
            this.bunifuElipse5.TargetControl = this.bnfCrear;
            // 
            // bnflblTotalGigante
            // 
            this.bnflblTotalGigante.AutoSize = true;
            this.bnflblTotalGigante.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnflblTotalGigante.Location = new System.Drawing.Point(1044, 633);
            this.bnflblTotalGigante.Name = "bnflblTotalGigante";
            this.bnflblTotalGigante.Size = new System.Drawing.Size(141, 46);
            this.bnflblTotalGigante.TabIndex = 12;
            this.bnflblTotalGigante.Text = "$00.00";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 99;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // CrearPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bnflblTotalGigante);
            this.Controls.Add(this.bnfMtltxNombrePaquete);
            this.Controls.Add(this.bnfTlbtnEliminar);
            this.Controls.Add(this.bnfTlbtnAgregar);
            this.Controls.Add(this.bnfCstgridPaquete);
            this.Controls.Add(this.bnfCrear);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.grpCriterios);
            this.Controls.Add(this.bnfCstgrdArticulos);
            this.Name = "CrearPaquete";
            this.Size = new System.Drawing.Size(1258, 766);
            this.Load += new System.EventHandler(this.CrearPaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnfCstgrdArticulos)).EndInit();
            this.grpCriterios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnfCstgridPaquete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bnfCstgrdArticulos;
        private System.Windows.Forms.GroupBox grpCriterios;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfMtltxtDescripcion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bnfCrear;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bnfCstgridPaquete;
        private Bunifu.Framework.UI.BunifuTileButton bnfTlbtnAgregar;
        private Bunifu.Framework.UI.BunifuTileButton bnfTlbtnEliminar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfMtltxNombrePaquete;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuCustomLabel bnflblTotalGigante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}
