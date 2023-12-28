namespace Practica1.Forms
{
    partial class FormER
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
            this.btnGENERAR_AFND = new System.Windows.Forms.Button();
            this.listaAFD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CadenaAnalizar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSUBIR_ARCHIVO = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idAFND = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(113, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasar Expresión Regular a AFND";
            // 
            // btnGENERAR_AFND
            // 
            this.btnGENERAR_AFND.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.btnGENERAR_AFND.Location = new System.Drawing.Point(485, 175);
            this.btnGENERAR_AFND.Name = "btnGENERAR_AFND";
            this.btnGENERAR_AFND.Size = new System.Drawing.Size(257, 71);
            this.btnGENERAR_AFND.TabIndex = 25;
            this.btnGENERAR_AFND.Text = "GENERAR AFND";
            this.btnGENERAR_AFND.UseVisualStyleBackColor = true;
            this.btnGENERAR_AFND.Click += new System.EventHandler(this.btnGENERAR_AFND_Click);
            // 
            // listaAFD
            // 
            this.listaAFD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaAFD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaAFD.FormattingEnabled = true;
            this.listaAFD.Location = new System.Drawing.Point(571, 77);
            this.listaAFD.Name = "listaAFD";
            this.listaAFD.Size = new System.Drawing.Size(171, 21);
            this.listaAFD.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "AFD a utilizar";
            // 
            // CadenaAnalizar
            // 
            this.CadenaAnalizar.Location = new System.Drawing.Point(571, 104);
            this.CadenaAnalizar.Name = "CadenaAnalizar";
            this.CadenaAnalizar.Size = new System.Drawing.Size(171, 20);
            this.CadenaAnalizar.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cadena a Analizar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cargar AFD";
            // 
            // btnSUBIR_ARCHIVO
            // 
            this.btnSUBIR_ARCHIVO.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.btnSUBIR_ARCHIVO.Location = new System.Drawing.Point(133, 66);
            this.btnSUBIR_ARCHIVO.Name = "btnSUBIR_ARCHIVO";
            this.btnSUBIR_ARCHIVO.Size = new System.Drawing.Size(68, 29);
            this.btnSUBIR_ARCHIVO.TabIndex = 49;
            this.btnSUBIR_ARCHIVO.Text = "SUBIR";
            this.btnSUBIR_ARCHIVO.UseVisualStyleBackColor = true;
            this.btnSUBIR_ARCHIVO.Click += new System.EventHandler(this.btnSUBIR_ARCHIVO_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelect.Location = new System.Drawing.Point(31, 94);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(177, 30);
            this.btnSelect.TabIndex = 50;
            this.btnSelect.Text = "SELECCIONAR ARCHIVO";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ingresa el ID para el AFND";
            // 
            // idAFND
            // 
            this.idAFND.Location = new System.Drawing.Point(571, 134);
            this.idAFND.Name = "idAFND";
            this.idAFND.Size = new System.Drawing.Size(171, 20);
            this.idAFND.TabIndex = 52;
            // 
            // FormER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idAFND);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSUBIR_ARCHIVO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CadenaAnalizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listaAFD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGENERAR_AFND);
            this.Controls.Add(this.label1);
            this.Name = "FormER";
            this.Text = "Expresión regular a AFND";
            this.Load += new System.EventHandler(this.FormER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGENERAR_AFND;
        private System.Windows.Forms.ComboBox listaAFD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CadenaAnalizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSUBIR_ARCHIVO;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idAFND;
    }
}