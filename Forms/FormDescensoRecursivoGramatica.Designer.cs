namespace Practica1.Forms
{
    partial class FormDescensoRecursivoGramatica
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
            this.textGramatica = new System.Windows.Forms.TextBox();
            this.btnConcat_AFND = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cadenaSigma = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataTablaLL1 = new System.Windows.Forms.DataGridView();
            this.listaNoTerminal = new System.Windows.Forms.DataGridView();
            this.Lista_AFNDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaTerminales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tokens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSUBIR_ARCHIVO = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listaAFD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.infoAnalizador = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexemas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataListaAFND = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablaLL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNoTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTerminales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAnalizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaAFND)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(295, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Análisis LL(1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gramática";
            // 
            // textGramatica
            // 
            this.textGramatica.Location = new System.Drawing.Point(101, 40);
            this.textGramatica.Multiline = true;
            this.textGramatica.Name = "textGramatica";
            this.textGramatica.Size = new System.Drawing.Size(581, 131);
            this.textGramatica.TabIndex = 4;
            // 
            // btnConcat_AFND
            // 
            this.btnConcat_AFND.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 6F, System.Drawing.FontStyle.Bold);
            this.btnConcat_AFND.Location = new System.Drawing.Point(11, 171);
            this.btnConcat_AFND.Name = "btnConcat_AFND";
            this.btnConcat_AFND.Size = new System.Drawing.Size(67, 27);
            this.btnConcat_AFND.TabIndex = 25;
            this.btnConcat_AFND.Text = "Crear Tabla";
            this.btnConcat_AFND.UseVisualStyleBackColor = true;
            this.btnConcat_AFND.Click += new System.EventHandler(this.btnConcat_AFND_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 6F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(411, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Agregar Tokens";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 6F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(414, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 27);
            this.button2.TabIndex = 27;
            this.button2.Text = "Seleccionar AFD léxico";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 6F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(697, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 21);
            this.button3.TabIndex = 28;
            this.button3.Text = "Probar Léxico";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(411, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sigma";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cadenaSigma
            // 
            this.cadenaSigma.Location = new System.Drawing.Point(414, 234);
            this.cadenaSigma.Multiline = true;
            this.cadenaSigma.Name = "cadenaSigma";
            this.cadenaSigma.Size = new System.Drawing.Size(125, 18);
            this.cadenaSigma.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 6F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(411, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 38);
            this.button4.TabIndex = 30;
            this.button4.Text = "Analizar Sintacticamente Sigma";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tabla LL(1)";
            // 
            // dataTablaLL1
            // 
            this.dataTablaLL1.AllowUserToAddRows = false;
            this.dataTablaLL1.AllowUserToDeleteRows = false;
            this.dataTablaLL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTablaLL1.Location = new System.Drawing.Point(4, 367);
            this.dataTablaLL1.Name = "dataTablaLL1";
            this.dataTablaLL1.ReadOnly = true;
            this.dataTablaLL1.Size = new System.Drawing.Size(314, 344);
            this.dataTablaLL1.TabIndex = 35;
            // 
            // listaNoTerminal
            // 
            this.listaNoTerminal.AllowUserToAddRows = false;
            this.listaNoTerminal.AllowUserToDeleteRows = false;
            this.listaNoTerminal.AllowUserToResizeColumns = false;
            this.listaNoTerminal.AllowUserToResizeRows = false;
            this.listaNoTerminal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaNoTerminal.BackgroundColor = System.Drawing.Color.White;
            this.listaNoTerminal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaNoTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaNoTerminal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lista_AFNDS});
            this.listaNoTerminal.Location = new System.Drawing.Point(11, 204);
            this.listaNoTerminal.Name = "listaNoTerminal";
            this.listaNoTerminal.Size = new System.Drawing.Size(131, 145);
            this.listaNoTerminal.TabIndex = 37;
            // 
            // Lista_AFNDS
            // 
            this.Lista_AFNDS.HeaderText = "No terminales";
            this.Lista_AFNDS.Name = "Lista_AFNDS";
            // 
            // listaTerminales
            // 
            this.listaTerminales.AllowUserToAddRows = false;
            this.listaTerminales.AllowUserToDeleteRows = false;
            this.listaTerminales.AllowUserToResizeColumns = false;
            this.listaTerminales.AllowUserToResizeRows = false;
            this.listaTerminales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaTerminales.BackgroundColor = System.Drawing.Color.White;
            this.listaTerminales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listaTerminales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaTerminales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Tokens});
            this.listaTerminales.Location = new System.Drawing.Point(148, 204);
            this.listaTerminales.Name = "listaTerminales";
            this.listaTerminales.Size = new System.Drawing.Size(257, 145);
            this.listaTerminales.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Terminales";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Tokens
            // 
            this.Tokens.HeaderText = "Tokens";
            this.Tokens.Name = "Tokens";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 5F, System.Drawing.FontStyle.Bold);
            this.btnSelect.Location = new System.Drawing.Point(11, 83);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(84, 39);
            this.btnSelect.TabIndex = 41;
            this.btnSelect.Text = "SELECCIONAR ARCHIVO";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSUBIR_ARCHIVO
            // 
            this.btnSUBIR_ARCHIVO.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 5F, System.Drawing.FontStyle.Bold);
            this.btnSUBIR_ARCHIVO.Location = new System.Drawing.Point(12, 128);
            this.btnSUBIR_ARCHIVO.Name = "btnSUBIR_ARCHIVO";
            this.btnSUBIR_ARCHIVO.Size = new System.Drawing.Size(79, 26);
            this.btnSUBIR_ARCHIVO.TabIndex = 40;
            this.btnSUBIR_ARCHIVO.Text = "SUBIR";
            this.btnSUBIR_ARCHIVO.UseVisualStyleBackColor = true;
            this.btnSUBIR_ARCHIVO.Click += new System.EventHandler(this.btnSUBIR_ARCHIVO_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Cargar AFD";
            // 
            // listaAFD
            // 
            this.listaAFD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaAFD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaAFD.FormattingEnabled = true;
            this.listaAFD.Location = new System.Drawing.Point(97, 12);
            this.listaAFD.Name = "listaAFD";
            this.listaAFD.Size = new System.Drawing.Size(72, 21);
            this.listaAFD.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "AFD a utilizar";
            // 
            // infoAnalizador
            // 
            this.infoAnalizador.AllowUserToAddRows = false;
            this.infoAnalizador.AllowUserToDeleteRows = false;
            this.infoAnalizador.AllowUserToResizeColumns = false;
            this.infoAnalizador.AllowUserToResizeRows = false;
            this.infoAnalizador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infoAnalizador.BackgroundColor = System.Drawing.Color.White;
            this.infoAnalizador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoAnalizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoAnalizador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexemas});
            this.infoAnalizador.Location = new System.Drawing.Point(546, 177);
            this.infoAnalizador.Name = "infoAnalizador";
            this.infoAnalizador.Size = new System.Drawing.Size(251, 184);
            this.infoAnalizador.TabIndex = 44;
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
            // dataListaAFND
            // 
            this.dataListaAFND.AllowUserToAddRows = false;
            this.dataListaAFND.AllowUserToDeleteRows = false;
            this.dataListaAFND.AllowUserToResizeColumns = false;
            this.dataListaAFND.AllowUserToResizeRows = false;
            this.dataListaAFND.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListaAFND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListaAFND.BackgroundColor = System.Drawing.Color.White;
            this.dataListaAFND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataListaAFND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaAFND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataListaAFND.Location = new System.Drawing.Point(324, 367);
            this.dataListaAFND.Name = "dataListaAFND";
            this.dataListaAFND.Size = new System.Drawing.Size(464, 344);
            this.dataListaAFND.TabIndex = 45;
            this.dataListaAFND.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaAFND_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pila";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cadena";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Acciones";
            this.Column3.Name = "Column3";
            // 
            // FormDescensoRecursivoGramatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 723);
            this.Controls.Add(this.dataListaAFND);
            this.Controls.Add(this.infoAnalizador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listaAFD);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSUBIR_ARCHIVO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listaTerminales);
            this.Controls.Add(this.listaNoTerminal);
            this.Controls.Add(this.dataTablaLL1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cadenaSigma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConcat_AFND);
            this.Controls.Add(this.textGramatica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDescensoRecursivoGramatica";
            this.Text = "Descenso Recursivo para Gramaticas";
            this.Load += new System.EventHandler(this.FormDescensoRecursivoGramatica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTablaLL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNoTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTerminales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAnalizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaAFND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGramatica;
        private System.Windows.Forms.Button btnConcat_AFND;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cadenaSigma;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataTablaLL1;
        private System.Windows.Forms.DataGridView listaNoTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista_AFNDS;
        private System.Windows.Forms.DataGridView listaTerminales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tokens;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSUBIR_ARCHIVO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listaAFD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView infoAnalizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexemas;
        private System.Windows.Forms.DataGridView dataListaAFND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}