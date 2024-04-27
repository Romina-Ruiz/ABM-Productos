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
            this.lbBuscarMarca.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbBuscarMarca.Location = new System.Drawing.Point(218, 31);
            this.lbBuscarMarca.Name = "lbBuscarMarca";
            this.lbBuscarMarca.Size = new System.Drawing.Size(305, 44);
            this.lbBuscarMarca.TabIndex = 3;
            this.lbBuscarMarca.Text = "BUSCAR MARCA";
            // 
            // NumMarcas
            // 
            this.NumMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumMarcas.Location = new System.Drawing.Point(385, 145);
            this.NumMarcas.Name = "NumMarcas";
            this.NumMarcas.Size = new System.Drawing.Size(104, 26);
            this.NumMarcas.TabIndex = 11;
            this.NumMarcas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbMarca.Location = new System.Drawing.Point(220, 145);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(103, 27);
            this.lbMarca.TabIndex = 5;
            this.lbMarca.Text = "CODIGO";
            this.lbMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.LightCoral;
            this.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBuscar.FlatAppearance.BorderSize = 2;
            this.btBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.Color.Black;
            this.btBuscar.Location = new System.Drawing.Point(270, 205);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(178, 57);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.TabStop = false;
            this.btBuscar.Text = "BUSCAR";
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
            this.lbResult.TabIndex = 12;
            // 
            // pictBuscar
            // 
            this.pictBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pictBuscar.Image")));
            this.pictBuscar.InitialImage = null;
            this.pictBuscar.Location = new System.Drawing.Point(529, 70);
            this.pictBuscar.Name = "pictBuscar";
            this.pictBuscar.Size = new System.Drawing.Size(269, 298);
            this.pictBuscar.TabIndex = 13;
            this.pictBuscar.TabStop = false;
            // 
            // btCierreMarcas
            // 
            this.btCierreMarcas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCierreMarcas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btCierreMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCierreMarcas.FlatAppearance.BorderSize = 3;
            this.btCierreMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btCierreMarcas.Image = global::Solucion01.Properties.Resources.flecha_atras;
            this.btCierreMarcas.Location = new System.Drawing.Point(12, 3);
            this.btCierreMarcas.Name = "btCierreMarcas";
            this.btCierreMarcas.Size = new System.Drawing.Size(63, 54);
            this.btCierreMarcas.TabIndex = 14;
            this.btCierreMarcas.UseVisualStyleBackColor = false;
            this.btCierreMarcas.Click += new System.EventHandler(this.btCierreMarcas_Click);
            // 
            // BuscarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCierreMarcas);
            this.Controls.Add(this.pictBuscar);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.NumMarcas);
            this.Controls.Add(this.lbBuscarMarca);
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