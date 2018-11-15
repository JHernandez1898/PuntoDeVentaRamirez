namespace PuntoDeVentaRamirez
{
    partial class PantallaPuntoDeVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPuntoDeVenta));
            this.bnfDtgCuenta = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpVenta = new System.Windows.Forms.GroupBox();
            this.bnfImgbtnBorrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnfImgbtnCarrito = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bnfTlbtnNuevoProducto = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bnfECarrito = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfEBorrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfEDtg = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfFltbtnCobrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfECobrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnfDtgCuenta)).BeginInit();
            this.grpVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgbtnBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgbtnCarrito)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnfDtgCuenta
            // 
            this.bnfDtgCuenta.AllowUserToDeleteRows = false;
            this.bnfDtgCuenta.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnfDtgCuenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bnfDtgCuenta.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bnfDtgCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bnfDtgCuenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bnfDtgCuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bnfDtgCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bnfDtgCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.precio,
            this.cantidad,
            this.importe});
            this.bnfDtgCuenta.DoubleBuffered = true;
            this.bnfDtgCuenta.EnableHeadersVisualStyles = false;
            this.bnfDtgCuenta.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfDtgCuenta.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bnfDtgCuenta.Location = new System.Drawing.Point(200, 93);
            this.bnfDtgCuenta.Name = "bnfDtgCuenta";
            this.bnfDtgCuenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bnfDtgCuenta.RowHeadersVisible = false;
            this.bnfDtgCuenta.Size = new System.Drawing.Size(1100, 460);
            this.bnfDtgCuenta.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 200F;
            this.descripcion.HeaderText = "Descripción del Producto";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 499;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 150;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.Width = 150;
            // 
            // grpVenta
            // 
            this.grpVenta.BackColor = System.Drawing.Color.White;
            this.grpVenta.Controls.Add(this.bnfImgbtnBorrar);
            this.grpVenta.Controls.Add(this.bnfImgbtnCarrito);
            this.grpVenta.Controls.Add(this.bunifuTextbox1);
            this.grpVenta.Location = new System.Drawing.Point(200, 28);
            this.grpVenta.Name = "grpVenta";
            this.grpVenta.Size = new System.Drawing.Size(1102, 59);
            this.grpVenta.TabIndex = 1;
            this.grpVenta.TabStop = false;
            this.grpVenta.Text = "Venta de Productos";
            // 
            // bnfImgbtnBorrar
            // 
            this.bnfImgbtnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bnfImgbtnBorrar.Image = global::PuntoDeVentaRamirez.Properties.Resources.eliminar100;
            this.bnfImgbtnBorrar.ImageActive = null;
            this.bnfImgbtnBorrar.Location = new System.Drawing.Point(795, 14);
            this.bnfImgbtnBorrar.Name = "bnfImgbtnBorrar";
            this.bnfImgbtnBorrar.Size = new System.Drawing.Size(67, 34);
            this.bnfImgbtnBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgbtnBorrar.TabIndex = 2;
            this.bnfImgbtnBorrar.TabStop = false;
            this.bnfImgbtnBorrar.Tag = "Agregar al carrito";
            this.bnfImgbtnBorrar.Zoom = 10;
            // 
            // bnfImgbtnCarrito
            // 
            this.bnfImgbtnCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnfImgbtnCarrito.Image = global::PuntoDeVentaRamirez.Properties.Resources.agregaralcarrito;
            this.bnfImgbtnCarrito.ImageActive = null;
            this.bnfImgbtnCarrito.Location = new System.Drawing.Point(709, 14);
            this.bnfImgbtnCarrito.Name = "bnfImgbtnCarrito";
            this.bnfImgbtnCarrito.Size = new System.Drawing.Size(67, 34);
            this.bnfImgbtnCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnfImgbtnCarrito.TabIndex = 1;
            this.bnfImgbtnCarrito.TabStop = false;
            this.bnfImgbtnCarrito.Tag = "Agregar al carrito";
            this.bnfImgbtnCarrito.Zoom = 10;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(15, 19);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(688, 29);
            this.bunifuTextbox1.TabIndex = 0;
            this.bunifuTextbox1.text = "Código del Producto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.bunifuTileButton4);
            this.panel1.Controls.Add(this.bunifuTileButton3);
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Controls.Add(this.bnfTlbtnNuevoProducto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 768);
            this.panel1.TabIndex = 2;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTileButton4.color = System.Drawing.Color.Empty;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(100)))));
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = global::PuntoDeVentaRamirez.Properties.Resources.paquete;
            this.bunifuTileButton4.ImagePosition = 20;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 50;
            this.bunifuTileButton4.LabelText = "Nuevo Paquete";
            this.bunifuTileButton4.Location = new System.Drawing.Point(1, 140);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(125, 128);
            this.bunifuTileButton4.TabIndex = 3;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTileButton3.color = System.Drawing.Color.Empty;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(100)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = global::PuntoDeVentaRamirez.Properties.Resources.busqueda;
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Buscar";
            this.bunifuTileButton3.Location = new System.Drawing.Point(0, 402);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(126, 137);
            this.bunifuTileButton3.TabIndex = 2;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTileButton2.color = System.Drawing.Color.Empty;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(100)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::PuntoDeVentaRamirez.Properties.Resources.paquete;
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 50;
            this.bunifuTileButton2.LabelText = "Agregar Paquete";
            this.bunifuTileButton2.Location = new System.Drawing.Point(1, 262);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(125, 128);
            this.bunifuTileButton2.TabIndex = 1;
            // 
            // bnfTlbtnNuevoProducto
            // 
            this.bnfTlbtnNuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfTlbtnNuevoProducto.color = System.Drawing.Color.Empty;
            this.bnfTlbtnNuevoProducto.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(100)))));
            this.bnfTlbtnNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfTlbtnNuevoProducto.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bnfTlbtnNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.bnfTlbtnNuevoProducto.Image = global::PuntoDeVentaRamirez.Properties.Resources.agregar;
            this.bnfTlbtnNuevoProducto.ImagePosition = 20;
            this.bnfTlbtnNuevoProducto.ImageZoom = 50;
            this.bnfTlbtnNuevoProducto.LabelPosition = 50;
            this.bnfTlbtnNuevoProducto.LabelText = "Nuevo Producto";
            this.bnfTlbtnNuevoProducto.Location = new System.Drawing.Point(0, -1);
            this.bnfTlbtnNuevoProducto.Margin = new System.Windows.Forms.Padding(6);
            this.bnfTlbtnNuevoProducto.Name = "bnfTlbtnNuevoProducto";
            this.bnfTlbtnNuevoProducto.Size = new System.Drawing.Size(125, 129);
            this.bnfTlbtnNuevoProducto.TabIndex = 0;
            this.bnfTlbtnNuevoProducto.Click += new System.EventHandler(this.bnfTlbtnNuevoProducto_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(849, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(237, 76);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "$00.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnfFltbtnCobrar);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Location = new System.Drawing.Point(200, 559);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(417, 50);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(71, 17);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Cambio: ";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(220, 50);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(86, 17);
            this.bunifuCustomLabel3.TabIndex = 6;
            this.bunifuCustomLabel3.Text = "Pago con: ";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(34, 50);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(111, 17);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Total a pagar:";
            // 
            // bnfECarrito
            // 
            this.bnfECarrito.ElipseRadius = 5;
            this.bnfECarrito.TargetControl = this.bnfImgbtnCarrito;
            // 
            // bnfEBorrar
            // 
            this.bnfEBorrar.ElipseRadius = 5;
            this.bnfEBorrar.TargetControl = this.bnfImgbtnBorrar;
            // 
            // bnfEDtg
            // 
            this.bnfEDtg.ElipseRadius = 5;
            this.bnfEDtg.TargetControl = this.bnfDtgCuenta;
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
            this.bnfFltbtnCobrar.Location = new System.Drawing.Point(591, 14);
            this.bnfFltbtnCobrar.Name = "bnfFltbtnCobrar";
            this.bnfFltbtnCobrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFltbtnCobrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(90)))));
            this.bnfFltbtnCobrar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfFltbtnCobrar.selected = false;
            this.bnfFltbtnCobrar.Size = new System.Drawing.Size(252, 75);
            this.bnfFltbtnCobrar.TabIndex = 8;
            this.bnfFltbtnCobrar.Text = "Cobrar";
            this.bnfFltbtnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfFltbtnCobrar.Textcolor = System.Drawing.Color.White;
            this.bnfFltbtnCobrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bnfECobrar
            // 
            this.bnfECobrar.ElipseRadius = 5;
            this.bnfECobrar.TargetControl = this.bnfFltbtnCobrar;
            // 
            // PantallaPuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpVenta);
            this.Controls.Add(this.bnfDtgCuenta);
            this.Name = "PantallaPuntoDeVenta";
            this.Size = new System.Drawing.Size(1394, 768);
            ((System.ComponentModel.ISupportInitialize)(this.bnfDtgCuenta)).EndInit();
            this.grpVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgbtnBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnfImgbtnCarrito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bnfDtgCuenta;
        private System.Windows.Forms.GroupBox grpVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton bnfTlbtnNuevoProducto;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgbtnCarrito;
        private Bunifu.Framework.UI.BunifuImageButton bnfImgbtnBorrar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuElipse bnfECarrito;
        private Bunifu.Framework.UI.BunifuElipse bnfEBorrar;
        private Bunifu.Framework.UI.BunifuElipse bnfEDtg;
        private Bunifu.Framework.UI.BunifuFlatButton bnfFltbtnCobrar;
        private Bunifu.Framework.UI.BunifuElipse bnfECobrar;
    }
}
