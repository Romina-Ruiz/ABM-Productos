namespace Solucion01
{
    partial class ListarMarcas
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
            this.dgvListMarca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListMarca
            // 
            this.dgvListMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMarca.Location = new System.Drawing.Point(63, 48);
            this.dgvListMarca.Name = "dgvListMarca";
            this.dgvListMarca.Size = new System.Drawing.Size(546, 294);
            this.dgvListMarca.TabIndex = 0;
            this.dgvListMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListMarca_CellContentClick);
            // 
            // ListarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListMarca);
            this.Name = "ListarMarcas";
            this.Text = "ListarMarcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListMarca;
    }
}