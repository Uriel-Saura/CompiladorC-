namespace Practica1.Forms
{
    partial class FormProbarAL
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
            this.btnSUBIR_ARCHIVO = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listaAFD = new System.Windows.Forms.ComboBox();
            this.CadenaAnalizar = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.infoAnalizador = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexemas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoAnalizador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(186, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Probar Analizador Léxico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cargar AFD";
            // 
            // btnSUBIR_ARCHIVO
            // 
            this.btnSUBIR_ARCHIVO.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.btnSUBIR_ARCHIVO.Location = new System.Drawing.Point(96, 50);
            this.btnSUBIR_ARCHIVO.Name = "btnSUBIR_ARCHIVO";
            this.btnSUBIR_ARCHIVO.Size = new System.Drawing.Size(68, 26);
            this.btnSUBIR_ARCHIVO.TabIndex = 27;
            this.btnSUBIR_ARCHIVO.Text = "SUBIR";
            this.btnSUBIR_ARCHIVO.UseVisualStyleBackColor = true;
            this.btnSUBIR_ARCHIVO.Click += new System.EventHandler(this.btnSUBIR_ARCHIVO_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "AFD a utilizar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cadena a Analizar";
            // 
            // listaAFD
            // 
            this.listaAFD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaAFD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaAFD.FormattingEnabled = true;
            this.listaAFD.Location = new System.Drawing.Point(532, 55);
            this.listaAFD.Name = "listaAFD";
            this.listaAFD.Size = new System.Drawing.Size(171, 21);
            this.listaAFD.TabIndex = 31;
            // 
            // CadenaAnalizar
            // 
            this.CadenaAnalizar.Location = new System.Drawing.Point(532, 84);
            this.CadenaAnalizar.Name = "CadenaAnalizar";
            this.CadenaAnalizar.Size = new System.Drawing.Size(171, 20);
            this.CadenaAnalizar.TabIndex = 32;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.btnAnalizar.Location = new System.Drawing.Point(720, 53);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(68, 51);
            this.btnAnalizar.TabIndex = 33;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // infoAnalizador
            // 
            this.infoAnalizador.AllowUserToAddRows = false;
            this.infoAnalizador.AllowUserToDeleteRows = false;
            this.infoAnalizador.AllowUserToResizeColumns = false;
            this.infoAnalizador.AllowUserToResizeRows = false;
            this.infoAnalizador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoAnalizador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoAnalizador.BackgroundColor = System.Drawing.Color.White;
            this.infoAnalizador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoAnalizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoAnalizador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexemas});
            this.infoAnalizador.Location = new System.Drawing.Point(12, 110);
            this.infoAnalizador.Name = "infoAnalizador";
            this.infoAnalizador.Size = new System.Drawing.Size(776, 304);
            this.infoAnalizador.TabIndex = 35;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            // 
            // Lexemas
            // 
            this.Lexemas.HeaderText = "Lexemas";
            this.Lexemas.Name = "Lexemas";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(12, 420);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(173, 26);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "GUARDAR AFD";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelect.Location = new System.Drawing.Point(12, 78);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(177, 27);
            this.btnSelect.TabIndex = 37;
            this.btnSelect.Text = "SELECCIONAR ARCHIVO";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FormProbarAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.infoAnalizador);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.CadenaAnalizar);
            this.Controls.Add(this.listaAFD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSUBIR_ARCHIVO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProbarAL";
            this.Text = "Probar Analizador Léxico";
            this.Load += new System.EventHandler(this.FormProbarAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoAnalizador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSUBIR_ARCHIVO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listaAFD;
        private System.Windows.Forms.TextBox CadenaAnalizar;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.DataGridView infoAnalizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexemas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSelect;
    }
}