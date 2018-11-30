﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaRamirez
{
    class Pedido
    {
        private int _intIDPedido;

        public int IDPedido
        {
            get { return _intIDPedido; }
            set { _intIDPedido = value; }
        }
        private DateTime _dtmFechaDeLlegada;

        public DateTime FechaDeLlegada
        {
            get { return _dtmFechaDeLlegada; }
            set { _dtmFechaDeLlegada = value; }
        }
        private string _strProveedor;

        public string Proveedor
        {
            get { return _strProveedor; }
            set { _strProveedor = value; }
        }
        private double _dblSubtotal;

        public double Subtotal  
        {
            get { return _dblSubtotal; }
            set { _dblSubtotal = value; }
        }
        private int _intIva;

        public int Iva
        {
            get { return _intIva; }
            set { _intIva = value; }
        }
        private int _intNumeroCheque;

        public int NumeroCheque
        {
            get { return _intNumeroCheque; }
            set { _intNumeroCheque = value; }
        }
        private DateTime _dtmFechaDeposito;
                
        public DateTime FechaDeposito
        {
            get { return _dtmFechaDeposito; }
            set { _dtmFechaDeposito = value; }
        }

    }
}
