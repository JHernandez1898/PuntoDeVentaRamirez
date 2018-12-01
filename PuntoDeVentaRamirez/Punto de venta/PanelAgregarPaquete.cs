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
    public partial class PanelAgregarPaquete : UserControl
    {
        public PanelAgregarPaquete()
        {
            InitializeComponent();
        }

        private void PanelAgregarPaquete_Load(object sender, EventArgs e)
        {
            CargarPaquetes("");
        }
        public void CargarPaquetes(string strDescripcion)
        {
            bnfCstgridPaquetes.Rows.Clear();
            List<Paquete> lstPaquete = ConexionesAVentas.MostrarPaquetes(strDescripcion);
            foreach(Paquete nPaquete in lstPaquete)
            {
                bnfCstgridPaquetes.Rows.Add(nPaquete.IdPaquete, nPaquete.Descripcion);
            }
            
        }

        private void bnfMtltxtDescripcion_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarPaquetes(bnfMtltxtDescripcion.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarPaquete_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow RenglonSeleccionado = bnfCstgridPaquetes.CurrentRow;
                if (RenglonSeleccionado == null)
                    MessageBox.Show("Seleccione un renglón del dataGridView");
                else
                {
                    int iDProducto = int.Parse(RenglonSeleccionado.Cells[0].Value.ToString());
                    List<Producto> lstProductos = ConexionesAVentas.MostrarProductosPaquete(iDProducto);
                    PanelVenta.CargarPaquete(lstProductos);

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }
    }
}
