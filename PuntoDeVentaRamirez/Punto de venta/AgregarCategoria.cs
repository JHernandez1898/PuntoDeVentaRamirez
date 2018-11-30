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
    public partial class AgregarCategoria : UserControl
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void bnfFLbtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionesAVentas.AgregarCategoria(bnftxtCategoria.Text);
                MessageBox.Show("Se agrego correctamente la categoria");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   
    }
}
