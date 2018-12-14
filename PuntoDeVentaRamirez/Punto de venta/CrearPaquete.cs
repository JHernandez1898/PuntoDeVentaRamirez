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
    public partial class CrearPaquete : UserControl
    {
        public CrearPaquete()
        {
            InitializeComponent();
        }
        static List<Producto> lstPaquete = new List<Producto>();
        List<Producto> lstProductos = new List<Producto>();
        private void CrearPaquete_Load(object sender, EventArgs e)
        {
            CargarArticulos(lstProductos);

        }
        void CargarArticulos(List<Producto> lstProductos)
        {
            bnfCstgrdArticulos.Rows.Clear();
            lstProductos = ConexionesAVentas.MostrarProductos();
            foreach (Producto nProducto in lstProductos)
            {
                bnfCstgrdArticulos.Rows.Add(nProducto.IdProducto, nProducto.Descripcion, nProducto.PrecioUnitario);
            }
        }
        void CargarArticulosPaquete(List<Producto> lstProductos)
        {
            bnfCstgridPaquete.Rows.Clear();
            foreach (Producto nProducto in lstProductos)
            {
                
                bnfCstgridPaquete.Rows.Add(nProducto.Descripcion, nProducto.PrecioUnitario,nProducto.UnidadesDisponibles);
            }
            bnflblTotalGigante.Text = CalcularTotal().ToString("C");
        }

        private void bnfMtltxtDescripcion_OnValueChanged(object sender, EventArgs e)
        {
            List<Producto> lstProductos = new List<Producto>();
            bnfCstgrdArticulos.Rows.Clear();
            lstProductos = ConexionesAVentas.BuscarSugerencias(bnfMtltxtDescripcion.Text);
            foreach (Producto nProducto in lstProductos)
            {
                bnfCstgrdArticulos.Rows.Add(nProducto.IdProducto, nProducto.Descripcion, nProducto.PrecioUnitario);
            }
        }

        private void bnfTlbtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nProducto = new Producto();
                DataGridViewRow RenglonSeleccionado = bnfCstgrdArticulos.CurrentRow;
                if (RenglonSeleccionado == null)
                    MessageBox.Show("Seleccione un renglón del dataGridView");
                else
                {
                    nProducto.Descripcion = RenglonSeleccionado.Cells[1].Value.ToString();
                    nProducto = ConexionesAVentas.MostrarProducto(nProducto.Descripcion);
                    if (lstPaquete.Exists(x => x.IdProducto == nProducto.IdProducto))
                    {
                        nProducto = lstPaquete.Find((x => x.IdProducto == nProducto.IdProducto));
                        lstPaquete.Remove(nProducto);
                        nProducto.UnidadesDisponibles += 1;
                        lstPaquete.Add(nProducto);
                    }
                    else
                    {
                        nProducto.UnidadesDisponibles = 1;
                        lstPaquete.Add(nProducto);
                    }
                    CargarArticulosPaquete(lstPaquete);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnfTlbtnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Producto nProducto = new Producto();
                DataGridViewRow RenglonSeleccionado = bnfCstgridPaquete.CurrentRow;
                if (RenglonSeleccionado == null)
                    MessageBox.Show("Seleccione un renglón de la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    nProducto.Descripcion = RenglonSeleccionado.Cells[0].Value.ToString();
                    nProducto = ConexionesAVentas.MostrarProducto(nProducto.Descripcion);
                    if (lstPaquete.Exists(x => x.Descripcion == nProducto.Descripcion))
                    {
                        nProducto = lstPaquete.Find((x => x.Descripcion == nProducto.Descripcion));
                        if(nProducto.UnidadesDisponibles == 1)
                        {
                            lstPaquete.Remove(nProducto);
                        }
                        else
                        {
                            lstPaquete.Remove(nProducto);
                            nProducto.UnidadesDisponibles -= 1;
                            lstPaquete.Add(nProducto);
                        }                        
                    }                   
                    CargarArticulosPaquete(lstPaquete);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        double CalcularTotal()
        {
            double dblSuma = 0;
            foreach (Producto nProduct in lstPaquete)
            {
                dblSuma +=  nProduct.PrecioUnitario * nProduct.UnidadesDisponibles;
            }
            return dblSuma;
        }

        private void bnfCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete nPaquete = new Paquete();
                nPaquete.Descripcion = bnfMtltxNombrePaquete.Text;
                nPaquete.Fecha = DateTime.Now;
                ConexionesAVentas.AgregarPaquete(nPaquete);
                ConexionesAVentas.AgregarDetallesPaquete(lstPaquete);
                MessageBox.Show("El paquete se agregó correctamente.", "Paquete agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstPaquete.Clear();
                CargarArticulosPaquete(lstPaquete);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
