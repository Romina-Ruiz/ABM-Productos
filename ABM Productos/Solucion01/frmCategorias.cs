using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion01
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void lblCategorias_Click(object sender, EventArgs e)
        {

        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarCategorias ventana = new ListarCategorias ();
            ventana.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCategoria ventana = new BuscarCategoria();
            ventana.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCategoria ventana = new AgregarCategoria();
            ventana.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarCategoria ventana = new ModificarCategoria();
            ventana.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCategoria ventana = new EliminarCategoria();
            ventana.ShowDialog();
        }
    }
}
