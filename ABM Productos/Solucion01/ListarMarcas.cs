﻿using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Solucion01
{
    public partial class ListarMarcas : Form
    {
        public ListarMarcas()
        {
            InitializeComponent();
        }

        private void dgwListMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MarcaNegocio negocio= new MarcaNegocio();
            dgvListMarca.DataSource = negocio.listar();

        }
    }
}
