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
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarMarcas ventana=new ListarMarcas();
            ventana.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void picMarca_Click(object sender, EventArgs e)
        {

        }

        private void lbMarca_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            AgregarMarcas alta=new AgregarMarcas();

            alta.ShowDialog();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
           BuscarMarca alta = new BuscarMarca();

            alta.ShowDialog();  
        }
    }
}
