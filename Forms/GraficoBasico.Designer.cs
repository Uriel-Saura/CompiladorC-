namespace Practica1.Graficos
{
    partial class GraficoBasico
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
            this.inicial = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.Label();
            this.rango = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // inicial
            // 
            this.inicial.AutoSize = true;
            this.inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicial.Location = new System.Drawing.Point(159, 188);
            this.inicial.Name = "inicial";
            this.inicial.Size = new System.Drawing.Size(61, 25);
            this.inicial.TabIndex = 1;
            this.inicial.Text = "Inicial";
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final.Location = new System.Drawing.Point(490, 188);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(54, 25);
            this.final.TabIndex = 2;
            this.final.Text = "Final";
            // 
            // rango
            // 
            this.rango.AutoSize = true;
            this.rango.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rango.Location = new System.Drawing.Point(280, 149);
            this.rango.Name = "rango";
            this.rango.Size = new System.Drawing.Size(118, 39);
            this.rango.TabIndex = 3;
            this.rango.Text = "Rango";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 47);
            this.label4.TabIndex = 9;
            this.label4.Text = "Creación del Básico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // GraficoBasico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 364);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rango);
            this.Controls.Add(this.final);
            this.Controls.Add(this.inicial);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GraficoBasico";
            this.Text = "GraficoBasico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label inicial;
        private System.Windows.Forms.Label final;
        private System.Windows.Forms.Label rango;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}