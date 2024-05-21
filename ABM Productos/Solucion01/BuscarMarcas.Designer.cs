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
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.pictBuscar = new System.Windows.Forms.PictureBox();
            this.btCierreMarcas = new System.Windows.Forms.Button();
            this.dgvBuscarMarcas = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBuscarMarca
            // 
            this.lbBuscarMarca.AutoSize = true;
            this.lbBuscarMarca.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarMarca.Location = new System.Drawing.Point(197, 21);
            this.lbBuscarMarca.Name = "lbBuscarMarca";
            this.lbBuscarMarca.Size = new System.Drawing.Size(392, 57);
            this.lbBuscarMarca.TabIndex = 4;
            this.lbBuscarMarca.Text = "BUSCAR MARCA";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.BackColor = System.Drawing.Color.Tan;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lbMarca.ForeColor = System.Drawing.Color.Black;
            this.lbMarca.Location = new System.Drawing.Point(200, 107);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(148, 37);
            this.lbMarca.TabIndex = 0;
            this.lbMarca.Text = "&Nombre:";
            this.lbMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.Color.Tan;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(259, 342);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 42);
            this.lbResult.TabIndex = 5;
            // 
            // pictBuscar
            // 
            this.pictBuscar.BackColor = System.Drawing.Color.Tan;
            this.pictBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pictBuscar.Image")));
            this.pictBuscar.InitialImage = null;
            this.pictBuscar.Location = new System.Drawing.Point(511, 182);
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
            this.btCierreMarcas.TabIndex = 3;
            this.btCierreMarcas.Text = "&";
            this.btCierreMarcas.UseVisualStyleBackColor = false;
            this.btCierreMarcas.Click += new System.EventHandler(this.btCierreMarcas_Click);
            // 
            // dgvBuscarMarcas
            // 
            this.dgvBuscarMarcas.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuscarMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBuscarMarcas.Location = new System.Drawing.Point(196, 187);
            this.dgvBuscarMarcas.Name = "dgvBuscarMarcas";
            this.dgvBuscarMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarMarcas.Size = new System.Drawing.Size(246, 284);
            this.dgvBuscarMarcas.TabIndex = 14;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(386, 117);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(175, 26);
            this.txtFiltro.TabIndex = 15;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // BuscarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(810, 483);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dgvBuscarMarcas);
            this.Controls.Add(this.btCierreMarcas);
            this.Controls.Add(this.pictBuscar);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbBuscarMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(826, 522);
            this.Name = "BuscarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Marcas";
            this.Load += new System.EventHandler(this.BuscarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbBuscarMarca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.PictureBox pictBuscar;
        private System.Windows.Forms.Button btCierreMarcas;
        private System.Windows.Forms.DataGridView dgvBuscarMarcas;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}