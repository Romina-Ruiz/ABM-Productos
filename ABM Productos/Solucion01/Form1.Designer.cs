﻿namespace Solucion01
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
            this.Listas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Listas
            // 
            this.Listas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listas.Location = new System.Drawing.Point(109, 126);
            this.Listas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Listas.Name = "Listas";
            this.Listas.Size = new System.Drawing.Size(275, 26);
            this.Listas.TabIndex = 0;
            this.Listas.Text = "LISTA ARTÍCULOS";
            this.Listas.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 212);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BUSCAR
            // 
            this.BUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUSCAR.Location = new System.Drawing.Point(558, 126);
            this.BUSCAR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(275, 26);
            this.BUSCAR.TabIndex = 2;
            this.BUSCAR.Text = "BUSCAR";
            this.BUSCAR.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(109, 212);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(275, 26);
            this.button4.TabIndex = 3;
            this.button4.Text = "AGREGAR ARTÍCULOS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = " ADMINISTRACIÓN DE ARTÍCULOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "ELIMINAR\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 300);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "DETALLE DE UN ARTÍCULO ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 373);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Listas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Listas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

