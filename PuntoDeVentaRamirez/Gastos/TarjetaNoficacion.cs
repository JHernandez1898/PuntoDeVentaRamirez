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
    public partial class TarjetaNoficacion : UserControl
    {
        public TarjetaNoficacion(string strDescripcion, DateTime dtmFechaLimite, double Monto)
        {
            InitializeComponent();
            label1.Text = dtmFechaLimite.ToString("yyyy/MM/dd");
            label2.Text = strDescripcion;
            label3.Text = Monto.ToString();
        }

        
        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
