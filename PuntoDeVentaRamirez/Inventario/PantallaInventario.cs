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
            if (chkCategoria.Checked || chkCodigoProducto.Checked || chkDescripcion.Checked || chkUnidades.Checked)
            {
                strFiltro += " WHERE ";
                if (chkCategoria.Checked)
                {
                    strFiltro += " CATEGORIA.Descripcion LIKE '%" + bnftxtCategoria.Text + "%'";
                }
                if (chkCodigoProducto.Checked)
                {
                    if (chkCategoria.Checked)                    
                        strFiltro += " AND ";                    
                    strFiltro += " CodigoProducto = " + int.Parse(bnftxtCodigo.Text);
                }
                if (chkDescripcion.Checked)
                {
                    if (chkCategoria.Checked || chkCodigoProducto.Checked)                    
                        strFiltro += " AND ";                    
                    strFiltro += " PRODUCTO.Descripcion LIKE '%" + bnftxtDescripcion.Text + "%'";
                }
                if (chkUnidades.Checked)
                {
                    if (chkCategoria.Checked || chkCodigoProducto.Checked || chkDescripcion.Checked)                    
                        strFiltro += " AND ";
                    strFiltro += " UnidadesDisponibles >= " + short.Parse(bnftxtUnidadesDisponibles.Text);
                } 
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
                //MessageBox.Show(ex.Message);
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
            PrepararFiltro(chkCodigoProducto, bnftxtCodigo, "Código de producto");
        }

        private void chkDescripcion_OnChange(object sender, EventArgs e)
        {
            PrepararFiltro(chkDescripcion, bnftxtDescripcion, "Descripción");
        }

        private void chkCategoria_OnChange(object sender, EventArgs e)
        {
            PrepararFiltro(chkCategoria, bnftxtCategoria, "Categoría");
        }

        private void chkUnidades_OnChange(object sender, EventArgs e)
        {
            PrepararFiltro(chkUnidades, bnftxtUnidadesDisponibles, "Unidades disponibles");
        }

        private void PrepararFiltro(Bunifu.Framework.UI.BunifuCheckbox unCheckbox, Bunifu.Framework.UI.BunifuMaterialTextbox unTextBox, string strMensaje)
        {
            if (!unCheckbox.Checked)
                unTextBox.Text = strMensaje;
            CargarProductos();
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

        private void bnftxtCodigo_OnValueChanged(object sender, EventArgs e)
        {
            if (chkCodigoProducto.Checked)            
                CargarProductos();            
        }

        private void bnftxtDescripcion_OnValueChanged(object sender, EventArgs e)
        {
            if (chkDescripcion.Checked)
                CargarProductos();
        }

        private void bnftxtCategoria_OnValueChanged(object sender, EventArgs e)
        {
            if (chkCategoria.Checked)
                CargarProductos();
        }

        private void bnftxtUnidadesDisponibles_OnValueChanged(object sender, EventArgs e)
        {
            if (chkUnidades.Checked)
                CargarProductos();
        }
    }
}
