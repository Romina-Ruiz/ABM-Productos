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
    public partial class BuscarMarca : Form
    {
        public BuscarMarca()
        {
            InitializeComponent();
        }

        private void BuscarMarcas_Load(object sender, EventArgs e)
        {

            MarcaNegocio negocio = new MarcaNegocio();

            dgvSeleccionado.DataSource = negocio.listar();



        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            Marca seleccionado;
            seleccionado = (Marca)dgvSeleccionado.CurrentRow.DataBoundItem;

            ModificarMarca modificarMarca = new ModificarMarca(seleccionado);
            modificarMarca.ShowDialog();



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
                    seleccionado = (Marca)dgvSeleccionado.CurrentRow.DataBoundItem;

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
