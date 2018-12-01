using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PuntoDeVentaRamirez.ClasesBD
{
    public class ConexionesAInventario
    {
        public static List<Producto> FiltrarProductos(string strWhere)
        {
            string strConsulta = "SELECT CodigoProducto, CATEGORIA.Descripcion, PRODUCTO.Descripcion, PrecioUnitario, UnidadesDisponibles  FROM PRODUCTO JOIN CATEGORIA ON (PRODUCTO.CategoriaID = CATEGORIA.CategoriaID)" + strWhere;
            List<Producto> lstProductos = new List<Producto>();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand(strConsulta, con);
                    SqlDataReader drMostrar = comando.ExecuteReader();
                    while (drMostrar.Read())
                    {
                        Producto nProducto = new Producto();
                        nProducto.IdProducto = drMostrar.GetInt32(0);
                        nProducto.Categoria = drMostrar.GetString(1);
                        nProducto.Descripcion = drMostrar.GetString(2);
                        nProducto.PrecioUnitario = (double)drMostrar.GetDecimal(3);
                        nProducto.UnidadesDisponibles = drMostrar.GetInt16(4);
                        lstProductos.Add(nProducto);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return lstProductos;
        }
    }
}
