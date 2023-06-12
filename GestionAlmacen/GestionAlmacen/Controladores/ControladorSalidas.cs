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
    public class ControladorSalidas
    {
        /// <summary>
        /// Metodo que añade una nueva Salida en la tabla de la base de datos  
        /// </summary>
        /// <param name="numDoc"></param>
        /// <param name="fechaSalida"></param>
        /// <param name="cifCliente"></param>
        /// <param name="nomCliente"></param>
        /// <param name="codProd"></param>
        /// <param name="nomProd"></param>
        /// <param name="descripcion"></param>
        /// <param name="cantProd"></param>
        /// <returns>Si la Salida se añadio con exito devuelve true</returns>
        public bool AddSalida(string numDoc, DateTime fechaSalida, string cifCliente, string nomCliente, string codProd, string nomProd, string descripcion, int cantProd)
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
                    comando.CommandText = "INSERT INTO Salidas (NumDoc, FechaSalida, CifCliente, NombreCliente, CodProd, NombreProd, Descripcion, CantidadProd)" +
                                            " VALUES (@numDoc, @fechaSalida,@cifCliente,@nombreCliente,@codigoProd,@nombreProd,@descripcion,@cantidadProd)";
                    comando.Parameters.AddWithValue("@numDoc", numDoc);
                    comando.Parameters.AddWithValue("@fechaSalida", fechaSalida);
                    comando.Parameters.AddWithValue("@cifCliente", cifCliente);
                    comando.Parameters.AddWithValue("@nombreCliente", nomCliente);
                    comando.Parameters.AddWithValue("@codigoProd", codProd);
                    comando.Parameters.AddWithValue("@nombreProd", nomProd);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@cantidadProd", cantProd);
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
                    Console.WriteLine("Error al crear salida" + e.Message);
                }
                return respuesta;
            }
        }
        /// <summary>
        /// Metodo que recupera todos los datos de la tabla Salidas de la base de datos
        /// </summary>
        /// <returns>Devuelve un DataSet relleno con los datos de tabla Salidas</returns>
        public DataSet cargarSalidas()
        {
            DataSet dataSet = new DataSet();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Salidas", cnn);
                dataAdapter.Fill(dataSet);

                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo fichero salidas " + e.Message);
            }
            return dataSet;
        }
    }
}
