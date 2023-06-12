using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlmacen.Controles
{
    public partial class Filtro : UserControl
    {
        public Filtro()
        {
            InitializeComponent();
        }

        private void Filtro_Load(object sender, EventArgs e)
        {

        }
        public string TituloLabel
        {
            get => lbl_Buscar.Text;
            set => lbl_Buscar.Text = value;
        }
        public string ComboBox
        {
            get => cmb_Buscar.Text;
            set => cmb_Buscar.DataSource = value;
        }
        public string TextoTextBox
        {
            get => txt_Buscar.Text;
            set => txt_Buscar.Text = value;
        }
    }
}
