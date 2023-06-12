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
    
    public partial class FrmBuscarProd : Form
    {
        //Variables publicas para poder recuperar los datos desde otro formulario
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        internal DataSet listaProductos;
        public FrmBuscarProd()
        {
            InitializeComponent();
        }
        private void FrmBuscarProd_Load(object sender, EventArgs e)
        {   //cargo los productos en la lista
            listaProductos = new Controladores.ControladorProductos().cargarProductos();
            //Muestro los productos
            dgv_ListaProductos.DataSource = listaProductos.Tables[0];
            //dgv_ListaProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Creo lista para recuperar los campos y asi elegir que campo buscar.
            List<string> listaAtributos = new Producto().RecuperarCamposProductos();
            cmb_Buscar.DataSource = listaAtributos;

        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txt_Buscar.Text.Trim();
            string tipo = cmb_Buscar.Text;
            //Filtro que enseña coincidencias con la busqueda
            listaProductos.Tables[0].DefaultView.RowFilter = tipo + " LIKE '%" + busqueda + "%'";
            dgv_ListaProductos.DataSource = listaProductos.Tables[0].DefaultView;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (dgv_ListaProductos.SelectedRows.Count > 0)
            {
                //Selecciona el cif, nombre y descripcion del producto
                Codigo = dgv_ListaProductos.SelectedRows[0].Cells[0].Value.ToString();
                Nombre = dgv_ListaProductos.SelectedRows[0].Cells[1].Value.ToString();
                Descripcion = dgv_ListaProductos.SelectedRows[0].Cells[2].Value.ToString();
                this.Close();
            }
        }        
    }
}
