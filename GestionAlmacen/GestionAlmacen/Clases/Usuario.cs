using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlmacen.Clases
{
    public class Usuario
    {
        //Atributos
        public string NombreCompleto { get; set; }
        public string Id { get; set; }
        public string Clave { get; set; }
        public string Administrador { get; set; }
        //CONTRUCTORES
        public Usuario() 
        {
        }
        public Usuario(string nombreCompleto, string id, string clave, string administrador)
        {
            this.NombreCompleto = nombreCompleto;
            this.Id = id;
            this.Clave = clave;
            this.Administrador = administrador;
        }

    }
}

