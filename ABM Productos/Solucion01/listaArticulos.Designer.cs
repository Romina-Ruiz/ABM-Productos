namespace Solucion01
{
    partial class listaArticulos
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
            this.DgvArticulo = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.btnElimin = new System.Windows.Forms.Button();
            this.etiquetaBuscar = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArticulo
            // 
            this.DgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvArticulo.Location = new System.Drawing.Point(102, 81);
            this.DgvArticulo.MultiSelect = false;
            this.DgvArticulo.Name = "DgvArticulo";
            this.DgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulo.Size = new System.Drawing.Size(425, 270);
            this.DgvArticulo.TabIndex = 0;
            this.DgvArticulo.SelectionChanged += new System.EventHandler(this.DgvArticulo_SelectionChanged);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.BackgroundImage = global::Solucion01.Properties.Resources.flecha_atras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 70);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleName = "";
            this.btnAgregar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(13, 400);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR ARTÍCULOS";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // boton4
            // 
            this.boton4.AccessibleName = "";
            this.boton4.BackColor = System.Drawing.Color.CadetBlue;
            this.boton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton4.FlatAppearance.BorderSize = 2;
            this.boton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.boton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton4.ForeColor = System.Drawing.Color.White;
            this.boton4.Location = new System.Drawing.Point(261, 400);
            this.boton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(167, 36);
            this.boton4.TabIndex = 5;
            this.boton4.Text = "MODIFICAR";
            this.boton4.UseVisualStyleBackColor = false;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // btnElimin
            // 
            this.btnElimin.AccessibleName = "";
            this.btnElimin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnElimin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnElimin.FlatAppearance.BorderSize = 2;
            this.btnElimin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnElimin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimin.ForeColor = System.Drawing.Color.White;
            this.btnElimin.Location = new System.Drawing.Point(484, 400);
            this.btnElimin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnElimin.Name = "btnElimin";
            this.btnElimin.Size = new System.Drawing.Size(181, 36);
            this.btnElimin.TabIndex = 6;
            this.btnElimin.Text = "ELIMINAR";
            this.btnElimin.UseVisualStyleBackColor = false;
            this.btnElimin.Click += new System.EventHandler(this.btnElimin_Click);
            // 
            // etiquetaBuscar
            // 
            this.etiquetaBuscar.AutoSize = true;
            this.etiquetaBuscar.BackColor = System.Drawing.Color.White;
            this.etiquetaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaBuscar.Location = new System.Drawing.Point(141, 46);
            this.etiquetaBuscar.Name = "etiquetaBuscar";
            this.etiquetaBuscar.Size = new System.Drawing.Size(56, 20);
            this.etiquetaBuscar.TabIndex = 7;
            this.etiquetaBuscar.Text = "Filtrar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(203, 46);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(181, 22);
            this.txtFiltro.TabIndex = 8;
            // 
            // bntBuscar
            // 
            this.bntBuscar.AccessibleName = "";
            this.bntBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.bntBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntBuscar.FlatAppearance.BorderSize = 2;
            this.bntBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bntBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntBuscar.ForeColor = System.Drawing.Color.White;
            this.bntBuscar.Location = new System.Drawing.Point(422, 42);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(135, 31);
            this.bntBuscar.TabIndex = 9;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.UseVisualStyleBackColor = false;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(556, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // listaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Solucion01.Properties.Resources.Fondo4;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.etiquetaBuscar);
            this.Controls.Add(this.btnElimin);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.DgvArticulo);
            this.Name = "listaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador Artículos";
            this.Load += new System.EventHandler(this.listaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvArticulo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button btnElimin;
        private System.Windows.Forms.Label etiquetaBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}