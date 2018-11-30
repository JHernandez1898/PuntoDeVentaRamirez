using System;
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
        Reportes.visorReportes visorReporte;
        public PantallaReportes()
        {
            InitializeComponent();
        }

        private void PantallaReportes_Load(object sender, EventArgs e)
        {

        }

        private void bnfbtnGenerarVentas_Click(object sender, EventArgs e)
        {
            visorReporte = new Reportes.visorReportes();
            visorReporte.AsignarReporteVentas(bnfFechaVentasInferior.Value, bnfFechaVentasSuperior.Value);
            visorReporte.Show();
        }
    }
}
