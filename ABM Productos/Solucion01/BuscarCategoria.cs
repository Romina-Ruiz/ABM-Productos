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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int IdBuscado = (int)numId.Value;
            
            Categoria categoriaBuscada;
            List<Categoria> listaCompleta;
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCompleta = negocio.listar();
            categoriaBuscada = listaCompleta.Find(c => c.Id == IdBuscado);
            if(categoriaBuscada !=null )
            {
                lblInformacion.Text = categoriaBuscada.Descripcion;
            }
            else
            {
                lblInformacion.Text = "Categoria no encontrada,intente con otro numer de Id";
            }
        }
    }
}
