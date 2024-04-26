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
            Categoria seleccionado;
            seleccionado = (Categoria)dgvListarCategorias.CurrentRow.DataBoundItem;

            AgregarCategoria ventana = new AgregarCategoria(seleccionado);
            ventana.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
           
            try
            {
               DialogResult Respuesta= MessageBox.Show("¿Esta seguro que quiere eliminar?","Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                seleccionado = (Categoria)dgvListarCategorias.CurrentRow.DataBoundItem;
                negocio.Eliminar(seleccionado.Id);
            cargar();

                }
               
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
