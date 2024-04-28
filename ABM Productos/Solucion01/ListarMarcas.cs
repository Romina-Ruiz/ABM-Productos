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
    public partial class ListarMarcas : Form
    {
        public ListarMarcas()
        {
            InitializeComponent();
        }

        private void cargar()
        {

            MarcaNegocio negocio = new MarcaNegocio();
            dgvListarMarcas.DataSource = negocio.listar();

        }


        private void ListarMarcas_Load(object sender, EventArgs e)
        {
            cargar(); 


        }

            

        private void Modificar_Click_1(object sender, EventArgs e)
        {

          Marca modificado;
          
            modificado = (Marca)dgvListarMarcas.CurrentRow.DataBoundItem;

            AgregarMarcas ventana = new AgregarMarcas(modificado);
            ventana.ShowDialog();
            cargar();

         
        }

        private void btEliminar_Click_1(object sender, EventArgs e)
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            Marca seleccionado;

            try
            {

                DialogResult resp = MessageBox.Show("¿Esta seguro que quiere eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resp == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvListarMarcas.CurrentRow.DataBoundItem;

                    marcaNegocio.Eliminar(seleccionado.CodMarca);
                    cargar();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void btCierreMarcas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
