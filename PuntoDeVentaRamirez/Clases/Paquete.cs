using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaRamirez
{
    public class Paquete
    {
        private int _intIdPaquete;

        public int IdPaquete
        {
            get { return _intIdPaquete; }
            set { _intIdPaquete = value; }
        }
        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }
        private DateTime _dtmFecha;

        public DateTime Fecha
        {
            get { return _dtmFecha; }
            set { _dtmFecha = value; }
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
