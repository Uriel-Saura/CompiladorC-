namespace Practica1.Forms
{
    partial class FormAFND_AFD
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
            this.Name_EscogerAFND = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ComboBox();
            this.Name_idAFND = new System.Windows.Forms.Label();
            this.IdAFD = new System.Windows.Forms.TextBox();
            this.btnCrear_AFD = new System.Windows.Forms.Button();
            this.AFD = new System.Windows.Forms.Label();
            this.infoAFD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.infoAFD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(212, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Convertir AFND a AFD";
            // 
            // Name_EscogerAFND
            // 
            this.Name_EscogerAFND.AutoSize = true;
            this.Name_EscogerAFND.Font = new System.Drawing.Font("Yu Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_EscogerAFND.Location = new System.Drawing.Point(24, 98);
            this.Name_EscogerAFND.Name = "Name_EscogerAFND";
            this.Name_EscogerAFND.Size = new System.Drawing.Size(217, 23);
            this.Name_EscogerAFND.TabIndex = 6;
            this.Name_EscogerAFND.Text = "AFND a convertir a AFD";
            // 
            // lista
            // 
            this.lista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(263, 98);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(287, 21);
            this.lista.TabIndex = 18;
            // 
            // Name_idAFND
            // 
            this.Name_idAFND.AutoSize = true;
            this.Name_idAFND.Font = new System.Drawing.Font("Yu Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_idAFND.Location = new System.Drawing.Point(137, 134);
            this.Name_idAFND.Name = "Name_idAFND";
            this.Name_idAFND.Size = new System.Drawing.Size(104, 23);
            this.Name_idAFND.TabIndex = 19;
            this.Name_idAFND.Text = "ID del AFD";
            // 
            // IdAFD
            // 
            this.IdAFD.Location = new System.Drawing.Point(264, 134);
            this.IdAFD.Name = "IdAFD";
            this.IdAFD.Size = new System.Drawing.Size(285, 20);
            this.IdAFD.TabIndex = 20;
            // 
            // btnCrear_AFD
            // 
            this.btnCrear_AFD.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrear_AFD.Location = new System.Drawing.Point(582, 98);
            this.btnCrear_AFD.Name = "btnCrear_AFD";
            this.btnCrear_AFD.Size = new System.Drawing.Size(191, 54);
            this.btnCrear_AFD.TabIndex = 21;
            this.btnCrear_AFD.Text = "CREAR AFD Y GUARDAR";
            this.btnCrear_AFD.UseVisualStyleBackColor = true;
            this.btnCrear_AFD.Click += new System.EventHandler(this.btnCrear_AFD_Click);
            // 
            // AFD
            // 
            this.AFD.AutoSize = true;
            this.AFD.Font = new System.Drawing.Font("Yu Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AFD.Location = new System.Drawing.Point(8, 179);
            this.AFD.Name = "AFD";
            this.AFD.Size = new System.Drawing.Size(47, 23);
            this.AFD.TabIndex = 23;
            this.AFD.Text = "AFD";
            // 
            // infoAFD
            // 
            this.infoAFD.AllowUserToAddRows = false;
            this.infoAFD.AllowUserToDeleteRows = false;
            this.infoAFD.AllowUserToResizeColumns = false;
            this.infoAFD.AllowUserToResizeRows = false;
            this.infoAFD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoAFD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.infoAFD.BackgroundColor = System.Drawing.Color.White;
            this.infoAFD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoAFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoAFD.Location = new System.Drawing.Point(61, 160);
            this.infoAFD.Name = "infoAFD";
            this.infoAFD.Size = new System.Drawing.Size(727, 278);
            this.infoAFD.TabIndex = 36;
            // 
            // FormAFND_AFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoAFD);
            this.Controls.Add(this.AFD);
            this.Controls.Add(this.btnCrear_AFD);
            this.Controls.Add(this.IdAFD);
            this.Controls.Add(this.Name_idAFND);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.Name_EscogerAFND);
            this.Controls.Add(this.label1);
            this.Name = "FormAFND_AFD";
            this.Text = "Convertir AFND a AFD";
            this.Load += new System.EventHandler(this.FormAFND_AFD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoAFD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_EscogerAFND;
        private System.Windows.Forms.ComboBox lista;
        private System.Windows.Forms.Label Name_idAFND;
        private System.Windows.Forms.TextBox IdAFD;
        private System.Windows.Forms.Button btnCrear_AFD;
        private System.Windows.Forms.Label AFD;
        private System.Windows.Forms.DataGridView infoAFD;
    }
}