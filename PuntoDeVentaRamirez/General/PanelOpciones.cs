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
    public partial class PanelOpciones : UserControl
    {
        public PanelOpciones()
        {
            InitializeComponent();
        }

        private void PanelOpciones_Load(object sender, EventArgs e)
        {
            pnlPantallas.Controls.Clear();
            label1.Text = ConexionesAVentas.RecuperarNombreVendedor();
            PantallaPuntoDeVenta pVenta = new PantallaPuntoDeVenta();
            pnlPantallas.Controls.Add(pVenta);
            pVenta.Location = new Point(0, 0);
            bnfFltBtnPuntoDeVenta.Normalcolor = Color.Goldenrod;


        }

        private void bnfFltBtnPuntoDeVenta_Click(object sender, EventArgs e)
        {
            pnlPantallas.Controls.Clear();
            pnlPantallas.Controls.Add(new PantallaPuntoDeVenta());
    
        }

        private void bnfFltbtnInventario_Click(object sender, EventArgs e)
        {
            pnlPantallas.Controls.Clear();
            pnlPantallas.Controls.Add(new PantallaInventario());
          

        }

        private void bnfFltbtnGastos_Click(object sender, EventArgs e)
        {
            pnlPantallas.Controls.Clear();
            pnlPantallas.Controls.Add(new PantallaGastos());
      
        }

        private void pnlPantallas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bnfFltbtnReportes_Click(object sender, EventArgs e)
        {
            pnlPantallas.Controls.Clear();
            pnlPantallas.Controls.Add(new PantallaReportes());
            
        }

        private void bnfbtnMinimizar_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void bnfBtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
    }
}
