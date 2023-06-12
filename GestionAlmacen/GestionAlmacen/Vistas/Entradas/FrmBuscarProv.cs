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
    public partial class FrmBuscarProv : Form
    {
        //Variables publicas para poder recuperar los datos selecionados.
        public string CifProv { get; set; }
        public string NomProv { get; set; }

        internal DataSet listaProveedores;
        public FrmBuscarProv()
        {
            InitializeComponent();
        }

        private void FrmBuscarProv_Load(object sender, EventArgs e)
        {
            //cargo los proveedores en la lista
            listaProveedores = new Controladores.ControladorProveedores().cargarProveedor();
            //Muestro los proveedores
            dgv_ListaProveedores.DataSource = listaProveedores.Tables[0];
            //dgv_ListaProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Creo lista para recuperar los campos y asi elegir que campo buscar.
            List<string> listaAtributos = new Proveedor().RecuperarCamposProveedor();
            cmb_Buscar.DataSource = listaAtributos;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string tipo = cmb_Buscar.Text;
            string busqueda = txt_Buscar.Text.Trim();
            //Muestro los datos que coinden con  la busqueda
            listaProveedores.Tables[0].DefaultView.RowFilter = tipo + " LIKE '%" + busqueda + "%'";
            dgv_ListaProveedores.DataSource = listaProveedores.Tables[0].DefaultView;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (dgv_ListaProveedores.SelectedRows.Count > 0)
            {
                //Selecciona el cif y nombre del proveedor
                CifProv = dgv_ListaProveedores.SelectedRows[0].Cells[0].Value.ToString();
                NomProv = dgv_ListaProveedores.SelectedRows[0].Cells[1].Value.ToString();
                //MessageBox.Show(CifProv + " " + NomProv);
                this.Close();
            }
        }


    }
}
