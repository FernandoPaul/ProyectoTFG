using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlmacen.Controladores
{
    public class ControladorProductos
    {
        /// <summary>
        /// Metodo que añade un nuevo Producto a la base de datos
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="categoria"></param>
        /// <param name="marca"></param>
        /// <returns>Si el producto se añade con exito devuelve true</returns>
        public bool AddProducto(string codigo, string nombre, string descripcion, string categoria, string marca)
        {
            bool respuesta = false;

            string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    MySqlCommand comando = cnn.CreateCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO Productos ( Codigo, Nombre, Descripcion, Categoria, Marca) " +
                                            " VALUES (@codigo,@nombre,@descripcion,@categoria,@marca)";
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@categoria", categoria);
                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Prepare();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter();
                    adaptador.InsertCommand = comando;
                    if (adaptador.InsertCommand.ExecuteNonQuery() != 0) //ExecuteNonQuery devuelve las filas que han sido cambiadas
                    {
                        respuesta = true;
                    }
                    comando.Dispose();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al crear producto" + e.Message);
                }
                return respuesta;
            }
        }
        /// <summary>
        /// Metodo que recupera todos los datos de la tabla Productos de la base de datos
        /// </summary>
        /// <returns>Devuelve un DataSet relleno con los datos de tabla Productos</returns>
        public DataSet cargarProductos()
        {
            DataSet dataSet = new DataSet();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Productos", cnn);
                dataAdapter.Fill(dataSet);

                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo fichero productos " + e.Message);
            }
            return dataSet;
        }
        /// <summary>
        /// Metodo que elimina los productos que coincidan con el codigo pasado.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>si el producto es eliminado devuelve true</returns>
        public bool eliminarProducto(string codigo)
        {
            bool respuesta = false;
            Console.WriteLine(codigo);
            string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    MySqlCommand comando = cnn.CreateCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "DELETE FROM Productos WHERE Codigo = @codigo";
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    comando.Prepare();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter();
                    adaptador.InsertCommand = comando;
                    //ExecuteNonQuery devuelve las filas que han sido cambiadas
                    if (adaptador.InsertCommand.ExecuteNonQuery() != 0)
                    {
                        respuesta = true;
                    }
                    comando.Dispose();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al borrar en la tabla Productos" + e.Message);
                }
                return respuesta;
            }
        }
    }
}
