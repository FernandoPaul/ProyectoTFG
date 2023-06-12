using GestionAlmacen.Vistas.Entradas;
using GestionAlmacen.Vistas.Productos;
using GestionAlmacen.Vistas.Salidas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen.Vistas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu(string id)
        {
            InitializeComponent();
            tst_Usuario.Text = id;
            tst_Hora.Text = DateTime.Now.ToString();
            //Comprueba si el usuario que accedio es Administrador
            if (new Controladores.ControladorUsuarios().esAdmin(id))
            {
                btn_NuevoUsuario.Visible = true;
            }
        }
        private void Btn_Clientes_Click(object sender, EventArgs e)
        {
            //Abre el formulario seleccionado
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();

        }
        private void btn_Productos_Click(object sender, EventArgs e)
        {
            //Abre el formulario seleccionado
            FrmMenuProductos frmMenuProductos = new FrmMenuProductos();
            frmMenuProductos.Show();
        }
        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            //Abre el formulario seleccionado
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.Show();
        }

        private void btn_Entrada_Click(object sender, EventArgs e)
        {
            //Abre el formulario seleccionado
            FrmMenuEntradas frmMenuEntradas = new FrmMenuEntradas();
            frmMenuEntradas.Show();
        }

        private void btn_Salidas_Click(object sender, EventArgs e)
        {
            //Abre el formulario seleccionado
            FrmMenuSalidas frmMenuSalidas = new FrmMenuSalidas();
            frmMenuSalidas.Show();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            //Abre el formulario seleccionado
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.Show();
        }
        private void btn_NuevoUsuario_Click(object sender, EventArgs e)
        {
            //Abre el formulario seleccionado
            FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario();
            frmNuevoUsuario.Show();
        }
        

        private void btn_Info_Click(object sender, EventArgs e)
        {

        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            //Cierra la sesion y abre el formulario Inicio sesion
            FrmInicioSesion frmInicioSesion = new FrmInicioSesion();
            frmInicioSesion.Show();
            this.Close();
        }
    }
}
