using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaRamirez
{
    public class Producto
    {
        private int _intIdProducto;

        public int IdProducto
        {
            get { return _intIdProducto; }
            set { _intIdProducto = value; }
        }

        private string _strCategoria;

        public string Categoria
        {
            get { return _strCategoria; }
            set { _strCategoria = value; }
        }

        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

        private double _dblPrecioUnitario;

        public double PrecioUnitario
        {
            get { return _dblPrecioUnitario; }
            set { _dblPrecioUnitario = value; }
        }
        private int _intUnidadesDisponibles;

        public int UnidadesDisponibles
        {
            get { return _intUnidadesDisponibles; }
            set { _intUnidadesDisponibles = value; }
        }
    }
}
