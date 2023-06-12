using GestionAlmacen.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string id = txt_Usuario.Text;
            string clave = txt_Clave.Text;
            //Comprueba si coinciden el id y clave con un usuario existen en la base de datos
            if (new Controladores.ControladorUsuarios().validarUsuario(id, clave))
            {
                FrmMenu frmMenu = new FrmMenu(id);
                frmMenu.Show();
                this.Close();
            }
            else
            {
                lbl_Error.Visible = true;
            }
            
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            //Cierra la aplicacion
            Application.Exit();
        }
    }
}
