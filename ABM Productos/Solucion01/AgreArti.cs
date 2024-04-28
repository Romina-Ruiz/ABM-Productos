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
        private Articulo articulo = null;        
        
        public AgreArti()
        {
            InitializeComponent();    
           
        }  
        
        public AgreArti(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValidarFiltro()
        {

            if (!soloNumeros(textBox1.Text))
            {

                MessageBox.Show("Ingresar solo números!");
                return true;

            }
            if (!soloNumeros(textBox4.Text))
            {

                MessageBox.Show("Ingresar solo números!");
                return true;

            }


            if (string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("Debe cargar un nombre!");
                return true;

            }

            if (cmbMarca.SelectedIndex< 0)
            {
                MessageBox.Show("Debe seleccionar una marca!");
                return true;  
            }


            if(cmbCategoria.SelectedIndex< 0)
            {
                MessageBox.Show("Debe seleccionar una categoria");
                return true;

            }   

            return false;


        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {

                if(!(char.IsNumber(caracter))) { 
                
                    return false;   
                }

                
            }

            return true;

        }




        private void botonAgregar_Click(object sender, EventArgs e)
        {           
            ArticuloNegocio artiNe = new ArticuloNegocio();

            try
            {


                if (ValidarFiltro())
                {
                    return;
                }



                if (articulo == null)
                    articulo = new Articulo();

                articulo.Cod_Articulo = textBox1.Text;
                articulo.Nombre_Articulo = textBox2.Text;
                articulo._Descripcion = textBox3.Text;
                articulo.Precio = float.Parse(textBox4.Text);
                articulo.urlImagen = txtUrl.Text;

                articulo.des_marca = cmbMarca.SelectedItem.ToString();
                articulo.des_categoria = cmbCategoria.SelectedItem.ToString();

                // Obtener el objeto Marca seleccionado del ComboBox
                Marca marcaSeleccionada = (Marca)cmbMarca.SelectedItem;
                Categoria categoriaSeleccionada = (Categoria)cmbCategoria.SelectedItem;

                // Obtener el ID correspondiente
                int idMarcaSeleccionado = marcaSeleccionada.CodMarca;
                int idCategoriaSeleccionado = categoriaSeleccionada.Id;

                articulo.Id_marca = idMarcaSeleccionado;
                articulo.Id_cate = idCategoriaSeleccionado;

                                     

                if (articulo.Id != 0) 
                {
                    artiNe.Modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                    
                }
                else
                {
                    Articulo aux = artiNe.UltimoId();                    
                    articulo.Id = aux.Id + 1 ;

                    artiNe.Agregar(articulo);
                    artiNe.AgregarImagen(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                }                
               
                Close();               

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void AgreArti_Load(object sender, EventArgs e)
        {
            try
            {
                if (articulo != null)
                {
                    textBox1.Text = articulo.Cod_Articulo;
                    textBox2.Text = articulo.Nombre_Articulo;
                    textBox3.Text = articulo._Descripcion;
                    textBox4.Text = articulo.Precio.ToString();
                    txtUrl.Text = articulo.urlImagen;
                    cmbMarca.Text = articulo.des_marca;
                    cmbCategoria.Text = articulo.des_categoria;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
            
            MarcaNegocio negocio = new MarcaNegocio();
            CategoriaNegocio negocio2 = new CategoriaNegocio();

            try
            {
                cmbMarca.DataSource = negocio.listar();
                cmbCategoria.DataSource = negocio2.listar();

                cmbMarca.DisplayMember = "NombreMarca";
                cmbCategoria.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
