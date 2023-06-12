using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new Controladores.ControladorUsuarios().crearPrimerUsuario("Administrador", "root", "root","Y");

            FrmInicioSesion frmInicioSesion = new FrmInicioSesion();
            frmInicioSesion.Show();
            Application.Run();
        }
    }
}
