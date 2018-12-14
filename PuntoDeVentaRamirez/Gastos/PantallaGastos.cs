using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace PuntoDeVentaRamirez
{
    public partial class PantallaGastos : UserControl
    {
        public PantallaGastos()
        {
            InitializeComponent();
        }

        static List<Pedido> lstPedidos;
        static List<Gasto> lstGastoComun;
        private void bnfFltbtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Gasto nGasto = new Gasto();
                nGasto.Monto = double.Parse(bnfMtltxtCantidad.Text);
                nGasto.Descripcion = bnfMtltxtDescripcion.Text;
                nGasto.FechaRegistro = bnfDtmpkFecha.Value;
                ConexionesAGastos.AgregarGasto(nGasto);
                MessageBox.Show("Gasto agregado con éxito.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGastosComunes();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        public static void CargarGastosComunes()
        {
            bnfCstgrDetalles.Rows.Clear();
            lstGastoComun = new List<Gasto>();
            lstGastoComun = ConexionesAGastos.MostrarGastosComunes();
            foreach(Gasto nGasto in lstGastoComun)
            {
                bnfCstgrDetalles.Rows.Add(nGasto.Descripcion, nGasto.Monto);
            }
        }
        public static void  CargarPedidos()
        {
            bnfgridPedidos.Rows.Clear();
            lstPedidos = ConexionesAGastos.MostrarPedidos();
            foreach(Pedido nPedido in lstPedidos)
            {
                bnfgridPedidos.Rows.Add(nPedido.NumeroFactura, nPedido.Proveedor, nPedido.Subtotal, nPedido.Iva, nPedido.Total);
            }
        }

        private void bnfAgregarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido nPedido = new Pedido();
                nPedido.FechaDeLlegada = bnfdtmLlegada.Value;
                nPedido.NumeroFactura = int.Parse(bnftxtNumeroFactura.Text);
                nPedido.Proveedor = bnftxtProveedor.Text;
                nPedido.Subtotal = double.Parse(bnftxtSubtotal.Text);
                nPedido.Iva = int.Parse(bnftxtIva.Text);
                nPedido.Total = double.Parse(bnftxtTotal.Text);
                nPedido.FechaLimite = bnfdtmLimitePago.Value;
                ConexionesAGastos.AgregarPedido(nPedido);
                MessageBox.Show("Pedido agregado con éxito.", "Pedido agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPedidos();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PantallaGastos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGastosComunes();
                CargarPedidos();
                CargarNotificaciones();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnfbtnRegistrarPago_Click(object sender, EventArgs e)
        {
            Pedido nPed = new Pedido();
            DataGridViewRow RenglonSeleccionado = bnfgridPedidos.CurrentRow;
            if (RenglonSeleccionado == null)
                MessageBox.Show("Seleccione un renglón de la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                nPed.NumeroFactura = int.Parse(RenglonSeleccionado.Cells[0].Value.ToString());
                foreach (Pedido nPedido in lstPedidos)
                {
                    nPed = lstPedidos.Find(x => x.NumeroFactura == nPed.NumeroFactura);
                   
                }
                SubVentana sbRegistrarPago = new SubVentana(new RegistrarPagoPedido(nPed), "Registrar pago de pedido");
                sbRegistrarPago.ShowDialog();
            }

           
        }

       public static void CargarNotificaciones()
        {
            List<Pedido> lstNotificaciones;
            lstNotificaciones = ConexionesAGastos.MostrarNotificaciones();
            int y = 10;
            foreach (Pedido nPedido in lstPedidos)
            {
                TarjetaNoficacion tnNotificacion = new TarjetaNoficacion(nPedido.Proveedor,nPedido.FechaLimite,nPedido.Total);
                tnNotificacion.Location = new Point(10, y);
                bnfPanelNotificaciones.Controls.Add(tnNotificacion);
                y += 70;
            }
            
        }
        
    }
}
