﻿namespace Solucion01
{
    partial class Buscar
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
            this.dgvBuscarMarca = new System.Windows.Forms.DataGridView();
            this.lbBuscarMarca = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarMarca
            // 
            this.dgvBuscarMarca.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvBuscarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarMarca.Location = new System.Drawing.Point(268, 80);
            this.dgvBuscarMarca.Name = "dgvBuscarMarca";
            this.dgvBuscarMarca.Size = new System.Drawing.Size(268, 223);
            this.dgvBuscarMarca.TabIndex = 2;
            // 
            // lbBuscarMarca
            // 
            this.lbBuscarMarca.AutoSize = true;
            this.lbBuscarMarca.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbBuscarMarca.Location = new System.Drawing.Point(248, 9);
            this.lbBuscarMarca.Name = "lbBuscarMarca";
            this.lbBuscarMarca.Size = new System.Drawing.Size(305, 44);
            this.lbBuscarMarca.TabIndex = 3;
            this.lbBuscarMarca.Text = "BUSCAR MARCA";
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.RosyBrown;
            this.Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Modificar.FlatAppearance.BorderSize = 2;
            this.Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Modificar.Location = new System.Drawing.Point(176, 350);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(188, 62);
            this.Modificar.TabIndex = 4;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseMnemonic = false;
            this.Modificar.UseVisualStyleBackColor = false;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.RosyBrown;
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btEliminar.Location = new System.Drawing.Point(423, 350);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(188, 62);
            this.btEliminar.TabIndex = 5;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.lbBuscarMarca);
            this.Controls.Add(this.dgvBuscarMarca);
            this.Name = "Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Marcas";
            this.Load += new System.EventHandler(this.BuscarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarMarca;
        private System.Windows.Forms.Label lbBuscarMarca;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button btEliminar;
    }
}