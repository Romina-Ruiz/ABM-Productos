namespace Solucion01
{
    partial class ModificarMarca
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
            this.lbModificarMarca = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.txtModificar = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btCierreMarcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbModificarMarca
            // 
            this.lbModificarMarca.AutoSize = true;
            this.lbModificarMarca.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbModificarMarca.Location = new System.Drawing.Point(237, 40);
            this.lbModificarMarca.Name = "lbModificarMarca";
            this.lbModificarMarca.Size = new System.Drawing.Size(364, 44);
            this.lbModificarMarca.TabIndex = 4;
            this.lbModificarMarca.Text = "MODIFICAR MARCA";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.CadetBlue;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCancelar.FlatAppearance.BorderSize = 3;
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btCancelar.Location = new System.Drawing.Point(405, 328);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(185, 55);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "&CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.CadetBlue;
            this.btAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAceptar.FlatAppearance.BorderSize = 3;
            this.btAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btAceptar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btAceptar.Location = new System.Drawing.Point(200, 328);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(186, 55);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "&ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // txtModificar
            // 
            this.txtModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificar.Location = new System.Drawing.Point(400, 196);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(190, 29);
            this.txtModificar.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lbNombre.Location = new System.Drawing.Point(221, 189);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(148, 37);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "Nombre:";
            // 
            // btCierreMarcas
            // 
            this.btCierreMarcas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCierreMarcas.BackColor = System.Drawing.Color.Tan;
            this.btCierreMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCierreMarcas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCierreMarcas.FlatAppearance.BorderSize = 3;
            this.btCierreMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btCierreMarcas.Image = global::Solucion01.Properties.Resources.flecha_atras;
            this.btCierreMarcas.Location = new System.Drawing.Point(3, 3);
            this.btCierreMarcas.Name = "btCierreMarcas";
            this.btCierreMarcas.Size = new System.Drawing.Size(63, 54);
            this.btCierreMarcas.TabIndex = 3;
            this.btCierreMarcas.UseVisualStyleBackColor = false;
            this.btCierreMarcas.Click += new System.EventHandler(this.btCierreMarcas_Click);
            // 
            // ModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCierreMarcas);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txtModificar);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbModificarMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "ModificarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarMarca";
            this.Load += new System.EventHandler(this.ModificarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbModificarMarca;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox txtModificar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btCierreMarcas;
    }
}