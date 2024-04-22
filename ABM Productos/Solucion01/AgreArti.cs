using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Solucion01
{
    public partial class AgreArti : Form
    {
        public AgreArti()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Articulo arti = new Articulo();
            ArticuloNegocio artiNe = new ArticuloNegocio();

            try
            {
                arti.Cod_Articulo = textBox1.Text;
                arti.Nombre_Articulo = textBox2.Text;
                arti._Descripcion = textBox3.Text;
                arti.Precio = float.Parse(textBox4.Text);

                artiNe.Agregar(arti);
                MessageBox.Show("Agregado Exitosamente");
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
