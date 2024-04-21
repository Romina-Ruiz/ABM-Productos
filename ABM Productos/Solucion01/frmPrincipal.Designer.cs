namespace Solucion01
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btArticulos = new System.Windows.Forms.Button();
            this.btCategorias = new System.Windows.Forms.Button();
            this.btMarcas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitulo.Location = new System.Drawing.Point(12, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(364, 55);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "BIENVENIDOS";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btArticulos
            // 
            this.btArticulos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btArticulos.FlatAppearance.BorderSize = 3;
            this.btArticulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btArticulos.Font = new System.Drawing.Font("Rockwell Extra Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btArticulos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btArticulos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btArticulos.ImageKey = "(ninguno)";
            this.btArticulos.Location = new System.Drawing.Point(12, 88);
            this.btArticulos.Name = "btArticulos";
            this.btArticulos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btArticulos.Size = new System.Drawing.Size(345, 327);
            this.btArticulos.TabIndex = 1;
            this.btArticulos.Text = "ARTICULOS";
            this.btArticulos.UseMnemonic = false;
            this.btArticulos.UseVisualStyleBackColor = false;
            this.btArticulos.Click += new System.EventHandler(this.btArticulos_Click);
            // 
            // btCategorias
            // 
            this.btCategorias.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCategorias.FlatAppearance.BorderSize = 3;
            this.btCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCategorias.Font = new System.Drawing.Font("Rockwell Extra Bold", 27.75F, System.Drawing.FontStyle.Bold);
            this.btCategorias.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btCategorias.Location = new System.Drawing.Point(363, 260);
            this.btCategorias.Name = "btCategorias";
            this.btCategorias.Size = new System.Drawing.Size(478, 155);
            this.btCategorias.TabIndex = 2;
            this.btCategorias.Text = "CATEGORIAS";
            this.btCategorias.UseVisualStyleBackColor = false;
            this.btCategorias.Click += new System.EventHandler(this.btCategorias_Click);
            // 
            // btMarcas
            // 
            this.btMarcas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btMarcas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMarcas.FlatAppearance.BorderSize = 3;
            this.btMarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.btMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMarcas.Font = new System.Drawing.Font("Rockwell Extra Bold", 27.75F, System.Drawing.FontStyle.Bold);
            this.btMarcas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btMarcas.Location = new System.Drawing.Point(363, 88);
            this.btMarcas.Name = "btMarcas";
            this.btMarcas.Size = new System.Drawing.Size(478, 166);
            this.btMarcas.TabIndex = 3;
            this.btMarcas.Text = "MARCAS";
            this.btMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btMarcas.UseVisualStyleBackColor = false;
            this.btMarcas.Click += new System.EventHandler(this.btMarcas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 487);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btMarcas);
            this.Controls.Add(this.btCategorias);
            this.Controls.Add(this.btArticulos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btArticulos;
        private System.Windows.Forms.Button btCategorias;
        private System.Windows.Forms.Button btMarcas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}