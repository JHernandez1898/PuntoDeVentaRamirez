using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PuntoDeVentaRamirez
{
    public class ConexionesAGastos
    {
        public static void AgregarGasto(Gasto nGasto)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_agregar_gasto '{0}','{1}','{2}'",
                        nGasto.Monto, nGasto.FechaRegistro.ToString("yyyy-MM-dd"), nGasto.Descripcion), con);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public static List<Gasto> MostrarGastosComunes()
        {
            List<Gasto> nListGastos = new List<Gasto>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_mostrar_gastoscomunes"), con);
                    SqlDataReader drMostrar = comando.ExecuteReader();
                    while (drMostrar.Read())
                    {
                        Gasto nGasto = new Gasto();
                        nGasto.ID = drMostrar.GetInt32(0);
                        nGasto.Descripcion = drMostrar.GetString(3);
                        nGasto.Monto = (double)drMostrar.GetDecimal(1);
                        nGasto.FechaRegistro = drMostrar.GetDateTime(2);
                        nListGastos.Add(nGasto);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return nListGastos;
            }
        }
        public static List<Pedido> MostrarPedidos()
        {
            List<Pedido> nListPedido = new List<Pedido>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_mostrar_pedidos"), con);
                    SqlDataReader drMostrar = comando.ExecuteReader();
                    while (drMostrar.Read())
                    {
                        Pedido nPedido = new Pedido();
                        nPedido.IDPedido = drMostrar.GetInt32(0);
                        nPedido.FechaDeLlegada = drMostrar.GetDateTime(1);
                        nPedido.NumeroFactura = int.Parse(drMostrar.GetString(2));
                        nPedido.Proveedor = drMostrar.GetString(3);
                        nPedido.Subtotal = (double)drMostrar.GetDecimal(4);
                        nPedido.Iva = int.Parse(drMostrar.GetValue(5).ToString());
                        nPedido.Total = (double)drMostrar.GetDecimal(6);
                        nPedido.FechaLimite = drMostrar.GetDateTime(7);
                        nListPedido.Add(nPedido);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return nListPedido;
            }
        }
        public static void AgregarPedido(Pedido nPedido)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_agregar_pedido '{0}','{1}','{2}','{3}','{4}','{5}','{6}'",
                        nPedido.FechaDeLlegada.ToString("yyyy-MM-dd"),nPedido.NumeroFactura,nPedido.Proveedor,nPedido.Subtotal,nPedido.Iva,nPedido.Total,nPedido.FechaLimite.ToString("yyyy-MM-dd")), con);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public static void AgregarPago(Pedido nPedido)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_agregar_pagopedido '{0}','{1}','{2}'",
                        nPedido.IDPedido, nPedido.NumeroCheque, nPedido.FechaDeposito.ToString("yyyy-MM-dd")), con);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public static List<Pedido> MostrarNotificaciones()
        {
            List<Pedido> nListPedido = new List<Pedido>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_mostrar_notificaciones"), con);
                    SqlDataReader drMostrar = comando.ExecuteReader();
                    while (drMostrar.Read())
                    {
                        Pedido nPedido = new Pedido();
                        nPedido.IDPedido = drMostrar.GetInt32(0);
                        nPedido.FechaDeLlegada = drMostrar.GetDateTime(1);
                        nPedido.NumeroFactura = int.Parse(drMostrar.GetString(2));
                        nPedido.Proveedor = drMostrar.GetString(3);
                        nPedido.Subtotal = (double)drMostrar.GetDecimal(4);
                        nPedido.Iva = int.Parse(drMostrar.GetValue(5).ToString());
                        nPedido.Total = (double)drMostrar.GetDecimal(6);
                        nPedido.FechaLimite = drMostrar.GetDateTime(7);
                        nListPedido.Add(nPedido);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return nListPedido;
            }
        }
    } 
    
}
