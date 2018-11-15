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
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bnfTlbtnNuevoProducto_Click(object sender, EventArgs e)
        {
            SubVentana nVentana = new SubVentana(new AñadirNuevoProducto(),"Agregar nuevo producto a inventario");
            nVentana.Show();
        }
    }
}
