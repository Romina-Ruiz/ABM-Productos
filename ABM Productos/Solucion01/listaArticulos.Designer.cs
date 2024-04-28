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
            this.lbArticulo = new System.Windows.Forms.Label();
            this.btVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArticulo
            // 
            this.DgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvArticulo.Location = new System.Drawing.Point(102, 195);
            this.DgvArticulo.MultiSelect = false;
            this.DgvArticulo.Name = "DgvArticulo";
            this.DgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulo.Size = new System.Drawing.Size(425, 205);
            this.DgvArticulo.TabIndex = 8;
            this.DgvArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArticulo_CellContentClick);
            this.DgvArticulo.SelectionChanged += new System.EventHandler(this.DgvArticulo_SelectionChanged);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAtras.BackgroundImage = global::Solucion01.Properties.Resources.flecha_atras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 70);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AccessibleName = "";
            this.btnAgregar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(242, 450);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 45);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "&AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // boton4
            // 
            this.boton4.AccessibleName = "";
            this.boton4.BackColor = System.Drawing.Color.CadetBlue;
            this.boton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton4.FlatAppearance.BorderSize = 2;
            this.boton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.boton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.boton4.ForeColor = System.Drawing.Color.White;
            this.boton4.Location = new System.Drawing.Point(457, 450);
            this.boton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(167, 45);
            this.boton4.TabIndex = 3;
            this.boton4.Text = "&MODIFICAR";
            this.boton4.UseVisualStyleBackColor = false;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // btnElimin
            // 
            this.btnElimin.AccessibleName = "";
            this.btnElimin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnElimin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElimin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnElimin.FlatAppearance.BorderSize = 2;
            this.btnElimin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnElimin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnElimin.ForeColor = System.Drawing.Color.White;
            this.btnElimin.Location = new System.Drawing.Point(656, 450);
            this.btnElimin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnElimin.Name = "btnElimin";
            this.btnElimin.Size = new System.Drawing.Size(181, 45);
            this.btnElimin.TabIndex = 4;
            this.btnElimin.Text = "&ELIMINAR";
            this.btnElimin.UseVisualStyleBackColor = false;
            this.btnElimin.Click += new System.EventHandler(this.btnElimin_Click);
            // 
            // etiquetaBuscar
            // 
            this.etiquetaBuscar.AutoSize = true;
            this.etiquetaBuscar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.etiquetaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaBuscar.Location = new System.Drawing.Point(181, 122);
            this.etiquetaBuscar.Name = "etiquetaBuscar";
            this.etiquetaBuscar.Size = new System.Drawing.Size(107, 33);
            this.etiquetaBuscar.TabIndex = 7;
            this.etiquetaBuscar.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(304, 122);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(181, 31);
            this.txtFiltro.TabIndex = 0;
            // 
            // bntBuscar
            // 
            this.bntBuscar.AccessibleName = "";
            this.bntBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.bntBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntBuscar.FlatAppearance.BorderSize = 2;
            this.bntBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bntBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBuscar.ForeColor = System.Drawing.Color.White;
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntBuscar.Location = new System.Drawing.Point(523, 122);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(135, 35);
            this.bntBuscar.TabIndex = 1;
            this.bntBuscar.Text = "&Buscar";
            this.bntBuscar.UseVisualStyleBackColor = false;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(577, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbArticulo
            // 
            this.lbArticulo.AutoSize = true;
            this.lbArticulo.Font = new System.Drawing.Font("Stencil", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticulo.Location = new System.Drawing.Point(293, 19);
            this.lbArticulo.Name = "lbArticulo";
            this.lbArticulo.Size = new System.Drawing.Size(317, 63);
            this.lbArticulo.TabIndex = 6;
            this.lbArticulo.Text = "ARTÍCULOS";
            // 
            // btVer
            // 
            this.btVer.AccessibleName = "";
            this.btVer.BackColor = System.Drawing.Color.CadetBlue;
            this.btVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btVer.FlatAppearance.BorderSize = 2;
            this.btVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btVer.ForeColor = System.Drawing.Color.White;
            this.btVer.Location = new System.Drawing.Point(102, 450);
            this.btVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(111, 45);
            this.btVer.TabIndex = 11;
            this.btVer.Text = "&VER";
            this.btVer.UseVisualStyleBackColor = false;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // listaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(895, 539);
            this.Controls.Add(this.btVer);
            this.Controls.Add(this.lbArticulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.etiquetaBuscar);
            this.Controls.Add(this.btnElimin);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.DgvArticulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(911, 578);
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
        private System.Windows.Forms.Label lbArticulo;
        private System.Windows.Forms.Button btVer;
    }
}