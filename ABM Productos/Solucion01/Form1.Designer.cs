namespace Solucion01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boton1 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.AccessibleName = "";
            this.boton1.BackColor = System.Drawing.Color.CadetBlue;
            this.boton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton1.FlatAppearance.BorderSize = 2;
            this.boton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.Color.White;
            this.boton1.Location = new System.Drawing.Point(109, 126);
            this.boton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(275, 36);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "LISTA ARTÍCULOS";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.Listas_Click);
            // 
            // boton4
            // 
            this.boton4.AccessibleName = "";
            this.boton4.BackColor = System.Drawing.Color.CadetBlue;
            this.boton4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton4.FlatAppearance.BorderSize = 2;
            this.boton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.boton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton4.ForeColor = System.Drawing.Color.White;
            this.boton4.Location = new System.Drawing.Point(558, 212);
            this.boton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(275, 36);
            this.boton4.TabIndex = 1;
            this.boton4.Text = "MODIFICAR";
            this.boton4.UseVisualStyleBackColor = false;
            // 
            // boton2
            // 
            this.boton2.AccessibleName = "";
            this.boton2.BackColor = System.Drawing.Color.CadetBlue;
            this.boton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton2.FlatAppearance.BorderSize = 2;
            this.boton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.ForeColor = System.Drawing.Color.White;
            this.boton2.Location = new System.Drawing.Point(558, 126);
            this.boton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(275, 36);
            this.boton2.TabIndex = 2;
            this.boton2.Text = "BUSCAR";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // boton3
            // 
            this.boton3.AccessibleName = "";
            this.boton3.BackColor = System.Drawing.Color.CadetBlue;
            this.boton3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton3.FlatAppearance.BorderSize = 2;
            this.boton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.boton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton3.ForeColor = System.Drawing.Color.White;
            this.boton3.Location = new System.Drawing.Point(109, 212);
            this.boton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(275, 36);
            this.boton3.TabIndex = 3;
            this.boton3.Text = "AGREGAR ARTÍCULOS";
            this.boton3.UseVisualStyleBackColor = false;
            // 
            // titulo
            // 
            this.titulo.AccessibleName = "";
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.White;
            this.titulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(232, 37);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(513, 31);
            this.titulo.TabIndex = 4;
            this.titulo.Text = " ADMINISTRACIÓN DE ARTÍCULOS";
            // 
            // boton5
            // 
            this.boton5.AccessibleName = "";
            this.boton5.BackColor = System.Drawing.Color.CadetBlue;
            this.boton5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton5.FlatAppearance.BorderSize = 2;
            this.boton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.boton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton5.ForeColor = System.Drawing.Color.White;
            this.boton5.Location = new System.Drawing.Point(109, 300);
            this.boton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(275, 36);
            this.boton5.TabIndex = 5;
            this.boton5.Text = "ELIMINAR\r\n";
            this.boton5.UseVisualStyleBackColor = false;
            // 
            // boton6
            // 
            this.boton6.AccessibleName = "";
            this.boton6.BackColor = System.Drawing.Color.CadetBlue;
            this.boton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boton6.FlatAppearance.BorderSize = 2;
            this.boton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.boton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton6.ForeColor = System.Drawing.Color.White;
            this.boton6.Location = new System.Drawing.Point(558, 300);
            this.boton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(275, 36);
            this.boton6.TabIndex = 6;
            this.boton6.Text = "DETALLE DE UN ARTÍCULO ";
            this.boton6.UseVisualStyleBackColor = false;
            // 
            // botonAtras
            // 
            this.botonAtras.AccessibleName = "";
            this.botonAtras.BackColor = System.Drawing.Color.White;
            this.botonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAtras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonAtras.FlatAppearance.BorderSize = 2;
            this.botonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtras.ForeColor = System.Drawing.Color.White;
            this.botonAtras.Image = global::Solucion01.Properties.Resources.flecha_atras;
            this.botonAtras.Location = new System.Drawing.Point(13, 14);
            this.botonAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(90, 81);
            this.botonAtras.TabIndex = 8;
            this.botonAtras.UseVisualStyleBackColor = false;
            this.botonAtras.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Solucion01.Properties.Resources.Fondo4;
            this.ClientSize = new System.Drawing.Size(943, 373);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button botonAtras;
    }
}

