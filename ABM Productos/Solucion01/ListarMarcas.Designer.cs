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
            this.dgvListarMarcas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btCierreMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarMarcas
            // 
            this.dgvListarMarcas.BackgroundColor = System.Drawing.Color.White;
            this.dgvListarMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListarMarcas.Location = new System.Drawing.Point(283, 96);
            this.dgvListarMarcas.Name = "dgvListarMarcas";
            this.dgvListarMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarMarcas.Size = new System.Drawing.Size(246, 284);
            this.dgvListarMarcas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "LISTADO DE MARCAS";
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btEliminar.FlatAppearance.BorderSize = 3;
            this.btEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(436, 414);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(188, 62);
            this.btEliminar.TabIndex = 1;
            this.btEliminar.Text = "&ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click_1);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.Color.CadetBlue;
            this.btModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btModificar.FlatAppearance.BorderSize = 3;
            this.btModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(191, 414);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(188, 62);
            this.btModificar.TabIndex = 0;
            this.btModificar.Text = "&MODIFICAR";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.Modificar_Click_1);
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
            this.btCierreMarcas.Location = new System.Drawing.Point(2, 9);
            this.btCierreMarcas.Name = "btCierreMarcas";
            this.btCierreMarcas.Size = new System.Drawing.Size(63, 54);
            this.btCierreMarcas.TabIndex = 2;
            this.btCierreMarcas.Text = "&";
            this.btCierreMarcas.UseVisualStyleBackColor = false;
            this.btCierreMarcas.Click += new System.EventHandler(this.btCierreMarcas_Click);
            // 
            // ListarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.btCierreMarcas);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListarMarcas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 553);
            this.Name = "ListarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarMarcas";
            this.Load += new System.EventHandler(this.ListarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarMarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btCierreMarcas;
    }
}