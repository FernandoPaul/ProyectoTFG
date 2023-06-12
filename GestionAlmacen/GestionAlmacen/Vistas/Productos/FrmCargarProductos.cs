using GestionAlmacen.Clases;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen.Vistas.Productos
{
    public partial class FrmCargarProductos : Form
    {
        private static global::System.Globalization.CultureInfo resourceCulture;
        public FrmCargarProductos()
        {
            InitializeComponent();
        }

        private void btn_DescargarPlantilla_Click(object sender, EventArgs e)
        {
            //Descargar Excel de platilla para poder hacer las cargas masivas
            try
            {
                //string ruta = "C:/Users/Paul/Desktop/PROYECTO/GestionAlmacen/GestionAlmacen/Recursos/PlantillaProductos.xlsx";
                string ruta = "../../Recursos/PlantillaProductos.xlsx";//ruta donde esta el archivo a descargar
                byte[] array = System.IO.File.ReadAllBytes(ruta);
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "PlantillaProductos.xlsx";
                savefile.Filter = "Excel Files|*.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(savefile.FileName, array.ToArray());
                    MessageBox.Show("Descarga Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error al descargar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //Abre una ventana donde puedes seleccionar el excel con los productos nuevos
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Excel Files|*.xlsx";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_NomArchivo.Text = oOpenFileDialog.FileName.ToString();
                //Leer Excel
                int indice = 1; //lee encabezados para ver si orden del documento es correcto
                SLDocument miArchivo = new SLDocument(txt_NomArchivo.Text);

                string enc1 = miArchivo.GetCellValueAsString(indice, 1); //codigo
                string enc2 = miArchivo.GetCellValueAsString(indice, 2); //nombre 
                string enc3 = miArchivo.GetCellValueAsString(indice, 3); //descripcion
                string enc4 = miArchivo.GetCellValueAsString(indice, 4); //categoria
                string enc5 = miArchivo.GetCellValueAsString(indice, 5); //marca
               
                //MessageBox.Show(enc1 + ", " + enc2 + ", " + enc3 + ", " + enc4 + ", "  + enc5, "ORDEN DEL FICHERO");
            }
        }

        private void btn_Subir_Click(object sender, EventArgs e)
        {   
            SLDocument miArchivo = new SLDocument(txt_NomArchivo.Text);
            int indice = 2; //1=encabezados, 2 >= Nuevos productos 
            //Mientras no sea nulo o vacio continua leyendo
            while (!string.IsNullOrEmpty(miArchivo.GetCellValueAsString(indice, 1)))
            {
                if (indice >= 2)
                {
                    //Obtener los datos del excel
                    string cod = miArchivo.GetCellValueAsString(indice, 1); //Nombre encabezado codigo
                    string nom = miArchivo.GetCellValueAsString(indice, 2); //Nombre 
                    string desc = miArchivo.GetCellValueAsString(indice, 3); //descripcion
                    string cat = miArchivo.GetCellValueAsString(indice, 4); //categoria
                    string marca = miArchivo.GetCellValueAsString(indice, 5); //marca
                    //Insertar los nuevos productos a la base de datos
                    if (new Controladores.ControladorProductos().AddProducto(cod, nom, desc, cat, marca))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dgv_Add);
                        fila.Cells[0].Value = cod;
                        fila.Cells[1].Value = nom;
                        fila.Cells[2].Value = desc;
                        fila.Cells[3].Value = cat;
                        fila.Cells[4].Value = marca;
                        dgv_Add.Rows.Add(fila);
                        Console.WriteLine("Producto guardado: " + cod + " " + nom);
                    }
                    else
                    {
                        MessageBox.Show("Error al subir producto:\n" + cod + ", " + nom);
                    }
                }
                indice++;
            }
        }
    }
}
