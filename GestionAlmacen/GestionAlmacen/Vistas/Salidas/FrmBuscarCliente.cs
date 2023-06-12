using GestionAlmacen.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen.Vistas.Entradas
{
    public partial class FrmBuscarCliente : Form
    {
        public string CifCliente { get; set; }
        public string NomCliente { get; set; }

        internal DataSet listaClientes;
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            //cargo los clientes en la lista
            listaClientes = new Controladores.ControladorClientes().cargarClientes();
            //Muestro los clientes
            dgv_ListaClientes.DataSource = listaClientes.Tables[0];
            //dgv_ListaProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Creo lista para recuperar los campos y asi elegir que campo buscar.
            List<string> listaAtributos = new Cliente().RecuperarCamposCliente();
            cmb_Buscar.DataSource = listaAtributos;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (dgv_ListaClientes.SelectedRows.Count > 0)
            {
                //Selecciona el cif y nombre del cliente
                CifCliente = dgv_ListaClientes.SelectedRows[0].Cells[0].Value.ToString();
                NomCliente = dgv_ListaClientes.SelectedRows[0].Cells[1].Value.ToString();
                this.Close();
            }
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txt_Buscar.Text.Trim();
            string tipo = cmb_Buscar.Text;
            //Filtro para encontrar lo buscado
            listaClientes.Tables[0].DefaultView.RowFilter = tipo + " LIKE '%" + busqueda + "%'";
            dgv_ListaClientes.DataSource = listaClientes.Tables[0].DefaultView;
        }
    }
}
