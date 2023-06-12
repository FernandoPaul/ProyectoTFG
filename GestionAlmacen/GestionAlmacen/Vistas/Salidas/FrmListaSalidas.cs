using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen.Vistas.Salidas
{
    public partial class FrmListaSalidas : Form
    {
        internal DataSet lista;
        public FrmListaSalidas()
        {
            InitializeComponent();
        }
        private void FrmListaSalidas_Load(object sender, EventArgs e)
        {
            //cargar lista con las salidas de la base de datos
            lista = new Controladores.ControladorSalidas().cargarSalidas();
            dgv_Lista.DataSource = lista.Tables[0];

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {   
            DateTime inicio = dtp_FechaInicio.Value;
            DateTime fin = dtp_FechaFin.Value;
            string tipo = "FechaSalida";
            //filtro para enseñar las salidas hechas entre las dos fechas
            lista.Tables[0].DefaultView.RowFilter = tipo + " >= '" + inicio + "' AND " + tipo + " <= '" + fin + "'";
            Console.WriteLine(inicio + ", " + fin);
            dgv_Lista.DataSource = lista.Tables[0].DefaultView;
        }

        private void btn_Descargar_Click(object sender, EventArgs e)
        {
            //Descargar Excel con las salidas totales
            SLDocument oSLDocument = new SLDocument();
            DataTable excel = new DataTable();
            //COLUMNAS DEL EXCEL
            excel.Columns.Add("NumDoc", typeof(string));
            excel.Columns.Add("FechaEntrada", typeof(string));
            excel.Columns.Add("CifProv", typeof(string));
            excel.Columns.Add("NombreProv", typeof(string));
            excel.Columns.Add("CodProd", typeof(string));
            excel.Columns.Add("NombreProd", typeof(string));
            excel.Columns.Add("Descripcion", typeof(string));
            excel.Columns.Add("CantidadProd", typeof(int));

            //REGISTRO DEL STOCK
            DataTable tabla = lista.Tables[0];
            DataColumn numDoc = tabla.Columns[0]; // Accedemos a la primera columna (numDoc)
            DataColumn fecha = tabla.Columns[1];
            DataColumn cifProv = tabla.Columns[2];
            DataColumn nProv = tabla.Columns[3];
            DataColumn cod = tabla.Columns[4];
            DataColumn nProd = tabla.Columns[5];
            DataColumn descripcion = tabla.Columns[6];
            DataColumn cantidad = tabla.Columns[7];
            //Recorro todo la Tabla Salidas para añadir las filas al Excel
            foreach (DataRow fila in tabla.Rows)
            {
                Console.WriteLine(fila[numDoc]);
                string nDoc = (string)fila[numDoc];
                string date = Convert.ToString(fila[fecha]);
                string cif = (string)fila[cifProv];
                string prov = (string)fila[nProv];
                string code = (string)fila[cod];
                string prod = (string)fila[nProd];
                string desc = (string)fila[descripcion];
                int cant = (int)fila[cantidad];

                excel.Rows.Add(nDoc, date, cif, prov, code, prod, desc, cant);
            }
            //celda de referencia(row 1)(column 1),data table (informacion a insertar), incluir encabezados(true o false)
            oSLDocument.ImportDataTable(1, 1, excel, true);
            //Abrir explorador de archivos para elegir nombre y donde guardar
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Salidas.xlsx";
            savefile.Filter = "Excel Files|*.xlsx";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                oSLDocument.SaveAs(savefile.FileName);
                MessageBox.Show("Descarga Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            //Vuelve a mostrar todos los datos en DataGridView
            lista = new Controladores.ControladorSalidas().cargarSalidas();
            dgv_Lista.DataSource = lista.Tables[0];
        }

        
    }
}
