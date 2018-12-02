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
                SqlCommand comando = new SqlCommand(string.Format("exec Reporte_Ventas '{0}','{1}'", fechaInicial.ToString("yyyy-MM-dd"), fechaFinal.ToString("yyyy-MM-dd")), con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(datosVentas);                    
            }
            return datosVentas.Tables[0];
        }

        public static DataTable ConsultarPedidosPagadosPorFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            DatosPedidos datosPedidos = new DatosPedidos();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("exec Reporte_Pedidos_Pagados '{0}','{1}'", fechaInicial.ToString("yyyy-MM-dd"), fechaFinal.ToString("yyyy-MM-dd")), con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(datosPedidos);
            }
            return datosPedidos.Tables[0];
        }

        public static DataTable ConsultarGastosPorFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            DatosGastos datosGastos = new DatosGastos();
            using (SqlConnection con = ConexionBD.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("exec Reporte_Gastos  '{0}','{1}'", fechaInicial.ToString("yyyy-MM-dd"), fechaFinal.ToString("yyyy-MM-dd")), con);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(datosGastos);
            }
            return datosGastos.Tables[0];
        }
    }
}
