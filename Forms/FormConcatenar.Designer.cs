namespace Practica1.Forms
{
    partial class FormConcatenar
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
            this.label3 = new System.Windows.Forms.Label();
            this.concatenar = new System.Windows.Forms.ComboBox();
            this.con = new System.Windows.Forms.ComboBox();
            this.btnConcat_AFND = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(211, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Concatenar Automatas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Concatenar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Con";
            // 
            // concatenar
            // 
            this.concatenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.concatenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concatenar.FormattingEnabled = true;
            this.concatenar.Location = new System.Drawing.Point(271, 162);
            this.concatenar.Name = "concatenar";
            this.concatenar.Size = new System.Drawing.Size(287, 21);
            this.concatenar.TabIndex = 11;
            // 
            // con
            // 
            this.con.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.con.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.con.FormattingEnabled = true;
            this.con.Location = new System.Drawing.Point(271, 234);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(287, 21);
            this.con.TabIndex = 12;
            // 
            // btnConcat_AFND
            // 
            this.btnConcat_AFND.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.btnConcat_AFND.Location = new System.Drawing.Point(319, 298);
            this.btnConcat_AFND.Name = "btnConcat_AFND";
            this.btnConcat_AFND.Size = new System.Drawing.Size(191, 54);
            this.btnConcat_AFND.TabIndex = 14;
            this.btnConcat_AFND.Text = "CONCATENAR AFND\'S";
            this.btnConcat_AFND.UseVisualStyleBackColor = true;
            this.btnConcat_AFND.Click += new System.EventHandler(this.btnConcat_AFND_Click);
            // 
            // FormConcatenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConcat_AFND);
            this.Controls.Add(this.con);
            this.Controls.Add(this.concatenar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConcatenar";
            this.Text = "Concatenar";
            this.Load += new System.EventHandler(this.FormConcatenar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox concatenar;
        private System.Windows.Forms.ComboBox con;
        private System.Windows.Forms.Button btnConcat_AFND;
    }
}