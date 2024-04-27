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

namespace dominio
{
    public partial class AgregarCategoria : Form
    {
        private Categoria categoria = null;
        public AgregarCategoria()
        {
            InitializeComponent();
        } public AgregarCategoria(Categoria catModificar)
        {
            InitializeComponent();
            this.categoria = catModificar;
            Text = "Modificar Categoria";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btbAceptar_Click(object sender, EventArgs e)
        {
                
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {if (categoria == null)
                {
                    categoria = new Categoria();
                }
            
                categoria.Descripcion= txtDescripcion.Text;
               
                if(categoria.Id != 0)
                {
                   
                    negocio.Modificar(categoria);
                MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                    
                    negocio.agregar(categoria);
                MessageBox.Show("Agregado exitosamente");

                }


                Close();
                
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if(categoria != null)
                {
                    txtDescripcion.Text = categoria.Descripcion;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
