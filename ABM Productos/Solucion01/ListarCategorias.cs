using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
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
            cargar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvListarCategorias.DataSource = negocio.listar();
        }
        private void dgvListarCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCategoria ventana = new AgregarCategoria();
            ventana.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCategorias ventana = new ModificarCategorias();
            ventana.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            EliminarCategoria ventana = new EliminarCategoria();
            ventana.ShowDialog();
            cargar();
        }
    }
}
