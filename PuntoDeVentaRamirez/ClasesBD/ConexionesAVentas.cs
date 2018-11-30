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
      public static void AgregarProducto()
        {
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                try
                {
                    //SqlCommand comando = new SqlCommand(string.Format("exec sp_agregar_producto '{0}','{1}','{2}','{3}'",),con);
                }catch
                {

                }
            }
        }
    }
}
