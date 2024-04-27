namespace Solucion01
{
    partial class AgregarMarcas
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
            this.lbMarcas = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCierreMarcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMarcas
            // 
            this.lbMarcas.AutoSize = true;
            this.lbMarcas.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold);
            this.lbMarcas.Location = new System.Drawing.Point(335, 28);
            this.lbMarcas.Name = "lbMarcas";
            this.lbMarcas.Size = new System.Drawing.Size(169, 44);
            this.lbMarcas.TabIndex = 0;
            this.lbMarcas.Text = "MARCAS";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lbNombre.Location = new System.Drawing.Point(241, 160);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(138, 37);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(415, 167);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 29);
            this.txtNombre.TabIndex = 4;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.LightCoral;
            this.btAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAceptar.FlatAppearance.BorderSize = 3;
            this.btAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(213, 291);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(166, 52);
            this.btAceptar.TabIndex = 5;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCancelar.FlatAppearance.BorderSize = 3;
            this.btCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(439, 291);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(166, 52);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCierreMarcas
            // 
            this.btCierreMarcas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCierreMarcas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btCierreMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCierreMarcas.FlatAppearance.BorderSize = 3;
            this.btCierreMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btCierreMarcas.Image = global::Solucion01.Properties.Resources.flecha_atras;
            this.btCierreMarcas.Location = new System.Drawing.Point(2, 12);
            this.btCierreMarcas.Name = "btCierreMarcas";
            this.btCierreMarcas.Size = new System.Drawing.Size(63, 54);
            this.btCierreMarcas.TabIndex = 15;
            this.btCierreMarcas.UseVisualStyleBackColor = false;
            this.btCierreMarcas.Click += new System.EventHandler(this.btCierreMarcas_Click);
            // 
            // AgregarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCierreMarcas);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbMarcas);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AgregarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMarcas";
            this.Load += new System.EventHandler(this.AgregarMarcas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMarcas;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btCierreMarcas;
    }
}