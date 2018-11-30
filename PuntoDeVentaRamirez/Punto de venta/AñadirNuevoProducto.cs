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
    public partial class AñadirNuevoProducto : UserControl
    {
        public AñadirNuevoProducto()
        {
            InitializeComponent();
            CargarCategorias();

        }

        private void bnfFLbtnAgregar_Click(object sender, EventArgs e)
        {
            Producto nProducto = new Producto();
            try
            {
                nProducto.Categoria = bnfDrpdCategoria.selectedValue;
                nProducto.Descripcion = bnfMtltxtDescripcion.Text;
                nProducto.PrecioUnitario = double.Parse(bnfMtltxtPrecio.Text);
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void CargarCategorias()
        {
            try
            {
                List<string> lstCategorias = new List<string>();
                lstCategorias = ConexionesAVentas.MostrarCategorias();
                foreach (string strCategoria in lstCategorias)
                    bnfDrpdCategoria.AddItem(strCategoria);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
