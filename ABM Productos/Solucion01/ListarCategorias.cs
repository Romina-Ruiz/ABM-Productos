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
    public partial class ListarCategorias : Form
    {
        public ListarCategorias()
        {
            InitializeComponent();
        }

        private void ListarCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvListarCategorias.DataSource = negocio.listar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
