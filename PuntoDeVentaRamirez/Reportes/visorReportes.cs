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
            try
            {
                nuevoReporte.SetDataSource(ClasesBD.ConexionesAReportes.ConsultarVentasPorFechas(fechaInicial,fechaFinal));
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, "Fallo en la creación del reporte.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            crvVisorReportes.ReportSource = nuevoReporte;
        }
    }
}
