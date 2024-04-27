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

            



        }

        
        private void btBuscar_Click(object sender, EventArgs e)
        {

            int IdBuscado = (int)NumMarcas.Value;

            Marca marcabuscada;
            List<Marca> listacompleta;
            MarcaNegocio Negocio= new MarcaNegocio();
            listacompleta = Negocio.listar();
            marcabuscada = listacompleta.Find(c => c.CodMarca == IdBuscado);

            if (marcabuscada != null ) {

                lbResult.Text = marcabuscada.NombreMarca;
            }


             else
            {
                lbResult.Text = "Categoria no encontrada";
            }


        }
    }
}
