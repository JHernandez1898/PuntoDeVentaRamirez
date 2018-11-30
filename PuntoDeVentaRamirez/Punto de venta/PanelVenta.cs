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
    public partial class PanelVenta : UserControl
    {
        public PanelVenta()
        {
            InitializeComponent();
        }

        private void bnftxtCodigo_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void bnftxtCodigo_MouseEnter(object sender, EventArgs e)
        {
            bnftxtDescripcion.text = " ";
        }
    }
}
