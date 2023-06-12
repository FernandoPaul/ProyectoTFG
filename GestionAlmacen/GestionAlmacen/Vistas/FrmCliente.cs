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

namespace GestionAlmacen.Vistas
{
    public partial class FrmCliente : Form
    {
        internal DataSet listaClientes;
        public FrmCliente()
        {
            InitializeComponent();
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            //cargo los clientes en la lista
            listaClientes = new Controladores.ControladorClientes().cargarClientes();
            //Muestro los clientes
            dgv_ListaClientes.DataSource = listaClientes.Tables[0];
            dgv_ListaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Creo lista para recuperar los campos y asi elegir que campo buscar.
            List<string> listaAtributos = new Cliente().RecuperarCamposCliente();
            cmb_Buscar.DataSource = listaAtributos;
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Si los campos no estan vacios
            if (validarCampos())
            {
                string cif = mtb_Cif.Text;
                string nombre = txt_Nombre.Text.Trim();
                string telefono = mtb_Movil.Text;
                //Insertar nuevo Cliente
                if (new Controladores.ControladorClientes().AddCliente(cif, nombre, telefono))
                {
                    MessageBox.Show("Guardado");
                    ActualizarDGV();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }
        private void ActualizarDGV()
        {
            //Actualiza el DataGridView despues de añadir o eliminar Clientes
            listaClientes = new Controladores.ControladorClientes().cargarClientes();
            dgv_ListaClientes.DataSource = listaClientes.Tables[0];
        }
        private bool validarCampos()
        {//Comprobar que no esten los campos vacios
            bool valido = true;

            string cif = mtb_Cif.Text;
            string nombre = txt_Nombre.Text.Trim();
            string telefono = mtb_Movil.Text;

            if (cif == "")
            {
                lbl_ErrorCIF.Visible = true;
                valido = false;
            }
            if (nombre == "")
            {
                lbl_ErrorNombreCliente.Visible = true;
                valido = false;
            }
            if (telefono == "")
            {
                lbl_ErrorMovil.Visible = true;
                valido = false;
            }
            return valido;
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txt_Buscar.Text.Trim();
            string tipo = cmb_Buscar.Text;
            //Filtro que coindice parcialmente con la busqueda
            listaClientes.Tables[0].DefaultView.RowFilter = tipo + " LIKE '%" + busqueda + "%'";
            dgv_ListaClientes.DataSource = listaClientes.Tables[0].DefaultView;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //Mensaje para confirmar que quieres eliminar los clientes seleccionados en el dgv
            if (MessageBox.Show("Los clientes seleccionadas se van a eliminar.\n¿ESTAS SEGURO? ", "ELMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int contadorBorrados = 0;
                foreach (DataGridViewRow fila in dgv_ListaClientes.SelectedRows)
                {
                    if (new Controladores.ControladorClientes().eliminarCliente((string)fila.Cells[0].Value))
                    {
                        contadorBorrados++;
                    }
                }
                ActualizarDGV();
                MessageBox.Show("Se han eliminado " + contadorBorrados.ToString() + " Clientes");
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            mtb_Cif.Text = "";
            txt_Nombre.Text = "";
            mtb_Movil.Text = "";
            lbl_ErrorCIF.Visible = false;
            lbl_ErrorNombreCliente.Visible = false;
            lbl_ErrorMovil.Visible = false;
        }
    }
}
