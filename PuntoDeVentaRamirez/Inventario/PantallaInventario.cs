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
    public partial class PantallaInventario : UserControl
    {
        public PantallaInventario()
        {
            InitializeComponent();
            CargarProductos();
        }

        public string Filtrar()
        {
            string strFiltro = "";
            if(chkCategoria.Checked || chkCodigoProducto.Checked || chkDescripcion.Checked || chkUnidades.Checked)
            {
                strFiltro += " WHERE ";
                if(chkCategoria.Checked)                
                    strFiltro += " CATEGORIA.Descripcion LIKE '%" + bnftxtCategoria.Text + "%'";
                if (chkCodigoProducto.Checked)
                    strFiltro += " CodigoProducto = " + int.Parse(bnftxtCodigo.Text);
                if (chkDescripcion.Checked)
                    strFiltro += " PRODUCTO.Descripcion LIKE '%" + bnftxtDescripcion.Text + "%'";
                if (chkUnidades.Checked)
                    strFiltro += " UnidadesDisponibles >= " + short.Parse(bnftxtUnidadesDisponibles.Text);
            }
            return strFiltro;
        }

        public void CargarProductos()
        {
           try
            {
                bnfCstgrInventario.Rows.Clear();
                foreach (Producto nProduct in ClasesBD.ConexionesAInventario.FiltrarProductos(Filtrar()))
                {
                    bnfCstgrInventario.Rows.Add(nProduct.IdProducto.ToString(), nProduct.Categoria, nProduct.Descripcion, nProduct.PrecioUnitario.ToString("C"), nProduct.UnidadesDisponibles.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMtlAgregarProducto_Click(object sender, EventArgs e)
        {
            SubVentana nVentana = new SubVentana(new AñadirNuevoProducto(), "Agregar nuevo producto a inventario");
            nVentana.Show();
        }

        private void btnMtlModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nProducto = new Producto();
                DataGridViewRow RenglonSeleccionado = bnfCstgrInventario.CurrentRow;
                if (RenglonSeleccionado == null)
                    MessageBox.Show("Seleccione un renglón de la tabla.");
                else
                {
                    nProducto.IdProducto = int.Parse(RenglonSeleccionado.Cells[0].Value.ToString());                    
                    nProducto.Descripcion = RenglonSeleccionado.Cells[2].Value.ToString();                                        
                    SubVentana nVentana = new SubVentana(new PanelModificarProducto(nProducto), "Modificar Producto");
                    nVentana.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void chkCodigoProducto_OnChange(object sender, EventArgs e)
        {
            PrepararFiltro(chkCodigoProducto);
        }

        private void chkDescripcion_OnChange(object sender, EventArgs e)
        {
            PrepararFiltro(chkDescripcion);
        }

        private void chkCategoria_OnChange(object sender, EventArgs e)
        {
            PrepararFiltro(chkCategoria);
        }

        private void chkUnidades_OnChange(object sender, EventArgs e)
        {
            PrepararFiltro(chkUnidades);
        }

        private void PrepararFiltro(Bunifu.Framework.UI.BunifuCheckbox unCheckbox)
        {
            if (unCheckbox.Checked)            
                DesactivarResto(unCheckbox);            
            else            
                RestaurarTextos();            
            CargarProductos();
        }

        private void RestaurarTextos()
        {
            bnftxtCodigo.Text = "Código de producto";
            bnftxtUnidadesDisponibles.Text = "Unidades disponibles";
            bnftxtDescripcion.Text = "Descripción";
            bnftxtCategoria.Text = "Categoría";
        }

        private void DesactivarResto(Bunifu.Framework.UI.BunifuCheckbox unCheckbox)
        {
            foreach (Control unControl in grpBusqueda.Controls)
            {
                if (unControl is Bunifu.Framework.UI.BunifuCheckbox)
                {
                    if (unControl.Name != unCheckbox.Name)
                    {
                        Bunifu.Framework.UI.BunifuCheckbox previoCheckBox = (Bunifu.Framework.UI.BunifuCheckbox) unControl;
                        previoCheckBox.Checked = false;
                    }
                }
            }
        }

        private void btnMtlEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nProducto = new Producto();
                DataGridViewRow RenglonSeleccionado = bnfCstgrInventario.CurrentRow;          
                if (RenglonSeleccionado == null)
                    MessageBox.Show("Seleccione un renglón de la tabla.");
                else
                {
                    nProducto.IdProducto = int.Parse(RenglonSeleccionado.Cells[0].Value.ToString());                    
                    nProducto.Categoria = RenglonSeleccionado.Cells[1].Value.ToString();
                    nProducto.Descripcion = RenglonSeleccionado.Cells[2].Value.ToString();
                    nProducto.PrecioUnitario = double.Parse(RenglonSeleccionado.Cells[3].Value.ToString().Substring(1));
                    nProducto.UnidadesDisponibles = int.Parse(RenglonSeleccionado.Cells[4].Value.ToString());

                    DialogResult dlConfirmación = MessageBox.Show(nProducto.ToString(), "¿Desea eliminar este producto?", MessageBoxButtons.OKCancel);
                    if (dlConfirmación == DialogResult.OK)
                    {
                        ClasesBD.ConexionesAInventario.EliminarProducto(nProducto);
                        MessageBox.Show("El producto fue eliminado con exito", "Eliminación exitosa", MessageBoxButtons.OK);                        
                    }
                    CargarProductos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PantallaInventario_Enter(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void PantallaInventario_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
