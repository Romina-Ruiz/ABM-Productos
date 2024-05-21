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
            dgvBuscarMarcas.DataSource = negocio.listar();



        }

        
        private void btCierreMarcas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> Listacompleta;
            
            Listacompleta=marcaNegocio.listar();    

            List<Marca> listaFiltrada;

            string filtro = txtFiltro.Text;


            if(filtro!="")
            {

                listaFiltrada = Listacompleta.FindAll(x => x.NombreMarca.ToUpper().Contains(filtro.ToUpper()));
           
            }
            else
            {

                listaFiltrada=Listacompleta;
            }

            dgvBuscarMarcas.DataSource = null;
            dgvBuscarMarcas.DataSource = listaFiltrada;






        }
    }
}
