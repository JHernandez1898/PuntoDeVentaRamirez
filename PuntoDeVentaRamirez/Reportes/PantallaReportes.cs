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
            CargarVentasMensualesDelAño();
        }

        private void bnfbtnGenerarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                visorReporte = new Reportes.visorReportes();
                visorReporte.AsignarReporteVentas(bnfFechaVentasInferior.Value, bnfFechaVentasSuperior.Value);
                visorReporte.Show();
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

        private void CargarVentasMensualesDelAño()
        {

        }
    }
}
