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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bnfFltbtnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnfMtltxtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfMtltxtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfDtmpkFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            bnfCstgrDetalles = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnfEDtg = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnfbtnRegistrarPago = new Bunifu.Framework.UI.BunifuFlatButton();
            bnfPanelNotificaciones = new System.Windows.Forms.Panel();
            bnfgridPedidos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lblFechaLimiteDePago = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFechallegada = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bnfdtmLimitePago = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bnfdtmLlegada = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bnftxtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnftxtIva = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnftxtProveedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnfAgregarPedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bnftxtNumeroFactura = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnftxtSubtotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(bnfCstgrDetalles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(bnfgridPedidos)).BeginInit();
            this.bunifuCards2.SuspendLayout();
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
            this.bunifuCards1.Controls.Add(this.bnfDtmpkFecha);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(17, 34);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(455, 164);
            this.bunifuCards1.TabIndex = 0;
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
            this.bnfFltbtnAgregar.Location = new System.Drawing.Point(343, 121);
            this.bnfFltbtnAgregar.Name = "bnfFltbtnAgregar";
            this.bnfFltbtnAgregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFltbtnAgregar.OnHovercolor = System.Drawing.Color.Gray;
            this.bnfFltbtnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfFltbtnAgregar.selected = false;
            this.bnfFltbtnAgregar.Size = new System.Drawing.Size(97, 29);
            this.bnfFltbtnAgregar.TabIndex = 8;
            this.bnfFltbtnAgregar.Text = "Agregar";
            this.bnfFltbtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfFltbtnAgregar.Textcolor = System.Drawing.Color.White;
            this.bnfFltbtnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfFltbtnAgregar.Click += new System.EventHandler(this.bnfFltbtnAgregar_Click);
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
            this.bnfMtltxtCantidad.Location = new System.Drawing.Point(12, 56);
            this.bnfMtltxtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.bnfMtltxtCantidad.Name = "bnfMtltxtCantidad";
            this.bnfMtltxtCantidad.Size = new System.Drawing.Size(428, 33);
            this.bnfMtltxtCantidad.TabIndex = 7;
            this.bnfMtltxtCantidad.Text = "Monto";
            this.bnfMtltxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.bnfMtltxtDescripcion.Location = new System.Drawing.Point(12, 15);
            this.bnfMtltxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.bnfMtltxtDescripcion.Name = "bnfMtltxtDescripcion";
            this.bnfMtltxtDescripcion.Size = new System.Drawing.Size(428, 33);
            this.bnfMtltxtDescripcion.TabIndex = 6;
            this.bnfMtltxtDescripcion.Text = "Descripción";
            this.bnfMtltxtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnfDtmpkFecha
            // 
            this.bnfDtmpkFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfDtmpkFecha.BorderRadius = 0;
            this.bnfDtmpkFecha.ForeColor = System.Drawing.Color.White;
            this.bnfDtmpkFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bnfDtmpkFecha.FormatCustom = null;
            this.bnfDtmpkFecha.Location = new System.Drawing.Point(12, 114);
            this.bnfDtmpkFecha.Name = "bnfDtmpkFecha";
            this.bnfDtmpkFecha.Size = new System.Drawing.Size(303, 36);
            this.bnfDtmpkFecha.TabIndex = 3;
            this.bnfDtmpkFecha.Value = new System.DateTime(2018, 11, 12, 21, 20, 32, 197);
            // 
            // bnfCstgrDetalles
            // 
            bnfCstgrDetalles.AllowUserToAddRows = false;
            bnfCstgrDetalles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            bnfCstgrDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bnfCstgrDetalles.BackgroundColor = System.Drawing.Color.Gainsboro;
            bnfCstgrDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            bnfCstgrDetalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            bnfCstgrDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            bnfCstgrDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bnfCstgrDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.cantidad});
            bnfCstgrDetalles.DoubleBuffered = true;
            bnfCstgrDetalles.EnableHeadersVisualStyles = false;
            bnfCstgrDetalles.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            bnfCstgrDetalles.HeaderForeColor = System.Drawing.Color.Honeydew;
            bnfCstgrDetalles.Location = new System.Drawing.Point(478, 34);
            bnfCstgrDetalles.Name = "bnfCstgrDetalles";
            bnfCstgrDetalles.ReadOnly = true;
            bnfCstgrDetalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            bnfCstgrDetalles.RowHeadersVisible = false;
            bnfCstgrDetalles.Size = new System.Drawing.Size(805, 164);
            bnfCstgrDetalles.TabIndex = 1;
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
            this.bnfEDtg.TargetControl = bnfCstgrDetalles;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(bnfCstgrDetalles);
            this.groupBox1.Controls.Add(this.bunifuCards1);
            this.groupBox1.Location = new System.Drawing.Point(37, 452);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1301, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gastos comunes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(bnfbtnRegistrarPago);
            this.groupBox2.Controls.Add(bnfPanelNotificaciones);
            this.groupBox2.Controls.Add(bnfgridPedidos);
            this.groupBox2.Controls.Add(this.bunifuCards2);
            this.groupBox2.Location = new System.Drawing.Point(37, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1301, 428);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedidos";
            // 
            // bnfbtnRegistrarPago
            // 
            this.bnfbtnRegistrarPago.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfbtnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfbtnRegistrarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfbtnRegistrarPago.BorderRadius = 6;
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
            this.bnfbtnRegistrarPago.Location = new System.Drawing.Point(1154, 378);
            this.bnfbtnRegistrarPago.Name = "bnfbtnRegistrarPago";
            this.bnfbtnRegistrarPago.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfbtnRegistrarPago.OnHovercolor = System.Drawing.Color.Gray;
            this.bnfbtnRegistrarPago.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfbtnRegistrarPago.selected = false;
            this.bnfbtnRegistrarPago.Size = new System.Drawing.Size(129, 29);
            this.bnfbtnRegistrarPago.TabIndex = 10;
            this.bnfbtnRegistrarPago.Text = "Registrar Pago";
            this.bnfbtnRegistrarPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfbtnRegistrarPago.Textcolor = System.Drawing.Color.White;
            this.bnfbtnRegistrarPago.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfbtnRegistrarPago.Click += new System.EventHandler(this.bnfbtnRegistrarPago_Click);
            // 
            // bnfPanelNotificaciones
            // 
            bnfPanelNotificaciones.BackColor = System.Drawing.Color.Gray;
            bnfPanelNotificaciones.Location = new System.Drawing.Point(1011, 19);
            bnfPanelNotificaciones.Name = "bnfPanelNotificaciones";
            bnfPanelNotificaciones.Size = new System.Drawing.Size(272, 353);
            bnfPanelNotificaciones.TabIndex = 2;
            // 
            // bnfgridPedidos
            // 
            bnfgridPedidos.AllowUserToAddRows = false;
            bnfgridPedidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            bnfgridPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            bnfgridPedidos.BackgroundColor = System.Drawing.Color.Gainsboro;
            bnfgridPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            bnfgridPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            bnfgridPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            bnfgridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bnfgridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Proveedor,
            this.Subtotal,
            this.IVA,
            this.Total});
            bnfgridPedidos.DoubleBuffered = true;
            bnfgridPedidos.EnableHeadersVisualStyles = false;
            bnfgridPedidos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            bnfgridPedidos.HeaderForeColor = System.Drawing.Color.Honeydew;
            bnfgridPedidos.Location = new System.Drawing.Point(373, 19);
            bnfgridPedidos.Name = "bnfgridPedidos";
            bnfgridPedidos.ReadOnly = true;
            bnfgridPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            bnfgridPedidos.RowHeadersVisible = false;
            bnfgridPedidos.Size = new System.Drawing.Size(620, 390);
            bnfgridPedidos.TabIndex = 1;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Factura";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 74;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 174;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 124;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Width = 124;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 123;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bunifuCards2.Controls.Add(this.lblFechaLimiteDePago);
            this.bunifuCards2.Controls.Add(this.lblFechallegada);
            this.bunifuCards2.Controls.Add(this.bnfdtmLimitePago);
            this.bunifuCards2.Controls.Add(this.bnfdtmLlegada);
            this.bunifuCards2.Controls.Add(this.bnftxtTotal);
            this.bunifuCards2.Controls.Add(this.bnftxtIva);
            this.bunifuCards2.Controls.Add(this.bnftxtProveedor);
            this.bunifuCards2.Controls.Add(this.bnfAgregarPedido);
            this.bunifuCards2.Controls.Add(this.bnftxtNumeroFactura);
            this.bunifuCards2.Controls.Add(this.bnftxtSubtotal);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(17, 19);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(350, 388);
            this.bunifuCards2.TabIndex = 0;
            // 
            // lblFechaLimiteDePago
            // 
            this.lblFechaLimiteDePago.AutoSize = true;
            this.lblFechaLimiteDePago.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFechaLimiteDePago.Location = new System.Drawing.Point(9, 280);
            this.lblFechaLimiteDePago.Name = "lblFechaLimiteDePago";
            this.lblFechaLimiteDePago.Size = new System.Drawing.Size(162, 17);
            this.lblFechaLimiteDePago.TabIndex = 16;
            this.lblFechaLimiteDePago.Text = "Fecha límite de pago:";
            // 
            // lblFechallegada
            // 
            this.lblFechallegada.AutoSize = true;
            this.lblFechallegada.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFechallegada.Location = new System.Drawing.Point(9, 15);
            this.lblFechallegada.Name = "lblFechallegada";
            this.lblFechallegada.Size = new System.Drawing.Size(137, 17);
            this.lblFechallegada.TabIndex = 15;
            this.lblFechallegada.Text = "Fecha de llegada:";
            // 
            // bnfdtmLimitePago
            // 
            this.bnfdtmLimitePago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfdtmLimitePago.BorderRadius = 6;
            this.bnfdtmLimitePago.ForeColor = System.Drawing.Color.White;
            this.bnfdtmLimitePago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bnfdtmLimitePago.FormatCustom = null;
            this.bnfdtmLimitePago.Location = new System.Drawing.Point(12, 305);
            this.bnfdtmLimitePago.Name = "bnfdtmLimitePago";
            this.bnfdtmLimitePago.Size = new System.Drawing.Size(212, 36);
            this.bnfdtmLimitePago.TabIndex = 14;
            this.bnfdtmLimitePago.Value = new System.DateTime(2018, 12, 1, 9, 19, 28, 369);
            // 
            // bnfdtmLlegada
            // 
            this.bnfdtmLlegada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfdtmLlegada.BorderRadius = 6;
            this.bnfdtmLlegada.ForeColor = System.Drawing.Color.White;
            this.bnfdtmLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bnfdtmLlegada.FormatCustom = null;
            this.bnfdtmLlegada.Location = new System.Drawing.Point(12, 35);
            this.bnfdtmLlegada.Name = "bnfdtmLlegada";
            this.bnfdtmLlegada.Size = new System.Drawing.Size(212, 36);
            this.bnfdtmLlegada.TabIndex = 13;
            this.bnfdtmLlegada.Value = new System.DateTime(2018, 12, 1, 9, 19, 28, 369);
            // 
            // bnftxtTotal
            // 
            this.bnftxtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtTotal.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtTotal.HintText = "";
            this.bnftxtTotal.isPassword = false;
            this.bnftxtTotal.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtTotal.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtTotal.LineThickness = 3;
            this.bnftxtTotal.Location = new System.Drawing.Point(12, 237);
            this.bnftxtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtTotal.Name = "bnftxtTotal";
            this.bnftxtTotal.Size = new System.Drawing.Size(323, 33);
            this.bnftxtTotal.TabIndex = 12;
            this.bnftxtTotal.Text = "Total";
            this.bnftxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnftxtIva
            // 
            this.bnftxtIva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtIva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtIva.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtIva.HintText = "";
            this.bnftxtIva.isPassword = false;
            this.bnftxtIva.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtIva.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtIva.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtIva.LineThickness = 3;
            this.bnftxtIva.Location = new System.Drawing.Point(12, 196);
            this.bnftxtIva.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtIva.Name = "bnftxtIva";
            this.bnftxtIva.Size = new System.Drawing.Size(323, 33);
            this.bnftxtIva.TabIndex = 11;
            this.bnftxtIva.Text = "IVA";
            this.bnftxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnftxtProveedor
            // 
            this.bnftxtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtProveedor.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtProveedor.HintText = "";
            this.bnftxtProveedor.isPassword = false;
            this.bnftxtProveedor.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtProveedor.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtProveedor.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtProveedor.LineThickness = 3;
            this.bnftxtProveedor.Location = new System.Drawing.Point(12, 114);
            this.bnftxtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtProveedor.Name = "bnftxtProveedor";
            this.bnftxtProveedor.Size = new System.Drawing.Size(323, 33);
            this.bnftxtProveedor.TabIndex = 10;
            this.bnftxtProveedor.Text = "Proveedor";
            this.bnftxtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnfAgregarPedido
            // 
            this.bnfAgregarPedido.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfAgregarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfAgregarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnfAgregarPedido.BorderRadius = 6;
            this.bnfAgregarPedido.ButtonText = "Agregar";
            this.bnfAgregarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfAgregarPedido.DisabledColor = System.Drawing.Color.Gray;
            this.bnfAgregarPedido.Iconcolor = System.Drawing.Color.Transparent;
            this.bnfAgregarPedido.Iconimage = null;
            this.bnfAgregarPedido.Iconimage_right = null;
            this.bnfAgregarPedido.Iconimage_right_Selected = null;
            this.bnfAgregarPedido.Iconimage_Selected = null;
            this.bnfAgregarPedido.IconMarginLeft = 0;
            this.bnfAgregarPedido.IconMarginRight = 0;
            this.bnfAgregarPedido.IconRightVisible = true;
            this.bnfAgregarPedido.IconRightZoom = 0D;
            this.bnfAgregarPedido.IconVisible = true;
            this.bnfAgregarPedido.IconZoom = 90D;
            this.bnfAgregarPedido.IsTab = false;
            this.bnfAgregarPedido.Location = new System.Drawing.Point(238, 343);
            this.bnfAgregarPedido.Name = "bnfAgregarPedido";
            this.bnfAgregarPedido.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfAgregarPedido.OnHovercolor = System.Drawing.Color.Gray;
            this.bnfAgregarPedido.OnHoverTextColor = System.Drawing.Color.White;
            this.bnfAgregarPedido.selected = false;
            this.bnfAgregarPedido.Size = new System.Drawing.Size(97, 29);
            this.bnfAgregarPedido.TabIndex = 8;
            this.bnfAgregarPedido.Text = "Agregar";
            this.bnfAgregarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfAgregarPedido.Textcolor = System.Drawing.Color.White;
            this.bnfAgregarPedido.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfAgregarPedido.Click += new System.EventHandler(this.bnfAgregarPedido_Click);
            // 
            // bnftxtNumeroFactura
            // 
            this.bnftxtNumeroFactura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtNumeroFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtNumeroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtNumeroFactura.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtNumeroFactura.HintText = "";
            this.bnftxtNumeroFactura.isPassword = false;
            this.bnftxtNumeroFactura.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtNumeroFactura.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtNumeroFactura.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtNumeroFactura.LineThickness = 3;
            this.bnftxtNumeroFactura.Location = new System.Drawing.Point(12, 73);
            this.bnftxtNumeroFactura.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtNumeroFactura.Name = "bnftxtNumeroFactura";
            this.bnftxtNumeroFactura.Size = new System.Drawing.Size(323, 33);
            this.bnftxtNumeroFactura.TabIndex = 7;
            this.bnftxtNumeroFactura.Text = "Número de factura";
            this.bnftxtNumeroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnftxtSubtotal
            // 
            this.bnftxtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtSubtotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtSubtotal.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtSubtotal.HintText = "";
            this.bnftxtSubtotal.isPassword = false;
            this.bnftxtSubtotal.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtSubtotal.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtSubtotal.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtSubtotal.LineThickness = 3;
            this.bnftxtSubtotal.Location = new System.Drawing.Point(12, 155);
            this.bnftxtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtSubtotal.Name = "bnftxtSubtotal";
            this.bnftxtSubtotal.Size = new System.Drawing.Size(323, 33);
            this.bnftxtSubtotal.TabIndex = 6;
            this.bnftxtSubtotal.Text = "Subtotal";
            this.bnftxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = bnfgridPedidos;
            // 
            // PantallaGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaGastos";
            this.Size = new System.Drawing.Size(1350, 689);
            this.Load += new System.EventHandler(this.PantallaGastos_Load);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(bnfCstgrDetalles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(bnfgridPedidos)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuDatepicker bnfDtmpkFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private Bunifu.Framework.UI.BunifuElipse bnfEDtg;
        private Bunifu.Framework.UI.BunifuFlatButton bnfFltbtnAgregar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfMtltxtCantidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnfMtltxtDescripcion;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuFlatButton bnfAgregarPedido;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtNumeroFactura;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtSubtotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFechaLimiteDePago;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFechallegada;
        private Bunifu.Framework.UI.BunifuDatepicker bnfdtmLimitePago;
        private Bunifu.Framework.UI.BunifuDatepicker bnfdtmLlegada;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtTotal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtIva;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtProveedor;
        private Bunifu.Framework.UI.BunifuFlatButton bnfbtnRegistrarPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private static Bunifu.Framework.UI.BunifuCustomDataGrid bnfCstgrDetalles;
        private static Bunifu.Framework.UI.BunifuCustomDataGrid bnfgridPedidos;
        private static System.Windows.Forms.Panel bnfPanelNotificaciones;
    }
}
