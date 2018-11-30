using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentaRamirez
{
    public partial class SubVentana : Form
    {

        public SubVentana(UserControl ventanita, string titulo)
        {
            InitializeComponent();
            pnlVentanita.Controls.Add(ventanita);
            lblTitulo.Text = titulo;
        }

        private void bnfBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnfbtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SubVentana_Load(object sender, EventArgs e)
        {
            
        }
    }
}
