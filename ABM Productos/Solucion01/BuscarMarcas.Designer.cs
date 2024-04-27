namespace Solucion01
{
    partial class BuscarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarMarca));
            this.lbBuscarMarca = new System.Windows.Forms.Label();
            this.NumMarcas = new System.Windows.Forms.NumericUpDown();
            this.lbMarca = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.pictBuscar = new System.Windows.Forms.PictureBox();
            this.btCierreMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBuscarMarca
            // 
            this.lbBuscarMarca.AutoSize = true;
            this.lbBuscarMarca.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarMarca.Location = new System.Drawing.Point(197, 21);
            this.lbBuscarMarca.Name = "lbBuscarMarca";
            this.lbBuscarMarca.Size = new System.Drawing.Size(392, 57);
            this.lbBuscarMarca.TabIndex = 3;
            this.lbBuscarMarca.Text = "BUSCAR MARCA";
            // 
            // NumMarcas
            // 
            this.NumMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumMarcas.Location = new System.Drawing.Point(335, 165);
            this.NumMarcas.Name = "NumMarcas";
            this.NumMarcas.Size = new System.Drawing.Size(148, 29);
            this.NumMarcas.TabIndex = 0;
            this.NumMarcas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.BackColor = System.Drawing.Color.Tan;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lbMarca.ForeColor = System.Drawing.Color.Black;
            this.lbMarca.Location = new System.Drawing.Point(182, 157);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(135, 37);
            this.lbMarca.TabIndex = 4;
            this.lbMarca.Text = "&Código:";
            this.lbMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.CadetBlue;
            this.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBuscar.FlatAppearance.BorderSize = 2;
            this.btBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.Color.Black;
            this.btBuscar.Location = new System.Drawing.Point(230, 280);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(187, 67);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.TabStop = false;
            this.btBuscar.Text = "&BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(300, 304);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 33);
            this.lbResult.TabIndex = 5;
            // 
            // pictBuscar
            // 
            this.pictBuscar.BackColor = System.Drawing.Color.Tan;
            this.pictBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pictBuscar.Image")));
            this.pictBuscar.InitialImage = null;
            this.pictBuscar.Location = new System.Drawing.Point(529, 113);
            this.pictBuscar.Name = "pictBuscar";
            this.pictBuscar.Size = new System.Drawing.Size(251, 289);
            this.pictBuscar.TabIndex = 13;
            this.pictBuscar.TabStop = false;
            // 
            // btCierreMarcas
            // 
            this.btCierreMarcas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCierreMarcas.BackColor = System.Drawing.Color.Tan;
            this.btCierreMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCierreMarcas.FlatAppearance.BorderSize = 3;
            this.btCierreMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btCierreMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCierreMarcas.Image = global::Solucion01.Properties.Resources.flecha_atras;
            this.btCierreMarcas.Location = new System.Drawing.Point(12, 3);
            this.btCierreMarcas.Name = "btCierreMarcas";
            this.btCierreMarcas.Size = new System.Drawing.Size(63, 54);
            this.btCierreMarcas.TabIndex = 2;
            this.btCierreMarcas.Text = "&";
            this.btCierreMarcas.UseVisualStyleBackColor = false;
            this.btCierreMarcas.Click += new System.EventHandler(this.btCierreMarcas_Click);
            // 
            // BuscarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(810, 483);
            this.Controls.Add(this.btCierreMarcas);
            this.Controls.Add(this.pictBuscar);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.NumMarcas);
            this.Controls.Add(this.lbBuscarMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(826, 522);
            this.Name = "BuscarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Marcas";
            this.Load += new System.EventHandler(this.BuscarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbBuscarMarca;
        private System.Windows.Forms.NumericUpDown NumMarcas;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.PictureBox pictBuscar;
        private System.Windows.Forms.Button btCierreMarcas;
    }
}