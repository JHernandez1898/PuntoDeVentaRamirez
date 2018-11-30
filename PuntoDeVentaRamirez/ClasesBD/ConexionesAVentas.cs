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
                    SqlCommand comando = new SqlCommand("SELECT Descripcion FROM CATEGORIA", con);
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

                }catch(SqlException ex)
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
                    SqlCommand comando = new SqlCommand(string.Format("exec sp_agregar_categoria '{0}'", strCategoria),con);
                    comando.ExecuteNonQuery();
                }catch(SqlException ex)
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
                }catch(SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return nProducto;
        }
        public static bool VerificarExistencia(string strDescripcion, int intUnidadesPedidas)
        {
            bool blnExistencia  = false;
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand commando = new SqlCommand(string.Format("select dbo.fc_verificar_existencia('{0}','{1}')",strDescripcion,intUnidadesPedidas.ToString()),con);
                    SqlDataReader drResult = commando.ExecuteReader();
                    while (drResult.Read())
                    {
                        if(drResult.GetInt32(0) == 1)
                        {
                            blnExistencia = true;
                        }
                    }

                }catch(SqlException ex)
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
                    SqlCommand commando = new SqlCommand(string.Format("exec sp_agregar_venta '{0}','2018-11-30'", nVenta.VendedorId), con);
                    commando.ExecuteNonQuery();
                }catch(SqlException ex)
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
                    foreach(Producto nProducto in lstProductos)
                    {
                        SqlCommand commando = new SqlCommand(string.Format("exec sp_agregar_detalles_venta '{0}','{1}','{2}'",nProducto.IdProducto,nProducto.PrecioUnitario,nProducto.UnidadesDisponibles), con);
                        commando.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }

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
