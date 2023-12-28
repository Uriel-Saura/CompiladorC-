namespace Practica1.Forms
{
    partial class FormAnalizar_Sintaxis
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSUBIR_ARCHIVO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.CadenaAnalizar = new System.Windows.Forms.TextBox();
            this.listaAFD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxmatriz1 = new System.Windows.Forms.ComboBox();
            this.boxOperacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxmatriz2 = new System.Windows.Forms.ComboBox();
            this.dataMat1 = new System.Windows.Forms.DataGridView();
            this.dataMat2 = new System.Windows.Forms.DataGridView();
            this.dataMatRes = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.operaSelect = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblOperacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatRes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Probar Analizador Sintáctico";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.btnSelect.Location = new System.Drawing.Point(12, 85);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(177, 30);
            this.btnSelect.TabIndex = 40;
            this.btnSelect.Text = "SELECCIONAR ARCHIVO";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSUBIR_ARCHIVO
            // 
            this.btnSUBIR_ARCHIVO.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.btnSUBIR_ARCHIVO.Location = new System.Drawing.Point(96, 57);
            this.btnSUBIR_ARCHIVO.Name = "btnSUBIR_ARCHIVO";
            this.btnSUBIR_ARCHIVO.Size = new System.Drawing.Size(68, 29);
            this.btnSUBIR_ARCHIVO.TabIndex = 39;
            this.btnSUBIR_ARCHIVO.Text = "SUBIR";
            this.btnSUBIR_ARCHIVO.UseVisualStyleBackColor = true;
            this.btnSUBIR_ARCHIVO.Click += new System.EventHandler(this.btnSUBIR_ARCHIVO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cargar AFD";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.btnAnalizar.Location = new System.Drawing.Point(697, 64);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(68, 51);
            this.btnAnalizar.TabIndex = 45;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // CadenaAnalizar
            // 
            this.CadenaAnalizar.Location = new System.Drawing.Point(509, 95);
            this.CadenaAnalizar.Name = "CadenaAnalizar";
            this.CadenaAnalizar.Size = new System.Drawing.Size(171, 20);
            this.CadenaAnalizar.TabIndex = 44;
            // 
            // listaAFD
            // 
            this.listaAFD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaAFD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaAFD.FormattingEnabled = true;
            this.listaAFD.Location = new System.Drawing.Point(509, 66);
            this.listaAFD.Name = "listaAFD";
            this.listaAFD.Size = new System.Drawing.Size(171, 21);
            this.listaAFD.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Cadena a Analizar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "AFD a utilizar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "Seleccione las matrices";
            // 
            // boxmatriz1
            // 
            this.boxmatriz1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxmatriz1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxmatriz1.FormattingEnabled = true;
            this.boxmatriz1.Location = new System.Drawing.Point(91, 203);
            this.boxmatriz1.Name = "boxmatriz1";
            this.boxmatriz1.Size = new System.Drawing.Size(84, 21);
            this.boxmatriz1.TabIndex = 48;
            // 
            // boxOperacion
            // 
            this.boxOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxOperacion.FormattingEnabled = true;
            this.boxOperacion.Location = new System.Drawing.Point(253, 203);
            this.boxOperacion.Name = "boxOperacion";
            this.boxOperacion.Size = new System.Drawing.Size(171, 21);
            this.boxOperacion.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Operaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Matriz 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(487, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "Matriz 2";
            // 
            // boxmatriz2
            // 
            this.boxmatriz2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxmatriz2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxmatriz2.FormattingEnabled = true;
            this.boxmatriz2.Location = new System.Drawing.Point(478, 203);
            this.boxmatriz2.Name = "boxmatriz2";
            this.boxmatriz2.Size = new System.Drawing.Size(84, 21);
            this.boxmatriz2.TabIndex = 52;
            // 
            // dataMat1
            // 
            this.dataMat1.AllowUserToAddRows = false;
            this.dataMat1.AllowUserToDeleteRows = false;
            this.dataMat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMat1.Location = new System.Drawing.Point(13, 257);
            this.dataMat1.Name = "dataMat1";
            this.dataMat1.ReadOnly = true;
            this.dataMat1.Size = new System.Drawing.Size(208, 181);
            this.dataMat1.TabIndex = 54;
            // 
            // dataMat2
            // 
            this.dataMat2.AllowUserToAddRows = false;
            this.dataMat2.AllowUserToDeleteRows = false;
            this.dataMat2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMat2.Location = new System.Drawing.Point(293, 257);
            this.dataMat2.Name = "dataMat2";
            this.dataMat2.ReadOnly = true;
            this.dataMat2.Size = new System.Drawing.Size(218, 181);
            this.dataMat2.TabIndex = 55;
            // 
            // dataMatRes
            // 
            this.dataMatRes.AllowUserToAddRows = false;
            this.dataMatRes.AllowUserToDeleteRows = false;
            this.dataMatRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatRes.Location = new System.Drawing.Point(570, 257);
            this.dataMatRes.Name = "dataMatRes";
            this.dataMatRes.ReadOnly = true;
            this.dataMatRes.Size = new System.Drawing.Size(218, 181);
            this.dataMatRes.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(517, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 28);
            this.label9.TabIndex = 57;
            this.label9.Text = "=";
            // 
            // operaSelect
            // 
            this.operaSelect.AutoSize = true;
            this.operaSelect.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operaSelect.Location = new System.Drawing.Point(241, 329);
            this.operaSelect.Name = "operaSelect";
            this.operaSelect.Size = new System.Drawing.Size(0, 28);
            this.operaSelect.TabIndex = 58;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Location = new System.Drawing.Point(595, 192);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(135, 41);
            this.btnCalcular.TabIndex = 59;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(237, 296);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(54, 13);
            this.lblOperacion.TabIndex = 61;
            this.lblOperacion.Text = "operacion";
            // 
            // FormAnalizar_Sintaxis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.operaSelect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataMatRes);
            this.Controls.Add(this.dataMat2);
            this.Controls.Add(this.dataMat1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxmatriz2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxOperacion);
            this.Controls.Add(this.boxmatriz1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.CadenaAnalizar);
            this.Controls.Add(this.listaAFD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSUBIR_ARCHIVO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAnalizar_Sintaxis";
            this.Text = "Analizador Sintáctico";
            this.Load += new System.EventHandler(this.FormAnalizar_Sintaxis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSUBIR_ARCHIVO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox CadenaAnalizar;
        private System.Windows.Forms.ComboBox listaAFD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxmatriz1;
        private System.Windows.Forms.ComboBox boxOperacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox boxmatriz2;
        private System.Windows.Forms.DataGridView dataMat1;
        private System.Windows.Forms.DataGridView dataMat2;
        private System.Windows.Forms.DataGridView dataMatRes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label operaSelect;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblOperacion;
    }
}