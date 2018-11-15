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
            PantallaPuntoDeVenta pVenta = new PantallaPuntoDeVenta();
            pnlPantallas.Controls.Add(pVenta);
            pVenta.Location = new Point(0, 0);
            bnfFltBtnPuntoDeVenta.Normalcolor = Color.FromArgb(162, 169, 168);


        }

        private void bnfFltBtnPuntoDeVenta_Click(object sender, EventArgs e)
        {
            pnlPantallas.Controls.Clear();
            pnlPantallas.Controls.Add(new PantallaPuntoDeVenta());
            bnfFltBtnPuntoDeVenta.Normalcolor = Color.FromArgb(162, 169, 168);
            bnfFltbtnInventario.Normalcolor = Color.FromArgb(15, 121, 119);
            bnfFltbtnGastos.Normalcolor = Color.FromArgb(15, 121, 119);
            bnfFltbtnReportes.Normalcolor = Color.FromArgb(15, 121, 119);
        }

        private void bnfFltbtnInventario_Click(object sender, EventArgs e)
        {
            pnlPantallas.Controls.Clear();
            pnlPantallas.Controls.Add(new PantallaInventario());
            bnfFltBtnPuntoDeVenta.Normalcolor = Color.FromArgb(15, 121, 119);
            bnfFltbtnInventario.Normalcolor = Color.FromArgb(162, 169, 168);
            bnfFltbtnGastos.Normalcolor = Color.FromArgb(15, 121, 119);
            bnfFltbtnReportes.Normalcolor = Color.FromArgb(15, 121, 119);


        }

        private void bnfFltbtnGastos_Click(object sender, EventArgs e)
        {
            pnlPantallas.Controls.Clear();
            pnlPantallas.Controls.Add(new PantallaGastos());
            bnfFltBtnPuntoDeVenta.Normalcolor = Color.FromArgb(15, 121, 119);
            bnfFltbtnInventario.Normalcolor = Color.FromArgb(15, 121, 119);
            bnfFltbtnGastos.Normalcolor = Color.FromArgb(162, 169, 168);
            bnfFltbtnReportes.Normalcolor = Color.FromArgb(15, 121, 119);
        }

        private void pnlPantallas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bnfFltbtnReportes_Click(object sender, EventArgs e)
        {
            pnlPantallas.Controls.Clear();
            pnlPantallas.Controls.Add(new PantallaReportes());
            bnfFltBtnPuntoDeVenta.Normalcolor = Color.FromArgb(15, 121, 119);
            bnfFltbtnInventario.Normalcolor = Color.FromArgb(15, 121, 119);
            bnfFltbtnGastos.Normalcolor = Color.FromArgb(15, 121, 119);
            bnfFltbtnReportes.Normalcolor = Color.FromArgb(162, 169, 168);
        }
    }
}
