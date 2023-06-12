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
    public class ControladorEntradas
    {
        /// <summary>
        /// Metodo que añade un nueva Entrada en la base de datos 
        /// </summary>
        /// <param name="numDoc"></param>
        /// <param name="fechaEntrada"></param>
        /// <param name="cifProv"></param>
        /// <param name="nomProv"></param>
        /// <param name="codProd"></param>
        /// <param name="nomProd"></param>
        /// <param name="descripcion"></param>
        /// <param name="cantProd"></param>
        /// <returns>Si la Entrada se añadio con exito devuelve true</returns>
        public bool AddEntrada(string numDoc, DateTime fechaEntrada, string cifProv, string nomProv, string codProd, string nomProd, string descripcion, int cantProd)
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
                    comando.CommandText = "INSERT INTO Entradas (NumDoc, FechaEntrada, CifProv, NombreProv, CodProd, NombreProd, Descripcion, CantidadProd) " +
                                            " VALUES (@numDoc, @fechaEntrada,@cifProv,@nombreProv,@codigoProd,@nombreProd,@descripcion,@cantidadProd)";
                    comando.Parameters.AddWithValue("@numDoc", numDoc);
                    comando.Parameters.AddWithValue("@fechaEntrada", fechaEntrada);
                    comando.Parameters.AddWithValue("@cifProv", cifProv);
                    comando.Parameters.AddWithValue("@nombreProv", nomProv);
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
                    Console.WriteLine("Error al crear entrada" + e.Message);
                }
                return respuesta;
            }
        }
        /// <summary>
        /// Metodo que recupera todos los datos de la tabla Entradas de la base de datos
        /// </summary>
        /// <returns>Devuelve un DataSet relleno con los datos de tabla Entradas</returns>
        public DataSet cargarEntrada()
        {
            DataSet dataSet = new DataSet();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Entradas", cnn);
                dataAdapter.Fill(dataSet);

                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo fichero entradas " + e.Message);
            }
            return dataSet;
        }
    }
}

