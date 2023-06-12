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
    public class ControladorInventario
    {
        /// <summary>
        /// Metodo que añade un nuevos productos a la tabla Inventario en la base de datos 
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="cantidad"></param>
        /// <returns>Si el producto se se añadio con exito al Inventario devuelve true</returns>
        public bool AddInventario(string codigo, string nombre, string descripcion, int cantidad)
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
                    comando.CommandText = "INSERT INTO Inventario ( Codigo, Nombre, Descripcion, Cantidad) " +
                                            " VALUES (@codigo,@nombre,@descripcion,@cantidad)";
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
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
                    Console.WriteLine("Error al crear inventario" + e.Message);
                }
                return respuesta;
            }
        }
        /// <summary>
        /// Metodo que recupera todos los datos de la tabla Inventario de la base de datos
        /// </summary>
        /// <returns>Devuelve un DataSet relleno con los datos de tabla Inventario</returns>
        public DataSet cargarInventario()
        {
            DataSet dataSet = new DataSet();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Inventario", cnn);
                dataAdapter.Fill(dataSet);

                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo fichero inventario " + e.Message);
            }
            return dataSet;
        }
        /// <summary>
        /// Metodo para actualizar la cantidad que hay en el inventario tras hacer una Entrada o Salida de producto
        /// </summary>
        /// <param name="dataSet">Parametro con todos los datos de la tabla</param>
        /// <returns>Si se actualiza con exito devuelve true</returns>
        public bool actualizarInventario(string codigo, int cantidad)
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
                    comando.CommandText = "UPDATE Inventario SET Cantidad = @Cantidad WHERE Codigo = @codigo";
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
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
                    Console.WriteLine("Error al crear inventario" + e.Message);
                }
            }
            return respuesta;
        }
    }
}
