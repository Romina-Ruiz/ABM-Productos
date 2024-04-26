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
    public partial class AgregarMarcas : Form
    {

        //private Marca marca=null;
        
        public AgregarMarcas()
        {
            InitializeComponent();
        }

      /*  public AgregarMarcas(Marca marca)
        {
            InitializeComponent();
             this.marca= marca;
            Text = "Modificar Marca";


        }*/


        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Marca nuevo= new Marca();  
            MarcaNegocio negocio= new MarcaNegocio();


            try
            {
                nuevo.NombreMarca=txtNombre.Text;

                negocio.Agregar(nuevo);
                MessageBox.Show("Registro Agregado");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
