﻿using dominio;
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
    public partial class BuscarArticulo : Form
    {

        private Articulo articulo=null;

                    

       
        public BuscarArticulo(Articulo articulo)
        {
            

            InitializeComponent();

            ArticuloNegocio nuevo = new ArticuloNegocio();

            
            textBox1.Text = articulo.Cod_Articulo;
            textBox2.Text = articulo.Nombre_Articulo;
            textBox3.Text = articulo._Descripcion;
            textBox4.Text  =articulo.Precio.ToString();
            textBox5.Text = articulo.des_marca;
            textBox6.Text = articulo.des_categoria;
            textBox7.Text = articulo.urlImagen;
            cargarImagen(textBox7.Text);


        }


        private void textBox7_Leave(object sender, EventArgs e)
        {
            
            cargarImagen(textBox7.Text);

        }

    private void cargarImagen(string imagen)
    {
            

            try
        {
            ptbxDetalle.Load(imagen);
        }
        catch (Exception)
        {

            ptbxDetalle.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");

        }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            Close();
        }

       

     


        

    }





}
