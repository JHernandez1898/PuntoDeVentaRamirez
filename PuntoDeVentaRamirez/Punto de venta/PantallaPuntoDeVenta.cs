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
    public partial class PantallaPuntoDeVenta : UserControl
    {
        public PantallaPuntoDeVenta()
        {
            InitializeComponent();
            pnlVenta.Controls.Add(new PanelVenta());
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bnfTlbtnNuevoProducto_Click(object sender, EventArgs e)
        {
            SubVentana nVentana = new SubVentana(new AñadirNuevoProducto(),"Agregar nuevo producto a inventario");
            nVentana.Show();
        }

        private void PantallaPuntoDeVenta_Load(object sender, EventArgs e)
        {

        }

        private void bnfTlbtnNuevoPaquete_Click(object sender, EventArgs e)
        {
            
            pnlVenta.Controls.Clear();
            pnlVenta.Controls.Add(new CrearPaquete());
        }
        private void bnfFltbtnHome_Click(object sender, EventArgs e)
        {
            pnlVenta.Controls.Clear();
            pnlVenta.Controls.Add(new PanelVenta());
        }
        private void bnfTlbtnAgregarPaquete_Click(object sender, EventArgs e)
        {
            SubVentana nVentana = new SubVentana(new PanelAgregarPaquete(), "Agregar paquete");
            nVentana.Show();
        }
    }
}
