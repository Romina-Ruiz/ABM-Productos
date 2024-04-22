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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += MainForm_Resize; 
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CentrarBotones();
        }
        private void CentrarBotones()
        {
            // Calcula el centro del formulario
            int centerX = this.Width / 2;
            //int centerY = this.Height / 2;

            // Ajusta la posición de los botones
            boton1.Left = centerX - 400;
            //boton1.Top = centerY - 15;

            boton2.Left = centerX + 50;
            //boton2.Top = centerY - 15;
        
            boton3.Left = centerX - 400;
            //boton3.Top = centerY - 25;

            boton4.Left = centerX + 50;
            //boton4.Top = centerY - 25;

            boton5.Left = centerX - 400;
            //boton5.Top = centerY - 35;

            boton6.Left = centerX + 50;
            //boton6.Top = centerY -35;

            titulo.Left = centerX - 300;                  
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Listas_Click(object sender, EventArgs e)
        {
            listaArticulos ventana = new listaArticulos();
            ventana.ShowDialog();
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            BuscarArticulo ventana2 = new BuscarArticulo();
            ventana2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            AgreArti ventana1 = new AgreArti();
            ventana1.ShowDialog();

        }
    }
}
