using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaRamirez.Clases
{
    class Vendedor
    {
        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private string _strApellidoPaterno;

        public string ApellidoPaterno
        {
            get { return _strApellidoPaterno; }
            set { _strApellidoPaterno = value; }
        }
        private string _strApellidoMaterno;

        public string ApellidoMaterno
        {
            get { return _strApellidoMaterno; }
            set { _strApellidoMaterno = value; }
        }


    }
}
