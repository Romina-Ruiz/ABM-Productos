using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace Solucion01
{
    public partial class ListarMarcas : Form
    {
        public ListarMarcas()
        {
            InitializeComponent();
        }

        private void ListarMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvListarMarcas.DataSource = negocio.listar(); 


        }
    }
}
