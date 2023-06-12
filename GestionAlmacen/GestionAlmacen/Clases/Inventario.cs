using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlmacen.Clases
{
    public class Inventario
    {
        //ATRIBUTOS
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        //CONSTRUCTORES
        public Inventario()
        {

        }
        public Inventario(string codigo, string nombre, string descripcion, int cantidad)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
        }
        /// <summary>
        /// Metodo que recupera los campos para luego utilizarlos 
        /// </summary>
        /// <returns>devuelve una lista con los campos</returns>
        public List<string> RecuperarCamposInventario()
        {
            List<string> listaCampos = new List<string>();
            listaCampos.Add("Codigo");
            listaCampos.Add("Nombre");
            listaCampos.Add("Descripcion");
            return listaCampos;
        }
    }
}
