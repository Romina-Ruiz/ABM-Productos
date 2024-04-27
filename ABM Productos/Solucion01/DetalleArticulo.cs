using dominio;
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
   /* public partial class DetalleArticulo : Form
    {
        public DetalleArticulo()
        {
            InitializeComponent();
        }

        private void btnAtrasAr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetalleArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                cmbArticulo.DataSource = negocio.listar();
                cmbArticulo.DisplayMember = "Nombre_Articulo";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {             
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo arti = new Articulo();

            arti = (Articulo)cmbArticulo.SelectedItem;

            try
            {

               
                dgvDetalle.DataSource = negocio.listar();             

               

                //dgvDetalle.Columns[tipo].Visible = true;
                dgvDetalle.Columns["Id_Marca"].Visible = false;
                dgvDetalle.Columns["Id_Categoria"].Visible = false;
                dgvDetalle.Columns["Cod_Articulo"].Visible = false;
                dgvDetalle.Columns["Nombre_Articulo"].Visible = false;
                dgvDetalle.Columns["Precio"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    */
}
