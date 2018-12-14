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
    public partial class RegistrarPagoPedido : UserControl
    {
        public static Pedido nPed;
        public RegistrarPagoPedido(Pedido nPedido)
        {
            InitializeComponent();
            nPed = nPedido;
        }

        private void bnfbtnRegistrarPago_Click(object sender, EventArgs e)
        {
            try
            {
                Gasto nGasto = new Gasto();
                nPed.NumeroCheque = int.Parse(bnftxtNumeroCheque.Text);
                nPed.FechaDeposito = bnfdtmDeposito.Value;
                nGasto.Monto = nPed.Total;
                nGasto.FechaRegistro = nPed.FechaDeposito;
                nGasto.Descripcion = nPed.Proveedor;
                ConexionesAGastos.AgregarGasto(nGasto);
                ConexionesAGastos.AgregarPago(nPed);
                PantallaGastos.CargarGastosComunes();
                PantallaGastos.CargarPedidos();
                PantallaGastos.CargarNotificaciones();
                MessageBox.Show("Pago registrado exitosamente.", "Pago registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SubVentana.ActiveForm.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
