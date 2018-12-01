using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaRamirez
{
    public class Gasto
    {
        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }
        private double _dblMonto;

        public double Monto
        {
            get { return _dblMonto; }
            set { _dblMonto = value; }
        }
        private DateTime _dtmFechaRegistro;

        public DateTime FechaRegistro
        {
            get { return _dtmFechaRegistro; }
            set { _dtmFechaRegistro = value; }
        }
        private string _strDescripcion;

        public string Descripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

    }
}
