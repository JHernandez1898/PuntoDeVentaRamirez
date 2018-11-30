namespace PuntoDeVentaRamirez
{
    partial class PantallaReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 56D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 52D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 15D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell1 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(11D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(12D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaReportes));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bnfFechaVentasInferior = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bnfFechaVentasSuperior = new Bunifu.Framework.UI.BunifuDatepicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnfbtnGenerarVentas = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnfbtnGenerarGastos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfFechaGastosSuperior = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bnfFechaGastosInferior = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtVentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(830, 68);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(416, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chtVentas
            // 
            chartArea2.Name = "ChartArea1";
            this.chtVentas.ChartAreas.Add(chartArea2);
            legendCell1.Name = "Enero";
            legendItem1.Cells.Add(legendCell1);
            legend2.CustomItems.Add(legendItem1);
            legend2.Name = "Legend1";
            this.chtVentas.Legends.Add(legend2);
            this.chtVentas.Location = new System.Drawing.Point(43, 80);
            this.chtVentas.Name = "chtVentas";
            this.chtVentas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Ventas mensuales";
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            series2.Points.Add(dataPoint13);
            series2.Points.Add(dataPoint14);
            series2.Points.Add(dataPoint15);
            series2.XValueMember = "Enero";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chtVentas.Series.Add(series2);
            this.chtVentas.Size = new System.Drawing.Size(590, 300);
            this.chtVentas.TabIndex = 1;
            this.chtVentas.Text = "Ventas mensuales";
            // 
            // bnfFechaVentasInferior
            // 
            this.bnfFechaVentasInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFechaVentasInferior.BorderRadius = 0;
            this.bnfFechaVentasInferior.ForeColor = System.Drawing.Color.White;
            this.bnfFechaVentasInferior.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bnfFechaVentasInferior.FormatCustom = null;
            this.bnfFechaVentasInferior.Location = new System.Drawing.Point(18, 36);
            this.bnfFechaVentasInferior.Name = "bnfFechaVentasInferior";
            this.bnfFechaVentasInferior.Size = new System.Drawing.Size(231, 36);
            this.bnfFechaVentasInferior.TabIndex = 5;
            this.bnfFechaVentasInferior.Value = new System.DateTime(2018, 11, 12, 22, 7, 37, 565);
            // 
            // bnfFechaVentasSuperior
            // 
            this.bnfFechaVentasSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFechaVentasSuperior.BorderRadius = 0;
            this.bnfFechaVentasSuperior.ForeColor = System.Drawing.Color.White;
            this.bnfFechaVentasSuperior.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bnfFechaVentasSuperior.FormatCustom = null;
            this.bnfFechaVentasSuperior.Location = new System.Drawing.Point(283, 36);
            this.bnfFechaVentasSuperior.Name = "bnfFechaVentasSuperior";
            this.bnfFechaVentasSuperior.Size = new System.Drawing.Size(231, 36);
            this.bnfFechaVentasSuperior.TabIndex = 6;
            this.bnfFechaVentasSuperior.Value = new System.DateTime(2018, 11, 12, 22, 7, 37, 565);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnfbtnGenerarVentas);
            this.groupBox1.Controls.Add(this.bnfFechaVentasSuperior);
            this.groupBox1.Controls.Add(this.bnfFechaVentasInferior);
            this.groupBox1.Location = new System.Drawing.Point(67, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes de ventas";
            // 
            // bnfbtnGenerarVentas
            // 
            this.bnfbtnGenerarVentas.ActiveBorderThickness = 1;
            this.bnfbtnGenerarVentas.ActiveCornerRadius = 20;
            this.bnfbtnGenerarVentas.ActiveFillColor = System.Drawing.Color.DarkGray;
            this.bnfbtnGenerarVentas.ActiveForecolor = System.Drawing.Color.White;
            this.bnfbtnGenerarVentas.ActiveLineColor = System.Drawing.Color.DarkGray;
            this.bnfbtnGenerarVentas.BackColor = System.Drawing.SystemColors.Control;
            this.bnfbtnGenerarVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfbtnGenerarVentas.BackgroundImage")));
            this.bnfbtnGenerarVentas.ButtonText = "Generar";
            this.bnfbtnGenerarVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfbtnGenerarVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfbtnGenerarVentas.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGenerarVentas.IdleBorderThickness = 1;
            this.bnfbtnGenerarVentas.IdleCornerRadius = 20;
            this.bnfbtnGenerarVentas.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfbtnGenerarVentas.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bnfbtnGenerarVentas.IdleLineColor = System.Drawing.Color.Transparent;
            this.bnfbtnGenerarVentas.Location = new System.Drawing.Point(177, 80);
            this.bnfbtnGenerarVentas.Margin = new System.Windows.Forms.Padding(5);
            this.bnfbtnGenerarVentas.Name = "bnfbtnGenerarVentas";
            this.bnfbtnGenerarVentas.Size = new System.Drawing.Size(181, 41);
            this.bnfbtnGenerarVentas.TabIndex = 9;
            this.bnfbtnGenerarVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfbtnGenerarVentas.Click += new System.EventHandler(this.bnfbtnGenerarVentas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bnfbtnGenerarGastos);
            this.groupBox2.Controls.Add(this.bnfFechaGastosSuperior);
            this.groupBox2.Controls.Add(this.bnfFechaGastosInferior);
            this.groupBox2.Location = new System.Drawing.Point(730, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 141);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reportes de gastos";
            // 
            // bnfbtnGenerarGastos
            // 
            this.bnfbtnGenerarGastos.ActiveBorderThickness = 1;
            this.bnfbtnGenerarGastos.ActiveCornerRadius = 20;
            this.bnfbtnGenerarGastos.ActiveFillColor = System.Drawing.Color.DarkGray;
            this.bnfbtnGenerarGastos.ActiveForecolor = System.Drawing.Color.White;
            this.bnfbtnGenerarGastos.ActiveLineColor = System.Drawing.Color.DarkGray;
            this.bnfbtnGenerarGastos.BackColor = System.Drawing.SystemColors.Control;
            this.bnfbtnGenerarGastos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfbtnGenerarGastos.BackgroundImage")));
            this.bnfbtnGenerarGastos.ButtonText = "Generar";
            this.bnfbtnGenerarGastos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfbtnGenerarGastos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfbtnGenerarGastos.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGenerarGastos.IdleBorderThickness = 1;
            this.bnfbtnGenerarGastos.IdleCornerRadius = 20;
            this.bnfbtnGenerarGastos.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfbtnGenerarGastos.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bnfbtnGenerarGastos.IdleLineColor = System.Drawing.Color.Transparent;
            this.bnfbtnGenerarGastos.Location = new System.Drawing.Point(188, 80);
            this.bnfbtnGenerarGastos.Margin = new System.Windows.Forms.Padding(5);
            this.bnfbtnGenerarGastos.Name = "bnfbtnGenerarGastos";
            this.bnfbtnGenerarGastos.Size = new System.Drawing.Size(181, 41);
            this.bnfbtnGenerarGastos.TabIndex = 11;
            this.bnfbtnGenerarGastos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnfFechaGastosSuperior
            // 
            this.bnfFechaGastosSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFechaGastosSuperior.BorderRadius = 0;
            this.bnfFechaGastosSuperior.ForeColor = System.Drawing.Color.White;
            this.bnfFechaGastosSuperior.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bnfFechaGastosSuperior.FormatCustom = null;
            this.bnfFechaGastosSuperior.Location = new System.Drawing.Point(297, 36);
            this.bnfFechaGastosSuperior.Name = "bnfFechaGastosSuperior";
            this.bnfFechaGastosSuperior.Size = new System.Drawing.Size(231, 36);
            this.bnfFechaGastosSuperior.TabIndex = 10;
            this.bnfFechaGastosSuperior.Value = new System.DateTime(2018, 11, 12, 22, 7, 37, 565);
            // 
            // bnfFechaGastosInferior
            // 
            this.bnfFechaGastosInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(101)))));
            this.bnfFechaGastosInferior.BorderRadius = 0;
            this.bnfFechaGastosInferior.ForeColor = System.Drawing.Color.White;
            this.bnfFechaGastosInferior.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bnfFechaGastosInferior.FormatCustom = null;
            this.bnfFechaGastosInferior.Location = new System.Drawing.Point(32, 36);
            this.bnfFechaGastosInferior.Name = "bnfFechaGastosInferior";
            this.bnfFechaGastosInferior.Size = new System.Drawing.Size(231, 36);
            this.bnfFechaGastosInferior.TabIndex = 9;
            this.bnfFechaGastosInferior.Value = new System.DateTime(2018, 11, 12, 22, 7, 37, 565);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(222, 48);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(257, 20);
            this.lblVentas.TabIndex = 4;
            this.lblVentas.Text = "Ventas mensuales de este año";
            // 
            // PantallaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chtVentas);
            this.Controls.Add(this.chart1);
            this.Name = "PantallaReportes";
            this.Size = new System.Drawing.Size(1350, 689);
            this.Load += new System.EventHandler(this.PantallaReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtVentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtVentas;
        private Bunifu.Framework.UI.BunifuDatepicker bnfFechaVentasInferior;
        private Bunifu.Framework.UI.BunifuDatepicker bnfFechaVentasSuperior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfbtnGenerarVentas;
        private Bunifu.Framework.UI.BunifuDatepicker bnfFechaGastosSuperior;
        private Bunifu.Framework.UI.BunifuDatepicker bnfFechaGastosInferior;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfbtnGenerarGastos;
        private System.Windows.Forms.Label lblVentas;
    }
}
