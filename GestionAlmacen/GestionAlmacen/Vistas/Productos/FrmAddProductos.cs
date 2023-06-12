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

namespace GestionAlmacen.Vistas.Productos
{
    public partial class FrmAddProductos : Form
    {
        internal DataSet listaProductos;
        public FrmAddProductos()
        {
            InitializeComponent();
        }
        private void FrmAddProductos_Load(object sender, EventArgs e)
        {
            //cargo los clientes en la lista
            listaProductos = new Controladores.ControladorProductos().cargarProductos();
            //Muestro los clientes
            dgv_ListaProductos.DataSource = listaProductos.Tables[0];
            dgv_ListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Creo lista para recuperar los campos y asi elegir que campo buscar.
            List<string> listaAtributos = new Producto().RecuperarCamposProductos();
            cmb_Buscar.DataSource = listaAtributos;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                string codigo = mtb_Codigo.Text;
                string nombre = txt_Nombre.Text;
                string descripcion = txt_Descripcion.Text;
                string categoria = txt_Categoria.Text;
                string marca = txt_Marca.Text;
                if (new Controladores.ControladorProductos().AddProducto(codigo, nombre, descripcion, categoria, marca))
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
            //Metodo para que los campos no esten vacios
            bool valido = true;

            string codigo = mtb_Codigo.Text ;
            string nombre = txt_Nombre.Text;
            string descripcion = txt_Descripcion.Text;
            string categoria = txt_Categoria.Text;
            string marca = txt_Marca.Text;
            if (codigo == "")
            {
                lbl_ErrorCodigo.Visible = true;
                valido = false;
            }
            if (nombre == "")
            {
                lbl_ErrorNombre.Visible = true;
                valido = false;
            }
            if (descripcion == "")
            {
                lbl_ErrorDescripcion.Visible = true;
                valido = false;
            }
            if (categoria == "")
            {
                lbl_ErrorCategoria.Visible = true;
                valido = false;
            }
            if (marca == "")
            {
                lbl_ErrorMarca.Visible = true;
                valido = false;
            }
            return valido;
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txt_Buscar.Text.Trim();
            string tipo = cmb_Buscar.Text;
            //Actualizo el dgv por los productos que coincidan en el filtro
            listaProductos.Tables[0].DefaultView.RowFilter = tipo + " LIKE '%" + busqueda + "%'";
            dgv_ListaProductos.DataSource = listaProductos.Tables[0].DefaultView;
        }

        private void btn_GenerarCodigo_Click(object sender, EventArgs e)
        {
            //Compruebo que el campo no este vacio
            if (mtb_Codigo.Text != "")
            {
                //Instalar Zen.Barcode.Rendering.Framework --> NuGet
                Zen.Barcode.Code128BarcodeDraw mGeneradorCB = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum; //tipo de codigo de barras

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                saveFileDialog.FileName = mtb_Codigo.Text + ".png";
                if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string codigoBarras = saveFileDialog.FileName;
                    Bitmap bitmap = new Bitmap(mGeneradorCB.Draw(mtb_Codigo.Text, 60));//Genera la imagen 
                    bitmap.Save(codigoBarras);

                }
            }
            else
            {
                lbl_ErrorCodigo.Visible = true;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            //Restablecer los campos 
            mtb_Codigo.Text = "";
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            txt_Categoria.Text = "";
            txt_Marca.Text = "";
            lbl_ErrorCodigo.Visible = false;
            lbl_ErrorNombre.Visible = false;
            lbl_ErrorDescripcion.Visible = false;
            lbl_ErrorCategoria.Visible = false;
            lbl_ErrorMarca.Visible = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //Mensaje de confirmacion si quieres eliminar lo seleccionado en el dgv
            if (MessageBox.Show("Los productos seleccionadas se van a eliminar.\n¿ESTAS SEGURO? ", "ELMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int contadorBorrados = 0;
                foreach (DataGridViewRow fila in dgv_ListaProductos.SelectedRows)
                {
                    //Recorre los datos seleccionados para ser eliminados
                    if (new Controladores.ControladorProductos().eliminarProducto((string)fila.Cells[0].Value))
                    {
                        contadorBorrados++;
                    }
                }
                ActualizarDGV();
                MessageBox.Show("Se han eliminado " + contadorBorrados.ToString() + " Produdtos");
            }
        }
        private void ActualizarDGV()
        {
            //Actualizar el dgv despues de añadir nuevos o eliminar productos
            listaProductos = new Controladores.ControladorProductos().cargarProductos();
            dgv_ListaProductos.DataSource = listaProductos.Tables[0];
        }
    }
}
