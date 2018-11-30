using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PuntoDeVentaRamirez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CrearPanelInicio();
            //CargarConexion();
        }

        //public void CargarConexion()
        //{
        //    SqlConnection con = ConexionBD.ObtenerConexion();
        //    try
        //    {

        //        if (con.State == ConnectionState.Open)
        //        {
        //            MessageBox.Show("Bienvenido");
        //        }
        //    }
        //    catch (SqlException e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}


        private void bnfbtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bnfBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        public void CrearPanelInicio()
        {
            
            PanelInicionSesion pInicio = new PanelInicionSesion();
            bnfGrPanelPrincipal.Controls.Add(pInicio);
            pInicio.Location =  new Point(483, 150);
        }

        public static void CrearPanelOpciones()
        {
           
            PanelOpciones pOpciones = new PanelOpciones();
            bnfGrPanelPrincipal.Controls.Add(pOpciones);
            pOpciones.Location = new Point(0, 0);
            bnfGrPanelPrincipal.BackColor = Color.White;
            bnfGrPanelPrincipal.GradientBottomLeft = Color.White;
            bnfGrPanelPrincipal.GradientBottomRight = Color.White;
            bnfGrPanelPrincipal.GradientTopLeft = Color.White;
        }
        public static void LimpiarPanel()
        {
            bnfGrPanelPrincipal.Controls.Clear();
        }

        private void bnfGrPanelPrincipal_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
