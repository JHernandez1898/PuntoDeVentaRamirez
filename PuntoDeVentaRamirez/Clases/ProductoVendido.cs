using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaRamirez.Clases
{
    class ProductoVendido
    {
        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }
        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }
        private int _dblUnidadesPedidas;

        public int UnidadesPedidas
        {
            get { return _dblUnidadesPedidas; }
            set { _dblUnidadesPedidas = value; }
        }
        private double _dblPrecio;

        public double Precio
        {
            get { return _dblPrecio; }
            set { _dblPrecio = value; }
        }

        public double CalcularImporte()
        {
            return Precio * UnidadesPedidas;
        }


    }
}
