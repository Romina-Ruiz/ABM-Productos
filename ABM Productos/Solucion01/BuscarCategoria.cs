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
using dominio;
using Solucion01;

namespace dominio
{
    public partial class BuscarCategoria : Form
    {
        public BuscarCategoria()
        {
            InitializeComponent();
        }
        
        private void BuscarCategoria_Load(object sender, EventArgs e)
        {

            CategoriaNegocio negocio= new CategoriaNegocio();
            dgvBuscarCategoria.DataSource = negocio.listar();


        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            CategoriaNegocio categoria=new CategoriaNegocio();
            List<Categoria> listaCompleta;

           listaCompleta = categoria.listar();
            

            List<Categoria> Listafiltrada;

           
            string filtro = txtBuscar.Text;


            if (filtro != "")
            {

                Listafiltrada = listaCompleta.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {

                Listafiltrada = listaCompleta;
            }

            dgvBuscarCategoria.DataSource = null;
            dgvBuscarCategoria.DataSource = Listafiltrada;
              


        }

       
    }
}
