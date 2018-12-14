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
        private static double _dblPago;

        public static double Pago
        {
            get { return _dblPago; }
            set { _dblPago = value; }
        }
        private static double _dblCambio;

        public static double Cambio
        {
            get { return _dblCambio; }
            set { _dblCambio = value; }
        }
        public PanelVenta()
        {
            InitializeComponent();
            CargarItems();
            CargarProductos();
            ActualizarTotales();
        }
        void CargarItems()
        {
            List<string> lstDescripciones = ConexionesAVentas.MostrarProductosBusqueda();
            foreach(string c in lstDescripciones)
            {
                cmbDescripcion.Items.Add(c);
            }
        }

        private void cmbDescripcion_Click(object sender, EventArgs e)
        {
            CargarItems();
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
                    cmbDescripcion.Text = "";
                    bnfCantidad.Text = "Cantidad";
                }
                else
                {
                    MessageBox.Show("No se cuenta con los productos suficientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Especifique una cantidad de productos a agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static  void CargarProductos()
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static double CalcularTotal()
        {
            double dblSuma = 0;
            foreach (Producto nProduct in lstCompra)
            {
                dblSuma += nProduct.UnidadesDisponibles * nProduct.PrecioUnitario;
            }
            return dblSuma;
        }
        private static void ActualizarTotales()
        {
            bnflblTotal.Text = "Total: "+CalcularTotal().ToString("C");
            bnflblTotalGigante.Text = CalcularTotal().ToString("C");
            bnflblPago.Text = "Pago: " + Pago.ToString("C");
            bnflblCambio.Text = "Cambio: " + Cambio.ToString("C");
         
        }
        private void bnfCantidad_MouseEnter(object sender, EventArgs e)
        {
            bnfCantidad.Focus();
        }

        private void bnfFltbtnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                Venta nVenta = new Venta();
                nVenta.VendedorId = ConexionesAVentas.RecuperarIDVendedor();
                nVenta.FechaRegistro = DateTime.Now;
                VentanaCobro vcNueva = new VentanaCobro();
                vcNueva.TotalAPagar = CalcularTotal();
                vcNueva.CargarLista(lstCompra);
                vcNueva.VentaActual = nVenta;
                SubVentana svCobrar = new SubVentana(vcNueva, "Detalles de pago");
                svCobrar.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void bnfImgbtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nProducto = new Producto();
                DataGridViewRow RenglonSeleccionado = bnfDtgCuenta.CurrentRow;
                if (RenglonSeleccionado == null)
                    MessageBox.Show("Seleccione un renglón de la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    nProducto.IdProducto = int.Parse(RenglonSeleccionado.Cells[0].Value.ToString());
                    lstCompra.Remove(nProducto);
                    CargarProductos();
                    ActualizarTotales();
                }
            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LimpiarDatagrid()
        {
            lstCompra.Clear();
            CargarProductos();
            ActualizarTotales();
          
        }

        public static void CargarPaquete(List<Producto> lstProducts) 
        {
            foreach(Producto nProducto in lstProducts)
            {
                lstCompra.Add(nProducto);
            }
            CargarProductos();
            ActualizarTotales();
        }
    }
    
}

