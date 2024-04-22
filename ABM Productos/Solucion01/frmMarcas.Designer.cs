namespace Solucion01
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
            this.picMarca = new System.Windows.Forms.PictureBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.btListar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.picMarca)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMarca
            // 
            this.picMarca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picMarca.Image = ((System.Drawing.Image)(resources.GetObject("picMarca.Image")));
            this.picMarca.Location = new System.Drawing.Point(-17, -31);
            this.picMarca.Name = "picMarca";
            this.picMarca.Size = new System.Drawing.Size(512, 512);
            this.picMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMarca.TabIndex = 0;
            this.picMarca.TabStop = false;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbMarca.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.ForeColor = System.Drawing.Color.Firebrick;
            this.lbMarca.Location = new System.Drawing.Point(449, 42);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(238, 55);
            this.lbMarca.TabIndex = 1;
            this.lbMarca.Text = "MARCAS";
            this.lbMarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btListar
            // 
            this.btListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btListar.BackColor = System.Drawing.Color.CadetBlue;
            this.btListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btListar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btListar.FlatAppearance.BorderSize = 2;
            this.btListar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListar.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar.Location = new System.Drawing.Point(377, 149);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(168, 55);
            this.btListar.TabIndex = 2;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btBuscar.FlatAppearance.BorderSize = 2;
            this.btBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(573, 149);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(166, 55);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.CadetBlue;
            this.btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btAgregar.FlatAppearance.BorderSize = 2;
            this.btAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(377, 225);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(168, 55);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btEliminar.FlatAppearance.BorderSize = 2;
            this.btEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(478, 311);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(166, 55);
            this.btEliminar.TabIndex = 5;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.Color.CadetBlue;
            this.btModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btModificar.FlatAppearance.BorderSize = 2;
            this.btModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(573, 225);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(166, 55);
            this.btModificar.TabIndex = 7;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripLabel1.LinkVisited = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 25);
            this.toolStripLabel1.Text = "Articulos";
            this.toolStripLabel1.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(114, 25);
            this.toolStripLabel2.Text = "Categorias";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 8);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.picMarca);
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMarcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMarca)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMarca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}