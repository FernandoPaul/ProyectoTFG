using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlmacen.Clases
{
    public class Producto
    {
        //ATRIBUTOS
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        //CONSTRUCTORES
        public Producto()
        {

        }
        public Producto(string codigo, string nombre, string descripcion, string categoria, string marca)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Categoria = categoria;
            this.Marca = marca;
        }
        /// <summary>
        /// Metodo que recupera los campos para luego utilizarlos 
        /// </summary>
        /// <returns>devuelve una lista con los campos</returns>
        public List<string> RecuperarCamposProductos()
        {
            List<string> listaCampos = new List<string>();
            foreach (var propiedad in this.GetType().GetProperties())
            {
                listaCampos.Add(propiedad.Name);
            }
            return listaCampos;
        }
    }
}
