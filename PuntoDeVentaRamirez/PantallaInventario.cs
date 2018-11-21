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
    public partial class PantallaInventario : UserControl
    {
        public PantallaInventario()
        {
            InitializeComponent();
        }

      

        private void btnMtlAgregarProducto_Click(object sender, EventArgs e)
        {
            SubVentana nVentana = new SubVentana(new AñadirNuevoProducto(), "Agregar nuevo producto a inventario");
            nVentana.Show();
        }

        private void btnMtlModificarProducto_Click(object sender, EventArgs e)
        {
            SubVentana nVentana = new SubVentana(new PanelModificarProducto(), "Modificar Producto");
            nVentana.Show();
        }
    }
}
