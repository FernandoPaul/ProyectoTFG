using GestionAlmacen.Clases;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen.Vistas
{
    public partial class FrmInventario : Form
    {
        internal DataSet Inventario;
        public FrmInventario()
        {
            InitializeComponent();
            //Cargo el dgv con los datos de la tabla Inventario
            Inventario = new Controladores.ControladorInventario().cargarInventario();
            dgv_Inventario.DataSource = Inventario.Tables[0];

            //Creo lista para recuperar los campos y asi elegir que campo buscar.
            List<string> listaAtributos = new Inventario().RecuperarCamposInventario();
            cmb_Buscar.DataSource = listaAtributos;
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txt_Buscar.Text.Trim();
            string tipo = cmb_Buscar.Text;
            //filtro que coincide parcialmente con la busqueda
            Inventario.Tables[0].DefaultView.RowFilter = tipo + " LIKE '%" + busqueda + "%'";
            dgv_Inventario.DataSource = Inventario.Tables[0].DefaultView;
        }

        private void btn_Descargar_Click(object sender, EventArgs e)
        {
            //Guardar un Documento Excel con todos los productos que hay en el inventario
            SLDocument oSLDocument = new SLDocument();
            DataTable excel = new DataTable();
            //COLUMNAS DEL EXCEL
            excel.Columns.Add("Codigo", typeof(string));
            excel.Columns.Add("Nombre", typeof(string));
            excel.Columns.Add("Descripcion", typeof(string));
            excel.Columns.Add("Cantidad", typeof(int));

            //REGISTRO DEL STOCK
            DataTable tabla = Inventario.Tables[0];
            DataColumn codigo = tabla.Columns[0]; // Accedemos a la primera columna (codigo)
            DataColumn nombre = tabla.Columns[1]; 
            DataColumn descripcion = tabla.Columns[2]; 
            DataColumn cantidad = tabla.Columns[3];
                //Recorro todo la Tabla Inventario en busca de si existe el Codigo de producto que quiere guardar.
            foreach (DataRow fila in tabla.Rows)
            {
                Console.WriteLine(fila[codigo]);
                string cod = (string)fila[codigo];
                string nom = (string)fila[nombre];
                string desc = (string)fila[descripcion];
                int cant = (int)fila[cantidad];

                excel.Rows.Add(cod,nom,desc,cant);
            }
            //celda de referencia(row 1)(column 1),data table (informacion a insertar), incluir encabezados(true o false)
            oSLDocument.ImportDataTable(1, 1, excel, true);
            //Abrir explorador de archivos para elegir nombre y donde guardar
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Inventario.xlsx";
            savefile.Filter = "Excel Files|*.xlsx";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                oSLDocument.SaveAs(savefile.FileName);
                MessageBox.Show("Descarga Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
