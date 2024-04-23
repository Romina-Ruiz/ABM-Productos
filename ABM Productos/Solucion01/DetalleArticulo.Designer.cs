namespace Solucion01
{
    partial class DetalleArticulo
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
            this.etqArticulo = new System.Windows.Forms.Label();
            this.btnAtrasAr = new System.Windows.Forms.Button();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // etqArticulo
            // 
            this.etqArticulo.AutoSize = true;
            this.etqArticulo.BackColor = System.Drawing.Color.White;
            this.etqArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etqArticulo.Location = new System.Drawing.Point(230, 58);
            this.etqArticulo.Name = "etqArticulo";
            this.etqArticulo.Size = new System.Drawing.Size(59, 16);
            this.etqArticulo.TabIndex = 0;
            this.etqArticulo.Text = "Artículo";
            // 
            // btnAtrasAr
            // 
            this.btnAtrasAr.BackColor = System.Drawing.Color.White;
            this.btnAtrasAr.BackgroundImage = global::Solucion01.Properties.Resources.flecha_atras;
            this.btnAtrasAr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtrasAr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtrasAr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasAr.Location = new System.Drawing.Point(35, 28);
            this.btnAtrasAr.Name = "btnAtrasAr";
            this.btnAtrasAr.Size = new System.Drawing.Size(75, 65);
            this.btnAtrasAr.TabIndex = 1;
            this.btnAtrasAr.UseVisualStyleBackColor = false;
            this.btnAtrasAr.Click += new System.EventHandler(this.btnAtrasAr_Click);
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(312, 57);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(146, 21);
            this.cmbArticulo.TabIndex = 2;
            this.cmbArticulo.SelectedIndexChanged += new System.EventHandler(this.cmbArticulo_SelectedIndexChanged);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(143, 145);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(315, 150);
            this.dgvDetalle.TabIndex = 3;
            // 
            // DetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Solucion01.Properties.Resources.Fondo4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.cmbArticulo);
            this.Controls.Add(this.btnAtrasAr);
            this.Controls.Add(this.etqArticulo);
            this.Name = "DetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleArticulo";
            this.Load += new System.EventHandler(this.DetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etqArticulo;
        private System.Windows.Forms.Button btnAtrasAr;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.DataGridView dgvDetalle;
    }
}