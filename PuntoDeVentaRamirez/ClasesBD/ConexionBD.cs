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
        private static string _strUsuario;

        public static string Usuario
        {
            get { return _strUsuario; }
            set { _strUsuario = value; }
        }
        private static string _strContrasena;

        public static string Contraseña
        {
            get { return _strContrasena; }
            set { _strContrasena = value; }
        }

        public static bool ComprobarConexion()
        {
            try
            {
                string strDataSource = @"DESKTOP-8I9VLRK\SQLEXPRESS";
                string strCatolog = "ELECTRONICA";
                SqlConnection con = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};User ID = {2}; Password = {3}", strDataSource, strCatolog, Usuario, Contraseña));
                con.Open();

                return true;
            }catch(SqlException ex)
            {
                return false;
            }
        }

        public static SqlConnection ObtenerConexion()
        {
            string strDataSource = @"DESKTOP-8I9VLRK\SQLEXPRESS";            
            string strCatolog = "ELECTRONICA";
            SqlConnection con = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};User ID = {2}; Password = {3}", strDataSource,strCatolog,Usuario,Contraseña));
            con.Open();
            return con;
        }
        
    }
}
