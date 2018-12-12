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
                nProducto.UnidadesDisponibles = int.Parse(bnftxtUnidadesDisponibles.Text);
                DialogResult dlConfirmación = MessageBox.Show(nProducto.ToString(), "Datos del producto a agregar",MessageBoxButtons.OKCancel);
                if(dlConfirmación == DialogResult.OK)
                {
                    ConexionesAVentas.AgregarProducto(nProducto);
                    MessageBox.Show("El producto fue agregado con exito", "Registro Exitoso",MessageBoxButtons.OK);
                    LimpiarCampos();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void CargarCategorias()
        {
            bnfDrpdCategoria.Clear();
            try
            {
                List<string> lstCategorias = new List<string>();
                lstCategorias = ConexionesAVentas.MostrarCategorias();
                foreach (string strCategoria in lstCategorias)
                bnfDrpdCategoria.AddItem(strCategoria);
                bnfDrpdCategoria.selectedIndex = 0;
            }
            catch (Exception e)
            {
                if (e.Message != "Out of index") // Intenté arreglar esta excepción en relación a seleccionar el index en caso de vacío de otras formas y no se dejaba.
                    MessageBox.Show(e.Message);
            }
        }
        void LimpiarCampos()
        {
            bnftxtUnidadesDisponibles.Text = "Unidades disponibles";
            bnfMtltxtPrecio.Text = "Precio";
            bnfMtltxtDescripcion.Text = "Descripción";
           
        }
        private void bnfMtltxtDescripcion_MouseEnter(object sender, EventArgs e)
        {
            bnfMtltxtDescripcion.Focus();
        }
        private void bnfMtltxtPrecio_MouseEnter(object sender, EventArgs e)
        {
            bnfMtltxtPrecio.Focus();
        }
        private void bnftxtUnidadesDisponibles_MouseEnter(object sender, EventArgs e)
        {
            bnftxtUnidadesDisponibles.Focus();
        }

        private void lklblAgregarCategoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SubVentana nCategoria = new SubVentana(new AgregarCategoria(),"Agregar categoria");  
            nCategoria.Show();

        }

        private void bnfDrpdCategoria_MouseEnter(object sender, EventArgs e)
        {
            CargarCategorias();
        }
    }
}
