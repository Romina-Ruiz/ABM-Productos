﻿namespace Solucion01
{
    partial class frmMarcas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcas));
            this.lbMarca = new System.Windows.Forms.Label();
            this.btListar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.picMarca = new System.Windows.Forms.PictureBox();
            this.btCierreMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.BackColor = System.Drawing.Color.Tan;
            this.lbMarca.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.ForeColor = System.Drawing.Color.Black;
            this.lbMarca.Location = new System.Drawing.Point(245, 9);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(286, 76);
            this.lbMarca.TabIndex = 4;
            this.lbMarca.Text = "MARCAS";
            this.lbMarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbMarca.Click += new System.EventHandler(this.lbMarca_Click);
            // 
            // btListar
            // 
            this.btListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btListar.BackColor = System.Drawing.Color.CadetBlue;
            this.btListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btListar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btListar.FlatAppearance.BorderSize = 3;
            this.btListar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListar.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold);
            this.btListar.Location = new System.Drawing.Point(110, 124);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(198, 71);
            this.btListar.TabIndex = 0;
            this.btListar.Text = "&Listar";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBuscar.FlatAppearance.BorderSize = 3;
            this.btBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold);
            this.btBuscar.Location = new System.Drawing.Point(110, 229);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(198, 71);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "&Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.CadetBlue;
            this.btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAgregar.FlatAppearance.BorderSize = 3;
            this.btAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold);
            this.btAgregar.Location = new System.Drawing.Point(110, 337);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(198, 71);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "&Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // picMarca
            // 
            this.picMarca.BackColor = System.Drawing.Color.Tan;
            this.picMarca.Image = ((System.Drawing.Image)(resources.GetObject("picMarca.Image")));
            this.picMarca.Location = new System.Drawing.Point(443, 124);
            this.picMarca.Name = "picMarca";
            this.picMarca.Size = new System.Drawing.Size(250, 250);
            this.picMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMarca.TabIndex = 0;
            this.picMarca.TabStop = false;
            this.picMarca.Click += new System.EventHandler(this.picMarca_Click);
            // 
            // btCierreMarcas
            // 
            this.btCierreMarcas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCierreMarcas.BackColor = System.Drawing.Color.Tan;
            this.btCierreMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCierreMarcas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCierreMarcas.FlatAppearance.BorderSize = 3;
            this.btCierreMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btCierreMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCierreMarcas.Image = global::Solucion01.Properties.Resources.flecha_atras;
            this.btCierreMarcas.Location = new System.Drawing.Point(3, 9);
            this.btCierreMarcas.Name = "btCierreMarcas";
            this.btCierreMarcas.Size = new System.Drawing.Size(63, 54);
            this.btCierreMarcas.TabIndex = 3;
            this.btCierreMarcas.Text = "&";
            this.btCierreMarcas.UseVisualStyleBackColor = false;
            this.btCierreMarcas.Click += new System.EventHandler(this.btCierreMarcas_Click);
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCierreMarcas);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.picMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMarcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.PictureBox picMarca;
        private System.Windows.Forms.Button btCierreMarcas;
    }
}