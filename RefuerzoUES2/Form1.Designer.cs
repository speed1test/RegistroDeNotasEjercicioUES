﻿namespace RefuerzoUES2
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
            this.brnFuncion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brnFuncion
            // 
            this.brnFuncion.Location = new System.Drawing.Point(86, 25);
            this.brnFuncion.Name = "brnFuncion";
            this.brnFuncion.Size = new System.Drawing.Size(181, 69);
            this.brnFuncion.TabIndex = 0;
            this.brnFuncion.Text = "Acción (Leer y Imprimir)";
            this.brnFuncion.UseVisualStyleBackColor = true;
            this.brnFuncion.Click += new System.EventHandler(this.brnFuncion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 117);
            this.Controls.Add(this.brnFuncion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brnFuncion;
    }
}

