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

namespace dominio
{
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btbAceptar_Click(object sender, EventArgs e)
        {
                Categoria nuevaCat = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                nuevaCat.Descripcion= txtDescripcion.Text;
                negocio.agregar(nuevaCat);

                MessageBox.Show("Agregado exitosamente");
                Close();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
