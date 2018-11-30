using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PuntoDeVentaRamirez
{
    public class ConexionBD
    {

        public static SqlConnection ObtenerConexion()
        {
            //string strDataSource = @"DESKTOP-8I9VLRK\SQLEXPRESS";
            string strDataSource = @"LA-DIVERTIDA\SQLEXPRESS";
            string strCatolog = "ELECTRONICA";
            SqlConnection con = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True",strDataSource,strCatolog));
            con.Open();
            return con;
        }
        
    }
}
