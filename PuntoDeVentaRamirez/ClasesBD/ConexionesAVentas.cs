using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PuntoDeVentaRamirez
{
    public class ConexionesAVentas
    {
        public static void AgregarProducto(Producto nProducto)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_agregar_producto '{0}','{1}','{2}','{3}'",
                        nProducto.Categoria, nProducto.Descripcion, nProducto.PrecioUnitario, nProducto.UnidadesDisponibles), con);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public static List<string> MostrarCategorias()
        {
            List<string> nCategorias = new List<string>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT Descripcion FROM CATEGORIA ORDER BY Descripcion", con);
                    SqlDataReader dterMostrar = comando.ExecuteReader();
                    while (dterMostrar.Read())
                    {
                        nCategorias.Add(dterMostrar.GetString(0));
                    }

                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
            }
            return nCategorias;
        }
        public static List<string> MostrarProductosBusqueda()
        {
            List<string> lstProductos = new List<string>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand("SELECT Descripcion FROM PRODUCTO", con);
                    SqlDataReader drMostrar = comando.ExecuteReader();
                    while (drMostrar.Read())
                    {
                        lstProductos.Add(drMostrar.GetString(0));
                    }

                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return lstProductos;
        }
        public static void AgregarCategoria(string strCategoria)
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_agregar_categoria '{0}'", strCategoria), con);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public static Producto MostrarProducto(string strDescripcion)
        {
            Producto nProducto = new Producto();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_buscar_producto '{0}'", strDescripcion), con);
                    SqlDataReader drMostrar = comando.ExecuteReader();
                    while (drMostrar.Read())
                    {
                        nProducto.IdProducto = drMostrar.GetInt32(0);
                        nProducto.Categoria = drMostrar.GetString(1);
                        nProducto.Descripcion = drMostrar.GetString(2);
                        nProducto.PrecioUnitario = (double)drMostrar.GetDecimal(3);
                        nProducto.UnidadesDisponibles = drMostrar.GetInt16(4);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return nProducto;
        }
        public static bool VerificarExistencia(string strDescripcion, int intUnidadesPedidas)
        {
            bool blnExistencia = false;
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand commando = new SqlCommand(string.Format("select dbo.fc_verificar_existencia('{0}','{1}')", strDescripcion, intUnidadesPedidas.ToString()), con);
                    SqlDataReader drResult = commando.ExecuteReader();
                    while (drResult.Read())
                    {
                        if (drResult.GetInt32(0) == 1)
                        {
                            blnExistencia = true;
                        }
                    }

                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return blnExistencia;
        }
        public static void AgregarVenta(Venta nVenta)
        {

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand commando = new SqlCommand(string.Format("exec sp_agregar_venta '{0}','{1}'", nVenta.VendedorId, nVenta.FechaRegistro.ToString("yyyy-MM-dd hh:mm:ss")), con);
                    commando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }
        public static void AgregarDetallesVenta(List<Producto> lstProductos)
        {

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    foreach (Producto nProducto in lstProductos)
                    {
                        SqlCommand commando = new SqlCommand(string.Format("exec sp_agregar_detalles_venta '{0}','{1}','{2}'", nProducto.IdProducto, nProducto.PrecioUnitario, nProducto.UnidadesDisponibles), con);
                        commando.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }
        public static void AgregarPaquete(Paquete nPaquete)
        {

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand commando = new SqlCommand(string.Format("exec sp_agregar_paquete '{0}','{1}'", nPaquete.Descripcion, nPaquete.Fecha.ToString("yyyy-MM-dd hh:mm:ss")), con);
                    commando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }
        public static void AgregarDetallesPaquete(List<Producto> lstProductos)
        {

            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    foreach (Producto nProducto in lstProductos)
                    {
                        SqlCommand commando = new SqlCommand(string.Format("exec sp_agregar_paquete_productos '{0}','{1}'", nProducto.IdProducto, nProducto.UnidadesDisponibles), con);
                        commando.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

        }
        public static List<Producto> MostrarProductos()
        {
            List<Producto> nListaProducto = new List<Producto>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand("exec sp_buscar_productos", con);
                    SqlDataReader drMostrar = comando.ExecuteReader();
                    while (drMostrar.Read())
                    {
                        Producto nProducto = new Producto();
                        nProducto.IdProducto = drMostrar.GetInt32(0);
                        nProducto.Categoria = drMostrar.GetString(1);
                        nProducto.Descripcion = drMostrar.GetString(2);
                        nProducto.PrecioUnitario = (double)drMostrar.GetDecimal(3);
                        nProducto.UnidadesDisponibles = drMostrar.GetInt16(4);
                        nListaProducto.Add(nProducto);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return nListaProducto;
            }

        }
        public static List<Producto> BuscarSugerencias(string strDescripcion)
        {
            List<Producto> nListaProducto = new List<Producto>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("SELECT CodigoProducto,B.Descripcion,A.Descripcion, PrecioUnitario,UnidadesDisponibles FROM PRODUCTO A JOIN CATEGORIA B ON (A.CategoriaID = B.CategoriaID) WHERE A.Descripcion LIKE '%{0}%'", strDescripcion), con);
                    SqlDataReader drMostrar = comando.ExecuteReader();
                    while (drMostrar.Read())
                    {
                        Producto nProducto = new Producto();
                        nProducto.IdProducto = drMostrar.GetInt32(0);
                        nProducto.Categoria = drMostrar.GetString(1);
                        nProducto.Descripcion = drMostrar.GetString(2);
                        nProducto.PrecioUnitario = (double)drMostrar.GetDecimal(3);
                        nProducto.UnidadesDisponibles = drMostrar.GetInt16(4);
                        nListaProducto.Add(nProducto);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return nListaProducto;
            }

        }
        public static List<Paquete> MostrarPaquetes(string strDescripcion)
        {
            List<Paquete> lstPaquete = new List<Paquete>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("SELECT *  FROM PAQUETE WHERE Descripcion LIKE '%{0}%'", strDescripcion), con);
                    SqlDataReader drMostrar = comando.ExecuteReader();
                    while (drMostrar.Read())
                    {
                        Paquete nPaquete = new Paquete();
                        nPaquete.IdPaquete = drMostrar.GetInt32(0);
                        nPaquete.Descripcion = drMostrar.GetString(1);
                        lstPaquete.Add(nPaquete);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return lstPaquete;

        }
        public static List<Producto> MostrarProductosPaquete(int intPaqueteID)
        {
            List<Producto> nListaProducto = new List<Producto>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_obtener_productos_paquete '{0}'", intPaqueteID), con);
                    SqlDataReader drMostrar = comando.ExecuteReader();
                    while (drMostrar.Read())
                    {
                        Producto nProducto = new Producto();
                        nProducto.IdProducto = drMostrar.GetInt32(0);
                        nProducto.Descripcion = drMostrar.GetString(1);
                        nProducto.PrecioUnitario = (double)drMostrar.GetDecimal(2);
                        nProducto.UnidadesDisponibles = drMostrar.GetInt16(3);
                        nListaProducto.Add(nProducto);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return nListaProducto;
            }
            //public static void AgregarVenta(Venta nVenta)
            //{

            //    using (SqlConnection con = ConexionBD.ObtenerConexion())
            //    {
            //        try
            //        {

            //        }
            //        catch (SqlException ex)
            //        {
            //            throw new Exception(ex.Message);
            //        }
            //    }

            //}

            //public static bool VerificarExistencia(string strDescripcion)
            //{
            //    bool blnExistencia = false;
            //    using (SqlConnection con = ConexionBD.ObtenerConexion())
            //    {

            //    }
            //    return blnExistencia;
            //}




        }
    }
}
