namespace dominio
{
    partial class AgregarCategoria
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btbAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbCategorias = new System.Windows.Forms.Label();
            this.lbObligatorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::Solucion01.Properties.Resources.flecha_atras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtras.FlatAppearance.BorderSize = 3;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(67, 67);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "&";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(175, 166);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(205, 37);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(418, 166);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(210, 31);
            this.txtDescripcion.TabIndex = 1;
            // 
            // btbAceptar
            // 
            this.btbAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btbAceptar.FlatAppearance.BorderSize = 3;
            this.btbAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btbAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbAceptar.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold);
            this.btbAceptar.Location = new System.Drawing.Point(160, 257);
            this.btbAceptar.Name = "btbAceptar";
            this.btbAceptar.Size = new System.Drawing.Size(199, 57);
            this.btbAceptar.TabIndex = 2;
            this.btbAceptar.Text = "&Aceptar";
            this.btbAceptar.UseVisualStyleBackColor = true;
            this.btbAceptar.Click += new System.EventHandler(this.btbAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(418, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(199, 57);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategorias.Location = new System.Drawing.Point(238, 33);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(320, 57);
            this.lbCategorias.TabIndex = 5;
            this.lbCategorias.Text = "CATEGORIAS";
            // 
            // lbObligatorio
            // 
            this.lbObligatorio.AutoSize = true;
            this.lbObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObligatorio.ForeColor = System.Drawing.Color.Maroon;
            this.lbObligatorio.Location = new System.Drawing.Point(634, 166);
            this.lbObligatorio.Name = "lbObligatorio";
            this.lbObligatorio.Size = new System.Drawing.Size(33, 42);
            this.lbObligatorio.TabIndex = 6;
            this.lbObligatorio.Text = "*";
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbObligatorio);
            this.Controls.Add(this.lbCategorias);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btbAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnAtras);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "AgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCategoria";
            this.Load += new System.EventHandler(this.AgregarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btbAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbCategorias;
        private System.Windows.Forms.Label lbObligatorio;
    }
}