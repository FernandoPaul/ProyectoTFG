using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlmacen.Clases
{
    public class Entrada
    {   
        //ATRIBUTOS
        public string NumDoc { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string CifProv { get; set; }
        public string NombreProv { get; set; }
        public string CodigoProd { get; set; }
        public string NombreProd { get; set; }
        public string Descripcion { get; set; }
        public int CantidadProd { get; set; }
        //CONSTRUCTORES
        public Entrada()
        {

        }
        public Entrada(string numDoc, DateTime fechaEntrada, string cifProv, string nomProv, string codProd, string nomProd, string descripcion, int cantProd)
        {
            this.NumDoc = numDoc;
            this.FechaEntrada = fechaEntrada;
            this.CifProv = cifProv;
            this.NombreProv = nomProv;
            this.CodigoProd = codProd;
            this.NombreProd = nomProd;
            this.Descripcion = descripcion;
            this.CantidadProd = cantProd;
        }
        /// <summary>
        /// Metodo que recupera los campos para luego utilizarlos 
        /// </summary>
        /// <returns>devuelve una lista con los campos</returns>
        public List<string> RecuperarCamposEntrada()
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
