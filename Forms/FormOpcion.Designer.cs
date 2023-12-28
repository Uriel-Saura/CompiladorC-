namespace Practica1.Forms
{
    partial class FormOpcion
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
            this.btnConcat_AFND = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(244, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crear Opcional";
            // 
            // btnConcat_AFND
            // 
            this.btnConcat_AFND.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.btnConcat_AFND.Location = new System.Drawing.Point(458, 349);
            this.btnConcat_AFND.Name = "btnConcat_AFND";
            this.btnConcat_AFND.Size = new System.Drawing.Size(191, 54);
            this.btnConcat_AFND.TabIndex = 28;
            this.btnConcat_AFND.Text = "APLICAR CERRADURA *";
            this.btnConcat_AFND.UseVisualStyleBackColor = true;
            this.btnConcat_AFND.Click += new System.EventHandler(this.btnConcat_AFND_Click);
            // 
            // lista
            // 
            this.lista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(423, 228);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(287, 21);
            this.lista.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Lista de autómatas";
            // 
            // FormOpcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConcat_AFND);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOpcion";
            this.Text = "Opcional";
            this.Load += new System.EventHandler(this.FormOpcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConcat_AFND;
        private System.Windows.Forms.ComboBox lista;
        private System.Windows.Forms.Label label2;
    }
}