﻿namespace EjemplomenuejercicioCondiciones
{
    partial class Ejercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLRESULTADO = new System.Windows.Forms.Label();
            this.txtevaluar = new System.Windows.Forms.Button();
            this.pbsalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evalua si un numero es positivo o negativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa un numero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(400, 138);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 26);
            this.txtnumero.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // LBLRESULTADO
            // 
            this.LBLRESULTADO.AutoSize = true;
            this.LBLRESULTADO.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRESULTADO.Location = new System.Drawing.Point(291, 224);
            this.LBLRESULTADO.Name = "LBLRESULTADO";
            this.LBLRESULTADO.Size = new System.Drawing.Size(103, 22);
            this.LBLRESULTADO.TabIndex = 6;
            this.LBLRESULTADO.Text = "Resultado";
            // 
            // txtevaluar
            // 
            this.txtevaluar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtevaluar.Location = new System.Drawing.Point(541, 158);
            this.txtevaluar.Name = "txtevaluar";
            this.txtevaluar.Size = new System.Drawing.Size(108, 47);
            this.txtevaluar.TabIndex = 7;
            this.txtevaluar.Text = "Evaluar";
            this.txtevaluar.UseVisualStyleBackColor = true;
            this.txtevaluar.Click += new System.EventHandler(this.txtevaluar_Click);
            // 
            // pbsalir
            // 
            this.pbsalir.Image = global::EjemplomenuejercicioCondiciones.Properties.Resources.png_transparent_button_computer_icons_exit_angle_rectangle_logo_thumbnail;
            this.pbsalir.Location = new System.Drawing.Point(541, 292);
            this.pbsalir.Name = "pbsalir";
            this.pbsalir.Size = new System.Drawing.Size(100, 50);
            this.pbsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsalir.TabIndex = 8;
            this.pbsalir.TabStop = false;
            this.pbsalir.Click += new System.EventHandler(this.pbsalir_Click);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 406);
            this.Controls.Add(this.pbsalir);
            this.Controls.Add(this.txtevaluar);
            this.Controls.Add(this.LBLRESULTADO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.pbsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBLRESULTADO;
        private System.Windows.Forms.Button txtevaluar;
        private System.Windows.Forms.PictureBox pbsalir;
    }
}