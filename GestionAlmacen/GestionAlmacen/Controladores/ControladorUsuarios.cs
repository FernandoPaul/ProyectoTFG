using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlmacen.Controladores
{
    public class ControladorUsuarios
    {
        internal DataSet lista = new DataSet();
        /// <summary>
        /// Metodo que crea un primer usuarios si no existen ningun usuarios creado en la base de datos.
        /// </summary>
        /// <param name="nombreCompleto"></param>
        /// <param name="id"></param>
        /// <param name="clave"></param>
        /// <param name="administrador"></param>
        /// <returns>Si no hay usuarios en la base de datos crea un usuario</returns>
        public bool crearPrimerUsuario(string nombreCompleto, string id, string clave, string administrador)
        {
            lista = cargarUsuarios();
            if (lista.Tables[0].Rows.Count == 0)
            {
                addUsuario(nombreCompleto, id, clave, administrador);
            }
            return true;
        }
        /// <summary>
        /// Metodo que añade un nuevo usuario en la base de datos 
        /// </summary>
        /// <param name="nombreCompleto"></param>
        /// <param name="id"></param>
        /// <param name="clave"></param>
        /// <param name="administrador"></param>
        /// <returns>Si se añade con exito devuelve true</returns>
        public bool addUsuario(string nombreCompleto, string id, string clave, string administrador)
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
                    comando.CommandText = "INSERT INTO Usuarios(NombreCompleto, Id, Clave, Administrador)" +
                                            " VALUES (@nombrecompleto,@id,@clave,@administrador)";
                    comando.Parameters.AddWithValue("@nombrecompleto", nombreCompleto);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@clave", generarClaveSHA1(clave)); //Encripta la clave
                    comando.Parameters.AddWithValue("@administrador", administrador);

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
                    Console.WriteLine("Error al crear usuario" + e.Message);
                }
            }

            return respuesta;
        }
        /// <summary>
        /// Metodo que comprueba que los parametros coinciden con algun Usuario en la base de datos 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clave"></param>
        /// <returns>Si los paramentros coinciden con algun Usuario devuelve true</returns>
        public bool validarUsuario(string id, string clave)
        {
            bool respuesta = true;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Clave FROM Usuarios WHERE Id = @id";
                comando.Parameters.AddWithValue("@id", id);
                comando.Prepare();
                MySqlDataReader dataReader = comando.ExecuteReader();

                //Si hay algun usuario que cumpla la condicion comprobar clave
                if (dataReader.Read())
                {
                    //Convierte en un Array de bytes los datos devueltos de la SELECT
                    byte[] claveLeida = Encoding.Default.GetBytes((string)dataReader.GetValue(0));
                    //Si las calves no coinciden el bool cambio a false
                    if (compararClaveSHA1(claveLeida, generarClaveSHA1(clave)))
                    {
                        GrabarLog(DateTime.Now.ToString() + " el usuario " + id + " ha entrado en el sistema");
                    }
                    else
                    {
                        GrabarLog(DateTime.Now.ToString() + " el usuario " + id + " ha intentado entrar en el sistema con la clave incorrecta");
                        respuesta = false;
                    }
                }
                else
                {
                    GrabarLog(DateTime.Now.ToString() + " el usuario " + id + " ha intentado entrar en el sistema");
                    respuesta = false;
                }
                dataReader.Close();
                comando.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la conexión " + e.Message);
                respuesta = false;
            }
            return respuesta;
        }
        /// <summary>
        /// Metodo que escribe en un fichero de texto los usuarios que quiere acceder y accede al sistema
        /// </summary>
        /// <param name="texto"></param>
        public static void GrabarLog(string texto)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"controlAcceso.log", true))
                {
                    file.WriteLine(texto);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo XML" + e.Message);
            }
        }
        /// <summary>
        /// Metodo que recibe un parametro y encripta la clave en SHA-256 
        /// que utiliza funciones que producen hashes de 32 bits de longitud
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Devuelve un array de bytes con la clave encriptada</returns>
        public byte[] generarClaveSHA1(string cadena)
        {
            byte[] claveHash;
            UnicodeEncoding ue = new UnicodeEncoding();
            byte[] messageBytes = ue.GetBytes(cadena);
            SHA256 shHash = SHA256.Create();
            claveHash = shHash.ComputeHash(messageBytes);
            return claveHash;
        }
        /// <summary>
        /// Metodo que comprueba si las dos parametros coindicen
        /// </summary>
        /// <param name="cadena1"></param>
        /// <param name="cadena2"></param>
        /// <returns>Si coinciden devuelve true</returns>
        private bool compararClaveSHA1(byte[] cadena1, byte[] cadena2)
        {
            bool sonIguales = true;
            //Compara los valores de dos arrays de bytes
            for (int x = 0; x < cadena1.Length; x++)
            {
                if (cadena1[x] != cadena2[x])
                {
                    sonIguales = false;
                }
            }
            return sonIguales;
        }
        /// <summary>
        /// Metodo que recupera todos los datos de la tabla Usuarios de la base de datos
        /// </summary>
        /// <returns>Devuelve un DataaSet relleno con los datos de tabla Usuarios</returns>
        public DataSet cargarUsuarios()
        {
            DataSet dataSet = new DataSet();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM Usuarios", cnn);
                dataAdapter.Fill(dataSet);

                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo fichero usuarios " + e.Message);
            }
            return dataSet;
        }
        /// <summary>
        /// Metodo para comprobar si el usuario que entra al systema es admin
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Si es cierto devuelve true</returns>
        public bool esAdmin(string id)
        {
            bool respuesta = false;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["GestionAlmacen.Properties.Settings.databaseConnectionString"].ConnectionString;
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Administrador FROM Usuarios WHERE Id = @id";
                comando.Parameters.AddWithValue("@id", id);
                comando.Prepare();
                MySqlDataReader dataReader = comando.ExecuteReader();
                //Lee el resultado de la consulta 
                if (dataReader.Read())
                {
                    string admin = dataReader.GetValue(0).ToString();
                    if (admin.Equals("Y"))
                    {
                        Console.WriteLine("coinciden");
                        return true;
                    }else
                    {
                        Console.WriteLine(admin);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la conexión " + e.Message);
                respuesta = false;
            }
            return respuesta;
        }
    }
}
