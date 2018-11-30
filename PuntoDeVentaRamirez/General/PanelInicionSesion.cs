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
    public partial class PanelInicionSesion : UserControl
    {
        public PanelInicionSesion()
        {
            InitializeComponent();
        }

        private void bnfFlBtnEntrar_Click(object sender, EventArgs e)
        {
            Form1.LimpiarPanel();
            Form1.CrearPanelOpciones(); 
                 
        }
    }
}
