using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Solucion01
{
    public partial class AgregarMarcas : Form
    {

            private Marca marca=null;
        
        public AgregarMarcas()
        {
            InitializeComponent();
        }

      public AgregarMarcas(Marca marca)
        {
            InitializeComponent();
             this.marca= marca;
            Text = "Modificar Marca";


        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
             
            MarcaNegocio negocio= new MarcaNegocio();

            try
            {

                if (marca == null)
                {
                    marca = new Marca();


                }
                marca.NombreMarca= txtNombre.Text;

                if (marca.CodMarca!= 0)
                {


                    negocio.Modificar(marca);
                    MessageBox.Show("Registro Modificado");

                }

                else
                {
                    negocio.Agregar(marca);
                    MessageBox.Show("Registro Agregado");


                }



                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void AgregarMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (marca != null)
                {
                    marca.NombreMarca = txtNombre.Text;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
