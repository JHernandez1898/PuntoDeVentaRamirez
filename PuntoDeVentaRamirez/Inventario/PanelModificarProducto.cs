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
    public partial class PanelModificarProducto : UserControl
    {
        public PanelModificarProducto(Producto unProducto)
        {
            InitializeComponent();
            CargarCategorias();
            bnfMtltxtCodigo.Text = unProducto.IdProducto.ToString();
            bnfMtltxtDescripcion.Text = unProducto.Descripcion;                        
            bnfMtltxtCodigo.Enabled = false;            
        }

        private void CargarCategorias()
        {
            bnfDrpdCategoria.Clear();
            try
            {
                List<string> lstCategorias = new List<string>();
                lstCategorias = ConexionesAVentas.MostrarCategorias();
                foreach (string strCategoria in lstCategorias)
                    bnfDrpdCategoria.AddItem(strCategoria);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void bnfFLbtnModificar_Click(object sender, EventArgs e)
        {
            Producto nProducto = new Producto();
            try
            {
                nProducto.IdProducto = int.Parse(bnfMtltxtCodigo.Text);
                nProducto.Categoria = bnfDrpdCategoria.selectedValue;
                nProducto.Descripcion = bnfMtltxtDescripcion.Text;
                nProducto.PrecioUnitario = double.Parse(bnfMtltxtPrecio.Text);
                nProducto.UnidadesDisponibles = int.Parse(bnfmtxtUnidadesDisponibles.Text);
                DialogResult dlConfirmación = MessageBox.Show(nProducto.ToString(), "Datos del producto a modificar", MessageBoxButtons.OKCancel);
                if (dlConfirmación == DialogResult.OK)
                {
                    ClasesBD.ConexionesAInventario.ModificarProducto(nProducto);
                    MessageBox.Show("El producto fue modificado con exito", "Modificación exitosa", MessageBoxButtons.OK);     
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
