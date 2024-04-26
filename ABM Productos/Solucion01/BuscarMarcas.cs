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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void BuscarMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvBuscarMarca.DataSource = negocio.listar();


        }

        private void Modificar_Click(object sender, EventArgs e)
        {

           
        










        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {

               DialogResult resp= MessageBox.Show("¿Esta seguro que quiere eliminarlo?", "Eliminando", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
               
                if(resp == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvBuscarMarca.CurrentRow.DataBoundItem;

                    marcaNegocio.Eliminar(seleccionado.CodMarca);

                }
                
              

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
