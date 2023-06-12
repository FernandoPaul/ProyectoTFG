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
    public partial class FrmProveedores : Form
    {
        internal DataSet listaProveedores;
        public FrmProveedores()
        {
            InitializeComponent();
        }
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            //cargo los clientes en la lista
            listaProveedores = new Controladores.ControladorProveedores().cargarProveedor();
            //Muestro los clientes
            dgv_ListaProveedores.DataSource = listaProveedores.Tables[0];
            dgv_ListaProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Creo lista para recuperar los campos y asi elegir que campo buscar.
            List<string> listaAtributos = new Proveedor().RecuperarCamposProveedor();
            cmb_Buscar.DataSource = listaAtributos;
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string cif = mtb_Cif.Text;
                string nombre = txt_Nombre.Text.Trim();
                string telefono = mtb_Movil.Text;
                if (new Controladores.ControladorProveedores().AddProveedor(cif,nombre,telefono))
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
        private bool validarCampos()
        {
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
                lbl_ErrorNombre.Visible = true;
                valido = false;
            }
            if (telefono == "")
            {
                lbl_ErrorTelefono.Visible = true;
                valido = false;
            }
            return valido;
        }
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txt_Buscar.Text.Trim();
            string tipo = cmb_Buscar.Text;

            listaProveedores.Tables[0].DefaultView.RowFilter = tipo + " LIKE '%" + busqueda + "%'";
            dgv_ListaProveedores.DataSource = listaProveedores.Tables[0].DefaultView;
        }

        private void ActualizarDGV()
        {
            listaProveedores = new Controladores.ControladorProveedores().cargarProveedor();
            dgv_ListaProveedores.DataSource = listaProveedores.Tables[0];
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            mtb_Cif.Text = "";
            txt_Nombre.Text = "";
            mtb_Movil.Text ="";
            lbl_ErrorCIF.Visible = false;
            lbl_ErrorNombre.Visible = false;
            lbl_ErrorTelefono.Visible = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los proveedores seleccionadas se van a eliminar.\n¿ESTAS SEGURO? ", "ELMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int contadorBorrados = 0;
                foreach (DataGridViewRow fila in dgv_ListaProveedores.SelectedRows)
                {
                    if (new Controladores.ControladorProveedores().eliminarProveedor((string)fila.Cells[0].Value))
                    { 
                        contadorBorrados++;
                    }
                }
                ActualizarDGV();
                MessageBox.Show("Se han eliminado " + contadorBorrados.ToString() + " Proveedores");
            }
        }
    }
}

