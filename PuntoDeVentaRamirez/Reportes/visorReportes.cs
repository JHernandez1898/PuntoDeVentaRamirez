using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentaRamirez.Reportes
{
    public partial class visorReportes : Form
    {
        public visorReportes()
        {
            InitializeComponent();
        }

        public void AsignarReporteVentas(DateTime fechaInicial, DateTime fechaFinal)
        {            
            ReporteVentas nuevoReporte = new ReporteVentas();
            nuevoReporte.SetDataSource(ClasesBD.ConexionesAReportes.ConsultarVentasPorFechas(fechaInicial, fechaFinal));
            nuevoReporte.SetParameterValue("Fecha Inicial", fechaInicial);
            nuevoReporte.SetParameterValue("Fecha Final", fechaFinal);
            crvVisorReportes.ReportSource = nuevoReporte;            
        }
    }
}
