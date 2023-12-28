namespace Practica1.Forms
{
    partial class FormBasico
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
            this.components = new System.ComponentModel.Container();
            this.btnCrear_AFND = new System.Windows.Forms.Button();
            this.checkAscii = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Caracter_Inf = new System.Windows.Forms.TextBox();
            this.Caracter_Sup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_AFND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear_AFND
            // 
            this.btnCrear_AFND.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrear_AFND.Location = new System.Drawing.Point(12, 277);
            this.btnCrear_AFND.Name = "btnCrear_AFND";
            this.btnCrear_AFND.Size = new System.Drawing.Size(191, 54);
            this.btnCrear_AFND.TabIndex = 0;
            this.btnCrear_AFND.Text = "CREAR AFND";
            this.btnCrear_AFND.UseVisualStyleBackColor = true;
            this.btnCrear_AFND.Click += new System.EventHandler(this.btnCrear_AFND_Click);
            // 
            // checkAscii
            // 
            this.checkAscii.AutoSize = true;
            this.checkAscii.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F, System.Drawing.FontStyle.Bold);
            this.checkAscii.Location = new System.Drawing.Point(28, 89);
            this.checkAscii.Name = "checkAscii";
            this.checkAscii.Size = new System.Drawing.Size(165, 24);
            this.checkAscii.TabIndex = 1;
            this.checkAscii.Text = "Usar Código ASCII";
            this.checkAscii.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caracter Inf";
            // 
            // Caracter_Inf
            // 
            this.Caracter_Inf.Location = new System.Drawing.Point(125, 153);
            this.Caracter_Inf.Name = "Caracter_Inf";
            this.Caracter_Inf.Size = new System.Drawing.Size(126, 20);
            this.Caracter_Inf.TabIndex = 3;
            this.Caracter_Inf.TextChanged += new System.EventHandler(this.Caracter_Inf_TextChanged);
            // 
            // Caracter_Sup
            // 
            this.Caracter_Sup.Location = new System.Drawing.Point(125, 192);
            this.Caracter_Sup.Name = "Caracter_Sup";
            this.Caracter_Sup.Size = new System.Drawing.Size(126, 20);
            this.Caracter_Sup.TabIndex = 5;
            this.Caracter_Sup.TextChanged += new System.EventHandler(this.Caracter_Sup_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caracter Sup";
            // 
            // ID_AFND
            // 
            this.ID_AFND.Location = new System.Drawing.Point(125, 227);
            this.ID_AFND.Name = "ID_AFND";
            this.ID_AFND.Size = new System.Drawing.Size(126, 20);
            this.ID_AFND.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID del AFND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "Crear transición Básica";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Practica1.Properties.Resources.básicoFinal_removebg_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(266, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 142);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormBasico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID_AFND);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Caracter_Sup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Caracter_Inf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkAscii);
            this.Controls.Add(this.btnCrear_AFND);
            this.Name = "FormBasico";
            this.Text = "Crear Básico";
            this.Load += new System.EventHandler(this.FormBasico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear_AFND;
        private System.Windows.Forms.CheckBox checkAscii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Caracter_Inf;
        private System.Windows.Forms.TextBox Caracter_Sup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_AFND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}