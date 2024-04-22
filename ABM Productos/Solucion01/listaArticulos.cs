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
    public partial class listaArticulos : Form
    {
        public listaArticulos()
        {
            InitializeComponent();
        }

        private void listaArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                DgvArticulo.DataSource = negocio.listar();
                DgvArticulo.Columns["Id_Marca"].Visible = false;
                DgvArticulo.Columns["Id_Categoria"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());               
            }

          
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
