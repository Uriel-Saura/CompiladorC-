namespace Practica1.Forms
{
    partial class FormUAnalizador_Lexico
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
            this.listaAFND = new System.Windows.Forms.DataGridView();
            this.Lista_AFNDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUNIR_AFNDS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idAFD = new System.Windows.Forms.Label();
            this.Id_AFDResultante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listaAFND)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unir Analizador Léxico";
            // 
            // listaAFND
            // 
            this.listaAFND.AllowUserToAddRows = false;
            this.listaAFND.AllowUserToDeleteRows = false;
            this.listaAFND.AllowUserToResizeColumns = false;
            this.listaAFND.AllowUserToResizeRows = false;
            this.listaAFND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaAFND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaAFND.BackgroundColor = System.Drawing.Color.White;
            this.listaAFND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaAFND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaAFND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lista_AFNDS,
            this.Token});
            this.listaAFND.Location = new System.Drawing.Point(115, 90);
            this.listaAFND.Name = "listaAFND";
            this.listaAFND.Size = new System.Drawing.Size(580, 295);
            this.listaAFND.TabIndex = 4;
            // 
            // Lista_AFNDS
            // 
            this.Lista_AFNDS.HeaderText = "Lista de AFND\'S";
            this.Lista_AFNDS.Name = "Lista_AFNDS";
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            // 
            // btnUNIR_AFNDS
            // 
            this.btnUNIR_AFNDS.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.btnUNIR_AFNDS.Location = new System.Drawing.Point(549, 391);
            this.btnUNIR_AFNDS.Name = "btnUNIR_AFNDS";
            this.btnUNIR_AFNDS.Size = new System.Drawing.Size(146, 47);
            this.btnUNIR_AFNDS.TabIndex = 26;
            this.btnUNIR_AFNDS.Text = "UNIR AFNDS";
            this.btnUNIR_AFNDS.UseVisualStyleBackColor = true;
            this.btnUNIR_AFNDS.Click += new System.EventHandler(this.btnUNIR_AFNDS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(119, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = " Para omitir los lexemas de una clase léxica,  use el TOKEN 20001";
            // 
            // idAFD
            // 
            this.idAFD.AutoSize = true;
            this.idAFD.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAFD.Location = new System.Drawing.Point(120, 403);
            this.idAFD.Name = "idAFD";
            this.idAFD.Size = new System.Drawing.Size(163, 21);
            this.idAFD.TabIndex = 28;
            this.idAFD.Text = "Id del AFD resultante";
            // 
            // Id_AFDResultante
            // 
            this.Id_AFDResultante.Location = new System.Drawing.Point(290, 404);
            this.Id_AFDResultante.Name = "Id_AFDResultante";
            this.Id_AFDResultante.Size = new System.Drawing.Size(177, 20);
            this.Id_AFDResultante.TabIndex = 29;
            // 
            // FormUAnalizador_Lexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Id_AFDResultante);
            this.Controls.Add(this.idAFD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUNIR_AFNDS);
            this.Controls.Add(this.listaAFND);
            this.Controls.Add(this.label1);
            this.Name = "FormUAnalizador_Lexico";
            this.Text = "Unir Analizador Léxico";
            this.Load += new System.EventHandler(this.FormUAnalizador_Lexico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaAFND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listaAFND;
        private System.Windows.Forms.Button btnUNIR_AFNDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idAFD;
        private System.Windows.Forms.TextBox Id_AFDResultante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista_AFNDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
    }
}