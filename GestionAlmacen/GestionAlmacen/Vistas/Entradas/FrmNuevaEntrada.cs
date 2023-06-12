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
    public partial class FrmNuevaEntrada : Form
    {
        internal DataSet listaEntradas;
        internal DataSet listaInventario;
        public FrmNuevaEntrada()
        {
            InitializeComponent();
        }
        private void FrmNuevaEntrada_Load(object sender, EventArgs e)
        {   //Cargar los datos de la tabla Entrada.
            listaEntradas = new Controladores.ControladorEntradas().cargarEntrada();
            //Sumo 1 al ultimo Numero de Documento registrado
            int nDoc = NumeroDocumento() + 1;
            txt_NDocumento.Text = Convert.ToString(nDoc);
            dtp_FechaRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //Cargar los datos de la tabla Inventario.
            listaInventario = new Controladores.ControladorInventario().cargarInventario();
        }

        private void btn_BuscarProv_Click(object sender, EventArgs e)
        {
            //Abre un pequeño formulario para elgir un proveedor
            using (var form = new FrmBuscarProv())
            {
                //ShowDialog hasta que no cierras el formulario no puedes acceder a los anteriores.
                var result = form.ShowDialog();
                if (result != DialogResult.OK)
                {
                    //cuando se cierre se rellenan los campos.
                    mtb_CifProv.Text = form.CifProv;
                    txt_NomProv.Text = form.NomProv;
                }
            }
        }
        private void btn_BuscarProd_Click(object sender, EventArgs e)
        {
            //Abre un pequeño formulario para elgir un producto
            using (var form = new FrmBuscarProd())
            {
                //ShowDialog hasta que no cierras el formulario no puedes acceder a los anteriores.
                var result = form.ShowDialog();
                if (result != DialogResult.OK)
                {
                    //cuando se cierre se rellenan los campos.
                    mtb_CodProd.Text = form.Codigo;
                    txt_NomProd.Text = form.Nombre;
                    txt_Descripcion.Text = form.Descripcion;
                }
            }
        }
        private void btn_Anadir_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                //Insertar los datos en el DataGridView
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv_Lista);
                fila.Cells[0].Value = txt_NDocumento.Text; 
                fila.Cells[1].Value = dtp_FechaRegistro.Value;
                fila.Cells[2].Value = mtb_CifProv.Text;
                fila.Cells[3].Value = txt_NomProv.Text;
                fila.Cells[4].Value = mtb_CodProd.Text;
                fila.Cells[5].Value = txt_NomProd.Text;
                fila.Cells[6].Value = txt_Descripcion.Text;
                fila.Cells[7].Value = nud_Cantidad.Value;
                dgv_Lista.Rows.Add(fila);
            }
        }
        private bool validarCampos()
        {
            //Metodo para validar que los campos no estan vacios
            bool valor = true;
            string nDoc = txt_NDocumento.Text;
            DateTime fecha = dtp_FechaRegistro.Value;
            string cif = mtb_CifProv.Text;
            string nProv = txt_NomProv.Text;
            string codigo = mtb_CodProd.Text;
            string nProd = txt_NomProd.Text;
            string descripcion = txt_Descripcion.Text;
            int cantidad = (int)nud_Cantidad.Value;

            if (nDoc == "")
            {
                valor = false;
            }
            if (fecha < DateTime.Today)
            {
                valor = false;
            }
            if (cif == "")
            {
                valor = false;
            }
            if (nProv == "")
            {
                valor = false;
            }
            if (codigo == "")
            {
                valor = false;
            }
            if (nProd == "")
            {
                valor = false;
            }
            if (descripcion == "")
            {
                valor = false;
            }
            if (cantidad < 0)
            {
                valor = false;
            }
            return valor;
        }
        private void btn_GuardarEntradas_Click(object sender, EventArgs e)
        {
            string error = "";
            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow dgv in dgv_Lista.Rows)
            {
                // Verificar si la fila no es una fila de encabezado y está completa
                if (!dgv.IsNewRow && dgv.Cells.Count > 0)
                {
                    //Recojo todos los valores para hacer una nueva entrada
                    string nDoc = dgv.Cells[0].Value.ToString();
                    DateTime fecha = (DateTime)dgv.Cells[1].Value;
                    string cif = dgv.Cells[2].Value.ToString();
                    string nProv = dgv.Cells[3].Value.ToString();
                    string codigo = dgv.Cells[4].Value.ToString();
                    string nProd = dgv.Cells[5].Value.ToString();
                    string descripcion = dgv.Cells[6].Value.ToString();
                    int cantidad = Convert.ToInt32(dgv.Cells[7].Value);
                    
                    bool guardar = false;
                    if (new Controladores.ControladorEntradas().AddEntrada(nDoc,fecha,cif,nProv,codigo,nProd,descripcion,cantidad))
                    {   
                        guardar = true;
                    }
                    else
                    {
                        error += codigo + ", ";
                    }
                    Console.WriteLine(guardar.ToString());
                    //Si se añadido una nueva entrada actualizar el inventario.
                    if (guardar)
                    {
                        actualizarInventario(codigo,nProd,descripcion,cantidad);
                    }
                }
            }
            if (error == "")
            {
                MessageBox.Show("Registro guardado con exito");
            }
            else
            {
                MessageBox.Show(error);
            }
            this.Close();
            
        }
        private void actualizarInventario(string codigo,string nProd, string descripcion, int cantidad)
        {
            bool nuevo = true;

            DataTable tabla = listaInventario.Tables[0];
            DataColumn columna = tabla.Columns[0]; // Accedemos a la primera columna (codigo)
            DataColumn columnaCant = tabla.Columns[3]; // cantidad de producto actualmente
            //Recorro todo la Tabla Inventario en busca de si existe el Codigo de producto que quiere guardar.
            foreach (DataRow fila in tabla.Rows)
            {
                Console.WriteLine(fila[columna]);
                string cod = (string)fila[columna];
                if (cod == codigo)
                {
                    nuevo = false;
                    int cant = (int) fila[columnaCant];
                    cantidad = cantidad + cant; //Actualizo la cantidad de producto
                    Console.WriteLine("El Codigo de producto ya existe");
                    if (new Controladores.ControladorInventario().actualizarInventario(codigo, cantidad))
                    {
                        Console.WriteLine("Inventario Acutalizado. " + codigo + ", " + nProd + ", " + cantidad);
                    }  
                }
            }
            //Si es nuevo entonces introduce un nuevo Producto al inventario
            if (nuevo)
            {
                if (new Controladores.ControladorInventario().AddInventario(codigo, nProd, descripcion, cantidad))
                {
                    Console.WriteLine("Nuevo producto en el Inventario: " + codigo + ", " + nProd + ", " + cantidad);
                }
            }
        }
        /// <summary>
        /// Metodo que devuelve el ultimo numero de documento guardado
        /// </summary>
        /// <returns>Devuelve un numero entero</returns>
        private int NumeroDocumento() 
        {
            int nDoc = 0;
            DataTable tabla = listaEntradas.Tables[0];
            DataColumn columna = tabla.Columns[0]; // Accedemos a la primera columna (NumDoc)

            //Recorro todo la Tabla Entradas en busca del ultimo NumDoc guardado
            foreach (DataRow fila in tabla.Rows)
            {
                Console.WriteLine(fila[columna]);
                nDoc = Convert.ToInt32(fila[columna]);
            }
            return nDoc;
        }
    }
}
