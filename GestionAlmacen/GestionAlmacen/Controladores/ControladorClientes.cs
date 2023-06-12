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
    public class ControladorClientes
    {
        /// <summary>
        /// Metodo que añade un nuevo cliente en la base de datos 
        /// </summary>
        /// <param name="cif"></param>
        /// <param name="nombre"></param>
        /// <param name="telefono"></param>
        /// <returns>Si el cliente se añadio con exito devuelve true</returns>
        public bool AddCliente(string cif, string nombre, string telefono)
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
                    comando.CommandText = "INSERT INTO Clientes ( CIF, Nombre, Telefono) " +
                                            " VALUES (@cif,@nombre,@telefono)";
                    comando.Parameters.AddWithValue("@cif", cif);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@telefono", telefono);
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
                    Console.WriteLine("Error al crear clientes" + e.Message);
                }
                return respuesta;
            }
        }
        /// <summary>
        /// Metodo que recupera todos los datos de la tabla Cliente de la base de datos
        /// </summary>
        /// <returns>Devuelve un DataSet relleno con los datos de tabla Clientes</returns>
        public DataSet cargarClientes()
        {
            DataSet dataSet = new DataSet();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Clientes", cnn);
                dataAdapter.Fill(dataSet);

                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo fichero clientes " + e.Message);
            }
            return dataSet;
        }
        /// <summary>
        /// Metodo que elimina de la base de datos los clientes que coincidan con el cif pasado
        /// </summary>
        /// <param name="cif"></param>
        /// <returns>Si el cliente se elimina con exito devuelve true </returns>
        public bool eliminarCliente(string cif)
        {
            bool respuesta = false;
            Console.WriteLine(cif);
            string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
            using (MySqlConnection cnn = new MySqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    MySqlCommand comando = cnn.CreateCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "DELETE FROM Clientes WHERE CIF = @cif";
                    comando.Parameters.AddWithValue("@cif", cif);
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
                    Console.WriteLine("Error al borrar en la tabla Clientes" + e.Message);
                }
                return respuesta;
            }
        }
    }
}