﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentaRamirez
{
    public partial class PantallaReportes : UserControl
    {        
        public PantallaReportes()
        {
            InitializeComponent();
        }

        private void PantallaReportes_Load(object sender, EventArgs e)
        {            
            bnfFechaInferior.Value = DateTime.Now;
            bnfFechaSuperior.Value = DateTime.Now;
            AsignarReporteVentas(bnfFechaInferior.Value, bnfFechaSuperior.Value);
        }

        private void bnfbtnGenerarVentas_Click(object sender, EventArgs e)
        {
            try
            {                
                crvVisorReportes.Hide();                                
                AsignarReporteVentas(bnfFechaInferior.Value, bnfFechaSuperior.Value);
                crvVisorReportes.Show();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, "Fallo en la creación del reporte.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error no esperado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AsignarReporteVentas(DateTime fechaInicial, DateTime fechaFinal)
        {
            Reportes.ReporteVentas nuevoReporte = new Reportes.ReporteVentas();
            nuevoReporte.SetDataSource(ClasesBD.ConexionesAReportes.ConsultarVentasPorFechas(fechaInicial, fechaFinal));
            nuevoReporte.SetParameterValue("Fecha Inicial", fechaInicial);
            nuevoReporte.SetParameterValue("Fecha Final", fechaFinal);
            crvVisorReportes.ReportSource = nuevoReporte;
        }

        private void btnGenerarReportePedidos_Click(object sender, EventArgs e)
        {
            Reportes.ReportePedidos nuevoReporte = new Reportes.ReportePedidos();
            nuevoReporte.SetDataSource(ClasesBD.ConexionesAReportes.ConsultarPedidosPagadosPorFechas(bnfFechaInferior.Value, bnfFechaSuperior.Value));
            nuevoReporte.SetParameterValue("Fecha Inicial", bnfFechaInferior.Value);
            nuevoReporte.SetParameterValue("Fecha Final", bnfFechaSuperior.Value);
            crvVisorReportes.ReportSource = nuevoReporte;
        }

        private void btnGenerarReporteGastos_Click(object sender, EventArgs e)
        {
            Reportes.ReporteGastos nuevoReporte = new Reportes.ReporteGastos();
            nuevoReporte.SetDataSource(ClasesBD.ConexionesAReportes.ConsultarGastosPorFechas(bnfFechaInferior.Value, bnfFechaSuperior.Value));
            nuevoReporte.SetParameterValue("Fecha Inicial", bnfFechaInferior.Value);
            nuevoReporte.SetParameterValue("Fecha Final", bnfFechaSuperior.Value);
            crvVisorReportes.ReportSource = nuevoReporte;
        }
    }
}
