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

namespace dominio
{
    public partial class ListarCategorias : Form
    {
        public ListarCategorias()
        {
            InitializeComponent();
        }

        private void dgvListaCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            

        }

        private void ListarCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio1 = new CategoriaNegocio();
            dgvListaCategoria.DataSource = negocio1.listar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
