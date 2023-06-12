using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlmacen.Clases
{
    public class Salida
    {
        public string NumDoc { get; set; }
        public DateTime FechaSalida { get; set; }
        public string CifCliente { get; set; }
        public string NombreCliente { get; set; }
        public string CodigoProd { get; set; }
        public string NombreProd { get; set; }
        public string Descripcion { get; set; }
        public int CantidadProd { get; set; }

        public Salida()
        {

        }
        public Salida(string numDoc, DateTime fechaSalida, string cifCliente, string nomCliente, string codProd, string nomProd, string descripcion, int cantProd)
        {
            this.NumDoc = numDoc;
            this.FechaSalida = fechaSalida;
            this.CifCliente = cifCliente;
            this.NombreCliente = nomCliente;
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
