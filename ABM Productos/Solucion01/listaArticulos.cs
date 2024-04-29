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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Solucion01
{
    public partial class listaArticulos : Form
    {
        private List<Articulo> listaArticulo;
       
        
        public listaArticulos()
        {
            InitializeComponent();
        }

        private void listaArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgreArti ventana1 = new AgreArti();
            ventana1.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                DgvArticulo.DataSource = negocio.listar();
                this.listaArticulo = negocio.listar();

                cargarImagen(listaArticulo[0].urlImagen);
                ocultarColumna();             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ocultarColumna()
        {
            DgvArticulo.Columns["Id"].Visible = false;
            DgvArticulo.Columns["des_marca"].Visible = false;
            DgvArticulo.Columns["des_categoria"].Visible = false;
            DgvArticulo.Columns["Id_marca"].Visible = false;            
            DgvArticulo.Columns["Id_Cate"].Visible = false;
            
            DgvArticulo.Columns["urlImagen"].Visible = false;
            
            DgvArticulo.Columns["IdArticulo"].Visible = false;
            DgvArticulo.Columns["Id_imagen"].Visible = false;
        }
        private void boton4_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)DgvArticulo.CurrentRow.DataBoundItem;

            AgreArti modificar = new AgreArti(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

       private void btnElimin_Click(object sender, EventArgs e)
        {
            ArticuloNegocio nego = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta= MessageBox.Show("¿Estas seguro de eliminar el Registro?","Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)DgvArticulo.CurrentRow.DataBoundItem;
                    nego.eliminar(seleccionado.Id);
                    cargar();
                }                  
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidarBuscar()
        {
            if (string.IsNullOrEmpty(txtFiltro.Text))
            {

                MessageBox.Show("Debe ingresar un criterio");
                return true;

            }
            return false;

        }
         

    private void bntBuscar_Click(object sender, EventArgs e)
        {

            if (ValidarBuscar())
            {
                return;
            }


            List<Articulo> listaFiltrada;
             string filtro = (string)txtFiltro.Text;

             if(filtro != "") 
             {
               listaFiltrada = listaArticulo.FindAll(x => x.Nombre_Articulo.ToLower().Contains(filtro.ToLower()));
             }
             else
             {
                 listaFiltrada = listaArticulo;
             }

             DgvArticulo.DataSource = null;
             DgvArticulo.DataSource = listaFiltrada;
             ocultarColumna();
        }

        private void DgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvArticulo.CurrentRow != null) 
            {
                Articulo selec = (Articulo)DgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(selec.urlImagen);
            }
            
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception)
            {

                pictureBox1.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/310px-Placeholder_view_vector.svg.png");
            
            }
            
        }       

        private void btVer_Click_1(object sender, EventArgs e)
        {
            if (DgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)DgvArticulo.CurrentRow.DataBoundItem;
                BuscarArticulo ventana = new BuscarArticulo(seleccionado);
                ventana.ShowDialog();

                cargar();

            }
        }
    }
}
