using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PuntoDeVentaRamirez.Reportes;

namespace PuntoDeVentaRamirez.ClasesBD
{
    class ConexionesAReportes
    {
        public static DataTable ConsultarVentasPorFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            DatosVentas datosVentas = new DatosVentas();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(@"exec Reporte_Ventas '"+fechaInicial.ToString("yy-mm-dd")+@"','"+fechaFinal.ToString("yy-mm-dd") + @"'", con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(datosVentas);                    
            }
            return datosVentas.Tables[0];
        }
    }
}
