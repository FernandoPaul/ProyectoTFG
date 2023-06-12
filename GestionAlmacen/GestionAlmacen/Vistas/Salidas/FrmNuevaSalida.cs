using GestionAlmacen.Vistas.Entradas;
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
    public partial class FrmNuevaSalida : Form
    {
        internal DataSet listaInventario;
        internal DataSet listaSalidas;
        public FrmNuevaSalida()
        {
            InitializeComponent();
        }
        private void FrmNuevaSalida_Load(object sender, EventArgs e)
        {
            //Cargar los datos de la tabla Salida.
            listaSalidas = new Controladores.ControladorSalidas().cargarSalidas();
            int nDoc = NumeroDocumento() + 1;
            txt_NDocumento.Text = Convert.ToString(nDoc);
            //Cargar los datos de la tabla Inventario.
            listaInventario = new Controladores.ControladorInventario().cargarInventario();
            //Cargar la fecha del registro
            dtp_FechaRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            //Abre un pequeño formulario para elgir un cliente
            using (var form = new FrmBuscarCliente())
            {
                //ShowDialog hasta que no cierras el formulario no puedes acceder a los anteriores.
                var result = form.ShowDialog();
                if (result != DialogResult.OK)
                {
                    //cuando se cierre se rellenan los campos.
                    mtb_CifCliente.Text = form.CifCliente;
                    txt_NomCliente.Text = form.NomCliente;
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
                    //cuando se cierre se rellenan los campos
                    mtb_CodProd.Text = form.Codigo;
                    txt_NomProd.Text = form.Nombre;
                    txt_Descripcion.Text = form.Descripcion;
                }
            }
            txt_Stock.Text = Convert.ToString(Stock(mtb_CodProd.Text));
            nud_Cantidad.Maximum = Stock(mtb_CodProd.Text);
        }
        private int Stock(string codigo)
        {
            //METODO PARA OBTENER EL STOCK DISPONIBLE DE UN PRODUCTO EN EL ALMACEN
            int stock = 0;
            DataTable tabla = listaInventario.Tables[0];
            DataColumn columna = tabla.Columns[0]; // Accedemos a la primera columna (índice 1)
            DataColumn columnaCant = tabla.Columns[3]; //cantidad
            //Recorro todo la Tabla Inventario en busca de si existe el Codigo de producto que quiere guardar.
            foreach (DataRow fila in tabla.Rows)
            {
                Console.WriteLine(fila[columna]);
                string cod = (string)fila[columna];
                if (cod == codigo)
                {
                    stock = (int)fila[columnaCant];
                }
            }
            return stock;
        }

        private void btn_Anadir_Click(object sender, EventArgs e)
        {
            //Si los campos estan rellenos
            if (validarCampos())
            {
                //Insertar en fila
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv_Lista);
                fila.Cells[0].Value = txt_NDocumento.Text;
                fila.Cells[1].Value = dtp_FechaRegistro.Value;
                fila.Cells[2].Value = mtb_CifCliente.Text;
                fila.Cells[3].Value = txt_NomCliente.Text;
                fila.Cells[4].Value = mtb_CodProd.Text;
                fila.Cells[5].Value = txt_NomProd.Text;
                fila.Cells[6].Value = txt_Descripcion.Text;
                fila.Cells[7].Value = nud_Cantidad.Value;
                dgv_Lista.Rows.Add(fila);
            }
            else
            {
                MessageBox.Show("Hay campos sin rellenar");
            }
        }
        private bool validarCampos()
        {
            //Comprobar que los datos no esten vacios
            bool valor = true;
            string nDoc = txt_NDocumento.Text;
            DateTime fecha = dtp_FechaRegistro.Value;
            string cif = mtb_CifCliente.Text;
            string nCliente = txt_NomCliente.Text;
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
            if (nCliente == "")
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
        private int NumeroDocumento()
        {
            int nDoc = 0;
            DataTable tabla = listaSalidas.Tables[0];
            DataColumn columna = tabla.Columns[0]; // Accedemos a la primera columna (NumDoc)

            //Recorro todo la Tabla Entradas en busca del ultimo NumDoc guardado
            foreach (DataRow fila in tabla.Rows)
            {
                Console.WriteLine(fila[columna]);
                nDoc = Convert.ToInt32(fila[columna]);
            }
            return nDoc;
        }

        private void btn_GuardarSalidas_Click(object sender, EventArgs e)
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
                    string nCliente = dgv.Cells[3].Value.ToString();
                    string codigo = dgv.Cells[4].Value.ToString();
                    string nProd = dgv.Cells[5].Value.ToString();
                    string descripcion = dgv.Cells[6].Value.ToString();
                    int cantidad = Convert.ToInt32(dgv.Cells[7].Value);

                    bool guardar = false;
                    if (new Controladores.ControladorSalidas().AddSalida(nDoc, fecha, cif, nCliente, codigo, nProd, descripcion, cantidad))
                    {
                        guardar = true;
                    }
                    else
                    {
                        error += codigo + ", ";
                    }
                    Console.WriteLine(guardar.ToString());
                    //Si se añadido una nueva salida actualizar el inventario.
                    if (guardar)
                    {
                        actualizarInventario(codigo, nProd, descripcion, cantidad);
                    }
                }
            }
            if (error == "")
            {
                MessageBox.Show("Registro guardado con exito");
            }
            else
            {
                MessageBox.Show(error,"ERROR");
            }
            this.Close();
        }
        private void actualizarInventario(string codigo, string nProd, string descripcion, int cantidad)
        {
            bool nuevo = true;
            DataTable tabla = listaInventario.Tables[0];
            DataColumn columna = tabla.Columns[0]; // Accedemos a la primera columna (codigo)
            DataColumn columnaCant = tabla.Columns[3]; // 
            //Recorro todo la Tabla Inventario en busca de si existe el Codigo de producto que quiere guardar.
            foreach (DataRow fila in tabla.Rows)
            {
                Console.WriteLine(fila[columna]);
                string cod = (string)fila[columna];
                if (cod == codigo)
                {
                    int cant = (int)fila[columnaCant];
                    cantidad = cant - cantidad; //Actualizo la cantidad de producto
                    Console.WriteLine("El Codigo ya existe");
                    if (new Controladores.ControladorInventario().actualizarInventario(codigo, cantidad))
                    {
                        Console.WriteLine("Inventario Acutalizado. " + codigo + ", " + nProd + ", " + cantidad);
                    }
                }
            }
        }
    }
}
