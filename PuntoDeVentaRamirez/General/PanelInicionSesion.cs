using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentaRamirez
{
    public partial class PanelInicionSesion : UserControl
    {
        public PanelInicionSesion()
        {
            InitializeComponent();
        }

        private void bnfFlBtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBD.Usuario = bnfMtxtUser.Text;
                ConexionBD.Contraseña = bnfMtxtPassword.Text;
                if (ConexionBD.ComprobarConexion())
                {
                    Form1.LimpiarPanel();
                    Form1.CrearPanelOpciones();
                }
                else
                {
                    MessageBox.Show("No se pudo conectar, error en el usuario o contraseña");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                 
        }
    }
}
