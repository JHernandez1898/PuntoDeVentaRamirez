using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaRamirez
{
    public class Venta
    {
        private int _intVentaID;

        public int VentaID
        {
            get { return _intVentaID; }
            set { _intVentaID = value; }
        }
        private int _intVendedorId;

        public int VendedorId
        {
            get { return _intVendedorId; }
            set { _intVendedorId = value; }
        }
        private DateTime _dtmFechaRegistro;

        public DateTime FechaRegistro
        {
            get { return _dtmFechaRegistro; }
            set { _dtmFechaRegistro = value; }
        }

        private List<Producto> lstListaProductos = new List<Producto>();

        public void LlenarLista(List<Producto> lstListaLlena)
        {
            lstListaProductos = lstListaLlena; 
        }

        public IEnumerator<Producto> GetEnumerator()
        {
            return lstListaProductos.GetEnumerator();

        }



    }
}
