namespace PuntoDeVentaRamirez
{
    partial class PantallaInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnMtlModificarProducto = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMtlEliminarProducto = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMtlAgregarProducto = new Bunifu.Framework.UI.BunifuTileButton();
            this.bnfCstgrInventario = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.bnftxtUnidadesDisponibles = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnftxtCategoria = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnftxtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bnftxtCodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.chkCodigoProducto = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkDescripcion = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkCategoria = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkUnidades = new Bunifu.Framework.UI.BunifuCheckbox();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnfCstgrInventario)).BeginInit();
            this.grpBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.MediumPurple;
            this.pnlOpciones.Controls.Add(this.btnMtlModificarProducto);
            this.pnlOpciones.Controls.Add(this.btnMtlEliminarProducto);
            this.pnlOpciones.Controls.Add(this.btnMtlAgregarProducto);
            this.pnlOpciones.Location = new System.Drawing.Point(0, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(127, 750);
            this.pnlOpciones.TabIndex = 3;
            // 
            // btnMtlModificarProducto
            // 
            this.btnMtlModificarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMtlModificarProducto.color = System.Drawing.Color.Empty;
            this.btnMtlModificarProducto.colorActive = System.Drawing.Color.DarkOrchid;
            this.btnMtlModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMtlModificarProducto.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMtlModificarProducto.ForeColor = System.Drawing.Color.White;
            this.btnMtlModificarProducto.Image = global::PuntoDeVentaRamirez.Properties.Resources.editar;
            this.btnMtlModificarProducto.ImagePosition = 20;
            this.btnMtlModificarProducto.ImageZoom = 50;
            this.btnMtlModificarProducto.LabelPosition = 50;
            this.btnMtlModificarProducto.LabelText = "Modificar Producto";
            this.btnMtlModificarProducto.Location = new System.Drawing.Point(0, 293);
            this.btnMtlModificarProducto.Margin = new System.Windows.Forms.Padding(6);
            this.btnMtlModificarProducto.Name = "btnMtlModificarProducto";
            this.btnMtlModificarProducto.Size = new System.Drawing.Size(125, 128);
            this.btnMtlModificarProducto.TabIndex = 2;
            this.btnMtlModificarProducto.Click += new System.EventHandler(this.btnMtlModificarProducto_Click);
            // 
            // btnMtlEliminarProducto
            // 
            this.btnMtlEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMtlEliminarProducto.color = System.Drawing.Color.Empty;
            this.btnMtlEliminarProducto.colorActive = System.Drawing.Color.DarkOrchid;
            this.btnMtlEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMtlEliminarProducto.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMtlEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnMtlEliminarProducto.Image = global::PuntoDeVentaRamirez.Properties.Resources.eliminarblanco;
            this.btnMtlEliminarProducto.ImagePosition = 20;
            this.btnMtlEliminarProducto.ImageZoom = 50;
            this.btnMtlEliminarProducto.LabelPosition = 50;
            this.btnMtlEliminarProducto.LabelText = "Eliminar Producto";
            this.btnMtlEliminarProducto.Location = new System.Drawing.Point(0, 140);
            this.btnMtlEliminarProducto.Margin = new System.Windows.Forms.Padding(6);
            this.btnMtlEliminarProducto.Name = "btnMtlEliminarProducto";
            this.btnMtlEliminarProducto.Size = new System.Drawing.Size(125, 128);
            this.btnMtlEliminarProducto.TabIndex = 1;
            // 
            // btnMtlAgregarProducto
            // 
            this.btnMtlAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMtlAgregarProducto.color = System.Drawing.Color.Empty;
            this.btnMtlAgregarProducto.colorActive = System.Drawing.Color.DarkOrchid;
            this.btnMtlAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMtlAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnMtlAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnMtlAgregarProducto.Image = global::PuntoDeVentaRamirez.Properties.Resources.agregar;
            this.btnMtlAgregarProducto.ImagePosition = 20;
            this.btnMtlAgregarProducto.ImageZoom = 50;
            this.btnMtlAgregarProducto.LabelPosition = 50;
            this.btnMtlAgregarProducto.LabelText = "Nuevo Producto";
            this.btnMtlAgregarProducto.Location = new System.Drawing.Point(0, -1);
            this.btnMtlAgregarProducto.Margin = new System.Windows.Forms.Padding(6);
            this.btnMtlAgregarProducto.Name = "btnMtlAgregarProducto";
            this.btnMtlAgregarProducto.Size = new System.Drawing.Size(125, 129);
            this.btnMtlAgregarProducto.TabIndex = 0;
            this.btnMtlAgregarProducto.Click += new System.EventHandler(this.btnMtlAgregarProducto_Click);
            // 
            // bnfCstgrInventario
            // 
            this.bnfCstgrInventario.AllowUserToAddRows = false;
            this.bnfCstgrInventario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnfCstgrInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.bnfCstgrInventario.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bnfCstgrInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bnfCstgrInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bnfCstgrInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bnfCstgrInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bnfCstgrInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.categoria,
            this.descripcion,
            this.precio,
            this.unidades});
            this.bnfCstgrInventario.DoubleBuffered = true;
            this.bnfCstgrInventario.EnableHeadersVisualStyles = false;
            this.bnfCstgrInventario.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfCstgrInventario.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.bnfCstgrInventario.Location = new System.Drawing.Point(191, 155);
            this.bnfCstgrInventario.Name = "bnfCstgrInventario";
            this.bnfCstgrInventario.ReadOnly = true;
            this.bnfCstgrInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bnfCstgrInventario.RowHeadersVisible = false;
            this.bnfCstgrInventario.Size = new System.Drawing.Size(1100, 497);
            this.bnfCstgrInventario.TabIndex = 4;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código de Producto";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 150;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 499;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio unitario";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 150;
            // 
            // unidades
            // 
            this.unidades.HeaderText = "Unidades disponibles";
            this.unidades.Name = "unidades";
            this.unidades.ReadOnly = true;
            this.unidades.Width = 150;
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.chkUnidades);
            this.grpBusqueda.Controls.Add(this.chkCategoria);
            this.grpBusqueda.Controls.Add(this.chkDescripcion);
            this.grpBusqueda.Controls.Add(this.chkCodigoProducto);
            this.grpBusqueda.Controls.Add(this.bnftxtUnidadesDisponibles);
            this.grpBusqueda.Controls.Add(this.bnftxtCategoria);
            this.grpBusqueda.Controls.Add(this.bnftxtDescripcion);
            this.grpBusqueda.Controls.Add(this.bnftxtCodigo);
            this.grpBusqueda.Location = new System.Drawing.Point(191, 29);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(1100, 100);
            this.grpBusqueda.TabIndex = 5;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Criterios de búsqueda";
            // 
            // bnftxtUnidadesDisponibles
            // 
            this.bnftxtUnidadesDisponibles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtUnidadesDisponibles.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtUnidadesDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtUnidadesDisponibles.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtUnidadesDisponibles.HintText = "";
            this.bnftxtUnidadesDisponibles.isPassword = false;
            this.bnftxtUnidadesDisponibles.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtUnidadesDisponibles.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtUnidadesDisponibles.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtUnidadesDisponibles.LineThickness = 3;
            this.bnftxtUnidadesDisponibles.Location = new System.Drawing.Point(20, 62);
            this.bnftxtUnidadesDisponibles.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtUnidadesDisponibles.Name = "bnftxtUnidadesDisponibles";
            this.bnftxtUnidadesDisponibles.Size = new System.Drawing.Size(166, 33);
            this.bnftxtUnidadesDisponibles.TabIndex = 3;
            this.bnftxtUnidadesDisponibles.Text = "Unidades disponibles";
            this.bnftxtUnidadesDisponibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnftxtCategoria
            // 
            this.bnftxtCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtCategoria.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtCategoria.HintText = "";
            this.bnftxtCategoria.isPassword = false;
            this.bnftxtCategoria.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtCategoria.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtCategoria.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtCategoria.LineThickness = 3;
            this.bnftxtCategoria.Location = new System.Drawing.Point(788, 21);
            this.bnftxtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtCategoria.Name = "bnftxtCategoria";
            this.bnftxtCategoria.Size = new System.Drawing.Size(257, 33);
            this.bnftxtCategoria.TabIndex = 2;
            this.bnftxtCategoria.Text = "Categoría";
            this.bnftxtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnftxtDescripcion
            // 
            this.bnftxtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtDescripcion.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtDescripcion.HintText = "";
            this.bnftxtDescripcion.isPassword = false;
            this.bnftxtDescripcion.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtDescripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtDescripcion.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtDescripcion.LineThickness = 3;
            this.bnftxtDescripcion.Location = new System.Drawing.Point(346, 21);
            this.bnftxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtDescripcion.Name = "bnftxtDescripcion";
            this.bnftxtDescripcion.Size = new System.Drawing.Size(379, 33);
            this.bnftxtDescripcion.TabIndex = 1;
            this.bnftxtDescripcion.Text = "Descripción";
            this.bnftxtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bnftxtCodigo
            // 
            this.bnftxtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bnftxtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bnftxtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnftxtCodigo.HintForeColor = System.Drawing.Color.Empty;
            this.bnftxtCodigo.HintText = "";
            this.bnftxtCodigo.isPassword = false;
            this.bnftxtCodigo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtCodigo.LineIdleColor = System.Drawing.Color.Gray;
            this.bnftxtCodigo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnftxtCodigo.LineThickness = 3;
            this.bnftxtCodigo.Location = new System.Drawing.Point(20, 21);
            this.bnftxtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.bnftxtCodigo.Name = "bnftxtCodigo";
            this.bnftxtCodigo.Size = new System.Drawing.Size(289, 33);
            this.bnftxtCodigo.TabIndex = 0;
            this.bnftxtCodigo.Text = "Código de producto";
            this.bnftxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.bnfCstgrInventario;
            // 
            // chkCodigoProducto
            // 
            this.chkCodigoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkCodigoProducto.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkCodigoProducto.Checked = false;
            this.chkCodigoProducto.CheckedOnColor = System.Drawing.Color.MediumPurple;
            this.chkCodigoProducto.ForeColor = System.Drawing.Color.White;
            this.chkCodigoProducto.Location = new System.Drawing.Point(313, 28);
            this.chkCodigoProducto.Name = "chkCodigoProducto";
            this.chkCodigoProducto.Size = new System.Drawing.Size(20, 20);
            this.chkCodigoProducto.TabIndex = 4;
            this.chkCodigoProducto.OnChange += new System.EventHandler(this.chkCodigoProducto_OnChange);
            // 
            // chkDescripcion
            // 
            this.chkDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkDescripcion.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkDescripcion.Checked = false;
            this.chkDescripcion.CheckedOnColor = System.Drawing.Color.MediumPurple;
            this.chkDescripcion.ForeColor = System.Drawing.Color.White;
            this.chkDescripcion.Location = new System.Drawing.Point(732, 28);
            this.chkDescripcion.Name = "chkDescripcion";
            this.chkDescripcion.Size = new System.Drawing.Size(20, 20);
            this.chkDescripcion.TabIndex = 5;
            this.chkDescripcion.OnChange += new System.EventHandler(this.chkDescripcion_OnChange);
            // 
            // chkCategoria
            // 
            this.chkCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkCategoria.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkCategoria.Checked = false;
            this.chkCategoria.CheckedOnColor = System.Drawing.Color.MediumPurple;
            this.chkCategoria.ForeColor = System.Drawing.Color.White;
            this.chkCategoria.Location = new System.Drawing.Point(1053, 28);
            this.chkCategoria.Name = "chkCategoria";
            this.chkCategoria.Size = new System.Drawing.Size(20, 20);
            this.chkCategoria.TabIndex = 6;
            this.chkCategoria.OnChange += new System.EventHandler(this.chkCategoria_OnChange);
            // 
            // chkUnidades
            // 
            this.chkUnidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkUnidades.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkUnidades.Checked = false;
            this.chkUnidades.CheckedOnColor = System.Drawing.Color.MediumPurple;
            this.chkUnidades.ForeColor = System.Drawing.Color.White;
            this.chkUnidades.Location = new System.Drawing.Point(190, 70);
            this.chkUnidades.Name = "chkUnidades";
            this.chkUnidades.Size = new System.Drawing.Size(20, 20);
            this.chkUnidades.TabIndex = 7;
            this.chkUnidades.OnChange += new System.EventHandler(this.chkUnidades_OnChange);
            // 
            // PantallaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.bnfCstgrInventario);
            this.Controls.Add(this.pnlOpciones);
            this.Name = "PantallaInventario";
            this.Size = new System.Drawing.Size(1396, 750);
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnfCstgrInventario)).EndInit();
            this.grpBusqueda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton btnMtlAgregarProducto;
        private Bunifu.Framework.UI.BunifuTileButton btnMtlEliminarProducto;
        private System.Windows.Forms.Panel pnlOpciones;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bnfCstgrInventario;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtUnidadesDisponibles;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtCategoria;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtDescripcion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bnftxtCodigo;
        private Bunifu.Framework.UI.BunifuTileButton btnMtlModificarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCheckbox chkUnidades;
        private Bunifu.Framework.UI.BunifuCheckbox chkCategoria;
        private Bunifu.Framework.UI.BunifuCheckbox chkDescripcion;
        private Bunifu.Framework.UI.BunifuCheckbox chkCodigoProducto;
    }
}
