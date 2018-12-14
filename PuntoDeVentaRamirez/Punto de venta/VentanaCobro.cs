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
    public  partial class VentanaCobro : UserControl
    {
       
        public VentanaCobro()
        {
            InitializeComponent();

        }
        private double _dblTotalAPagar;

        private List<Producto> lstProductos = new List<Producto>();
        public void CargarLista(List<Producto> nLista)
        {
            lstProductos = nLista;
        }

        private Venta _vtVenta;

        public Venta VentaActual
        {
            get { return _vtVenta; }
            set { _vtVenta = value; }
        }

        public double TotalAPagar
        {
            get { return _dblTotalAPagar; }
            set { _dblTotalAPagar = value; }
        }
        private void VentanaCobro_Load(object sender, EventArgs e)
        {
            bnfTotal.Text = TotalAPagar.ToString();
            radPesos.Checked = true;
            bnfTotal.Enabled = false;
        }
        private void bnfFltbtnCobrar_Click(object sender, EventArgs e)
        {
            try
            {   
                ConexionesAVentas.AgregarVenta(VentaActual);
                ConexionesAVentas.AgregarDetallesVenta(lstProductos);
                MessageBox.Show("Venta realizada con éxito.", "Venta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PanelVenta.LimpiarDatagrid();
                PanelVenta.Pago = double.Parse(bnfPagoEnPesos.Text);
                PanelVenta.Cambio = (double.Parse(bnfPagoEnPesos.Text) - double.Parse(bnfTotal.Text));
                SubVentana.ActiveForm.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
           
        }
        private void radPesos_CheckedChanged(object sender, EventArgs e)
        {
            if(radPesos.Checked == true)
            {
                bnfPagoEnPesos.Enabled = true;
                bnfPagoDolares.Enabled = false;
                bnfTipoDeCambio.Enabled = false;
                bnfPagoDolares.Text = "";
                bnfPagoEnPesos.Text = "";
                bnfTipoDeCambio.Text = "";
            }
            else
            {
                bnfPagoEnPesos.Enabled = false;
                bnfPagoDolares.Enabled = true;
                bnfTipoDeCambio.Enabled = true;
                bnfPagoDolares.Text = "";
                bnfPagoEnPesos.Text = "";
                bnfTipoDeCambio.Text = "";
            }
        }
        private void bnfPagoEnPesos_MouseEnter(object sender, EventArgs e)
        {
            bnfPagoEnPesos.Focus();
        }
        private void bnfPagoDolares_MouseEnter(object sender, EventArgs e)
        {
            bnfPagoDolares.Focus();
        }
        private void bnfTipoDeCambio_MouseEnter(object sender, EventArgs e)
        {
            bnfTipoDeCambio.Focus();
        }
        private void bnfPagoEnPesos_OnValueChanged(object sender, EventArgs e)
        {
            try
            { 
             if (bnfPagoEnPesos.Text != "")
             {
                lblCambio.Text = "Cambio del cliente: " + (double.Parse(bnfPagoEnPesos.Text) - double.Parse(bnfTotal.Text)).ToString();
             }
             else
             {
                lblCambio.Text = "Cambio del cliente: ";
             }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void bnfPagoDolares_OnValueChanged(object sender, EventArgs e)
        {
            CalculoEnDolares();
        }
        private void bnfTipoDeCambio_OnValueChanged(object sender, EventArgs e)
        {
            CalculoEnDolares();
        }
        void CalculoEnDolares()
        {
            try
            {
                if (bnfTipoDeCambio.Text != "" && bnfPagoDolares.Text != "")
                    bnfPagoEnPesos.Text = (double.Parse(bnfPagoDolares.Text) * double.Parse(bnfTipoDeCambio.Text)).ToString();
                else
                    bnfPagoEnPesos.Text = "";                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
