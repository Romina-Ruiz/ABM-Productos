﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btArticulos_Click(object sender, EventArgs e)
        {         
            listaArticulos ventana = new listaArticulos();
            ventana.ShowDialog();
        }

        private void btMarcas_Click(object sender, EventArgs e)
        {

            frmMarcas ventana = new frmMarcas();  
            ventana.ShowDialog();

        }

        private void btCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias ventana= new frmCategorias();
            ventana.ShowDialog();
        }
    }
}
