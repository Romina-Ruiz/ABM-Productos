using dominio;
using negocio;
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
    public partial class ModificarMarca : Form
    {
        public ModificarMarca(Marca marca)
        {
            InitializeComponent();
            

        }

        private void ModificarMarca_Load(object sender, EventArgs e)
        {

                         



        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
           /* MarcaNegocio marcaNegocio = new MarcaNegocio();

            Marca modificado = new Marca();
            modificado = (Marca)dgvSeleccionado.CurrentRow.DataBoundItem;

            marcaNegocio.Modificar(modificado); 
           */


        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            Close();

        }

        private void btCierreMarcas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
