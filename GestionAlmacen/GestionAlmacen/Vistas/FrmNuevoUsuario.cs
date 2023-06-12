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
    public partial class FrmNuevoUsuario : Form
    {
        internal DataSet listaUsuarios;
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }
        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            listaUsuarios = new Controladores.ControladorUsuarios().cargarUsuarios();
            /*
            foreach (DataTable tabla in listaUsuarios.Tables)
            {
                Console.WriteLine("Tabla: " + tabla.TableName);
                
                foreach (DataRow fila in tabla.Rows)
                {

                    foreach (DataColumn columna in tabla.Columns)
                    {
                        Console.WriteLine(columna.ColumnName + ": " + fila[columna]);
                    }

                    Console.WriteLine();
                }

            }
            */
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                string nombre = txt_NombreCompleto.Text;
                string id = txt_Id.Text;
                string clave = txt_Clave.Text;
                string admin;
                if (cb_Administrador.Checked)
                {
                    admin = (string)cb_Administrador.Tag;
                }
                else
                {
                    admin = "N";
                }
                if (new Controladores.ControladorUsuarios().addUsuario(nombre,id,clave,admin))
                {
                    MessageBox.Show("Usuario nuevo guardado");
                    this.Close();
                }
            }
        }
        private bool ValidarDatos()
        {
            bool respuesta = true;

            string nombre = txt_NombreCompleto.Text;
            string id = txt_Id.Text;
            string clave = txt_Clave.Text;
            string repetirClave = txt_RepetirClave.Text;
            
            if (nombre == "")
            {
                MessageBox.Show("Nombre completo esta vacio");
                respuesta = false;
            }
            if (clave != repetirClave)
            {
                lbl_Error.Visible = true;
                respuesta = false;
            }

            DataTable tabla = listaUsuarios.Tables[0];
            DataColumn columna = tabla.Columns[1]; // Accedemos a la segunda columna (índice 1)
            //Recorro todo la Tabla Usuarios en busca de si existe el ID que quiere guardar.
            foreach (DataRow fila in tabla.Rows)
            {
                Console.WriteLine(fila[columna]);
                string usr = (string)fila[columna];
                if (usr == id)
                {
                    respuesta = false;
                    MessageBox.Show("El Id ya existe");
                }
            }
            return respuesta;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
