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
                        nProducto.Categoria,nProducto.Descripcion,nProducto.PrecioUnitario,nProducto.UnidadesDisponibles),con);
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
                    SqlCommand comando = new SqlCommand("SELECT Descripcion FROM CATEGORIA",con);
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
    }
}
