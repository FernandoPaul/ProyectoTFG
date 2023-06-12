using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlmacen.Clases
{
    public class Proveedor
    {
        //Atributos
        public string CIF { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        //CONTRUCTORES
        public Proveedor()    //Construtor vacio para utilizar XML
        {
        }
        public Proveedor(string cif, string nombre, int telefono)
        {
            this.CIF = cif;
            this.Nombre = nombre;
            this.Telefono = telefono;
        }
        /// <summary>
        /// Metodo que recupera los campos para luego utilizarlos 
        /// </summary>
        /// <returns>devuelve una lista con los campos</returns>
        public List<string> RecuperarCamposProveedor()
        {
            List<string> listaCampos = new List<string>();
            foreach (var propiedad in this.GetType().GetProperties())
            {
                listaCampos.Add(propiedad.Name);
            }
            /*
            listaCampos.Add("Cif");
            listaCampos.Add("Nombre");
            listaCampos.Add("Telefono");
            */
            return listaCampos;
        }
    }
}
