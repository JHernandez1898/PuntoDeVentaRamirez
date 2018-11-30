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
    
    public partial class PanelVenta : UserControl
    {
        public static List<Producto> lstCompra =  new List<Producto>();
        
        public  void NuevaLista()
        {
            lstCompra = new List<Producto>();
            CargarProductos();
            ActualizarTotales();
        }
        public PanelVenta()
        {
            InitializeComponent();
            CargarItems();
        }
        void CargarItems()
        {
            List<string> lstDescripciones = ConexionesAVentas.MostrarProductosBusqueda();
            foreach(string c in lstDescripciones)
            {
                cmbDescripcion.Items.Add(c);
            }
        }
       
        private void bnfImgbtnCarrito_Click(object sender, EventArgs e)
        {
            
            try
            {
                Producto nProducto = ConexionesAVentas.MostrarProducto(cmbDescripcion.Text);
                nProducto.UnidadesDisponibles = int.Parse(bnfCantidad.Text);
                if (ConexionesAVentas.VerificarExistencia(nProducto.Descripcion, nProducto.UnidadesDisponibles))
                {
                    lstCompra.Add(nProducto);
                    CargarProductos();
                    ActualizarTotales();
                }else
                {
                    MessageBox.Show("No se cuenta con los productos suficientes");
                }
               
       
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private  void CargarProductos()
        {
            try
            {
                bnfDtgCuenta.Rows.Clear();
                foreach (Producto nProduct in lstCompra)
                {
                    bnfDtgCuenta.Rows.Add(nProduct.IdProducto.ToString(), nProduct.Descripcion, nProduct.PrecioUnitario.ToString("C"), nProduct.UnidadesDisponibles.ToString(), (nProduct.PrecioUnitario * nProduct.UnidadesDisponibles).ToString("C"));
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private double CalcularTotal()
        {
            double dblSuma = 0;
            foreach (Producto nProduct in lstCompra)
            {
                dblSuma += nProduct.UnidadesDisponibles * nProduct.PrecioUnitario;
            }
            return dblSuma;
        }
        private void ActualizarTotales()
        {
            bnflblTotal.Text = CalcularTotal().ToString("C");
            bnflblTotalGigante.Text = CalcularTotal().ToString("C");
            cmbDescripcion.Text = "";
            bnfCantidad.Text = "cantidad";
        }
        private void bnfCantidad_MouseEnter(object sender, EventArgs e)
        {
            bnfCantidad.Focus();
        }

        private void bnfFltbtnCobrar_Click(object sender, EventArgs e)
        {
            Venta nVenta = new Venta();
            nVenta.VendedorId = 1;
            nVenta.FechaRegistro = DateTime.Now;
            VentanaCobro vcNueva = new VentanaCobro();
            vcNueva.TotalAPagar = CalcularTotal();
            vcNueva.CargarLista(lstCompra);
            vcNueva.VentaActual = nVenta;
            SubVentana svCobrar = new SubVentana(vcNueva, "Detalles de pago");
            svCobrar.ShowDialog();
            lstCompra = new List<Producto>();
            CargarProductos();
            ActualizarTotales();
        }

        private void bnfImgbtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nProducto = new Producto();
                DataGridViewRow RenglonSeleccionado = bnfDtgCuenta.CurrentRow;
                if (RenglonSeleccionado == null)
                    MessageBox.Show("Seleccione un renglón del dataGridView");
                else
                {
                    nProducto.IdProducto = int.Parse(RenglonSeleccionado.Cells[0].Value.ToString());
                    lstCompra.Remove(nProducto);
                    CargarProductos();
                    ActualizarTotales();
                }
            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}

