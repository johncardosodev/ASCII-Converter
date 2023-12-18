namespace NumberConverter
{
    partial class Form1
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
            label1 = new Label();
            rtbASCII = new RichTextBox();
            rdbControlChar = new RadioButton();
            rdbPrintChar = new RadioButton();
            rdbExtendedChar = new RadioButton();
            dgvASCII = new DataGridView();
            rtxHexadecimal = new RichTextBox();
            rtxBinario = new RichTextBox();
            rxtDecimal = new RichTextBox();
            txtDelimitador = new TextBox();
            lblASCIIDescicao = new Label();
            lblHexadecimal = new Label();
            lblBinario = new Label();
            lblDecimal = new Label();
            btnCopy1 = new Button();
            lblDelimitador = new Label();
            btnLimpar = new Button();
            btnCopy2 = new Button();
            btnCopy3 = new Button();
            lblContagemASCII = new Label();
            lblContagemHexadecimal = new Label();
            lblContagemBinario = new Label();
            lblContagemDecimal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvASCII).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(303, 41);
            label1.TabIndex = 0;
            label1.Text = "Conversor ASCII";
            // 
            // rtbASCII
            // 
            rtbASCII.Location = new Point(12, 124);
            rtbASCII.Name = "rtbASCII";
            rtbASCII.Size = new Size(393, 89);
            rtbASCII.TabIndex = 6;
            rtbASCII.Text = "";
            rtbASCII.TextChanged += rtbASCII_TextChanged;
            // 
            // rdbControlChar
            // 
            rdbControlChar.AutoSize = true;
            rdbControlChar.Location = new Point(447, 10);
            rdbControlChar.Name = "rdbControlChar";
            rdbControlChar.Size = new Size(266, 19);
            rdbControlChar.TabIndex = 7;
            rdbControlChar.Text = "ASCII control characters (character code 0-31)";
            rdbControlChar.UseVisualStyleBackColor = true;
            rdbControlChar.CheckedChanged += rdbControlChar_CheckedChanged;
            // 
            // rdbPrintChar
            // 
            rdbPrintChar.AutoSize = true;
            rdbPrintChar.Checked = true;
            rdbPrintChar.Location = new Point(719, 10);
            rdbPrintChar.Name = "rdbPrintChar";
            rdbPrintChar.Size = new Size(287, 19);
            rdbPrintChar.TabIndex = 8;
            rdbPrintChar.TabStop = true;
            rdbPrintChar.Text = "ASCII printable characters (character code 32-127)";
            rdbPrintChar.UseVisualStyleBackColor = true;
            rdbPrintChar.CheckedChanged += rdbPrintChar_CheckedChanged;
            // 
            // rdbExtendedChar
            // 
            rdbExtendedChar.AutoSize = true;
            rdbExtendedChar.Location = new Point(1012, 12);
            rdbExtendedChar.Name = "rdbExtendedChar";
            rdbExtendedChar.Size = new Size(294, 19);
            rdbExtendedChar.TabIndex = 9;
            rdbExtendedChar.Text = "The extended ASCII codes (character code 128-255)";
            rdbExtendedChar.UseVisualStyleBackColor = true;
            rdbExtendedChar.CheckedChanged += rdbExtendedChar_CheckedChanged;
            // 
            // dgvASCII
            // 
            dgvASCII.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvASCII.Location = new Point(447, 37);
            dgvASCII.Name = "dgvASCII";
            dgvASCII.Size = new Size(859, 620);
            dgvASCII.TabIndex = 11;
            dgvASCII.CellContentClick += dgvASCII_CellContentClick;
            // 
            // rtxHexadecimal
            // 
            rtxHexadecimal.Location = new Point(12, 279);
            rtxHexadecimal.Name = "rtxHexadecimal";
            rtxHexadecimal.ReadOnly = true;
            rtxHexadecimal.Size = new Size(393, 89);
            rtxHexadecimal.TabIndex = 12;
            rtxHexadecimal.Text = "Resultado em HexaDecimal...";
            // 
            // rtxBinario
            // 
            rtxBinario.Location = new Point(12, 410);
            rtxBinario.Name = "rtxBinario";
            rtxBinario.ReadOnly = true;
            rtxBinario.Size = new Size(393, 89);
            rtxBinario.TabIndex = 13;
            rtxBinario.Text = "Resultado em Binario...";
            // 
            // rxtDecimal
            // 
            rxtDecimal.Location = new Point(12, 539);
            rxtDecimal.Name = "rxtDecimal";
            rxtDecimal.ReadOnly = true;
            rxtDecimal.Size = new Size(393, 89);
            rxtDecimal.TabIndex = 14;
            rxtDecimal.Text = "Resultado em Decimal...\n";
            // 
            // txtDelimitador
            // 
            txtDelimitador.Font = new Font("Segoe UI", 8F);
            txtDelimitador.Location = new Point(356, 91);
            txtDelimitador.Name = "txtDelimitador";
            txtDelimitador.Size = new Size(49, 22);
            txtDelimitador.TabIndex = 15;
            txtDelimitador.Text = ",";
            txtDelimitador.TextAlign = HorizontalAlignment.Center;
            txtDelimitador.TextChanged += txtDelimitador_TextChanged;
            // 
            // lblASCIIDescicao
            // 
            lblASCIIDescicao.AutoSize = true;
            lblASCIIDescicao.Location = new Point(12, 106);
            lblASCIIDescicao.Name = "lblASCIIDescicao";
            lblASCIIDescicao.Size = new Size(66, 15);
            lblASCIIDescicao.TabIndex = 17;
            lblASCIIDescicao.Text = "Texto ASCII";
            // 
            // lblHexadecimal
            // 
            lblHexadecimal.AutoSize = true;
            lblHexadecimal.Location = new Point(12, 261);
            lblHexadecimal.Name = "lblHexadecimal";
            lblHexadecimal.Size = new Size(77, 15);
            lblHexadecimal.TabIndex = 18;
            lblHexadecimal.Text = "HexaDecimal";
            // 
            // lblBinario
            // 
            lblBinario.AutoSize = true;
            lblBinario.Location = new Point(12, 392);
            lblBinario.Name = "lblBinario";
            lblBinario.Size = new Size(44, 15);
            lblBinario.TabIndex = 19;
            lblBinario.Text = "Binario";
            // 
            // lblDecimal
            // 
            lblDecimal.AutoSize = true;
            lblDecimal.Location = new Point(12, 521);
            lblDecimal.Name = "lblDecimal";
            lblDecimal.Size = new Size(50, 15);
            lblDecimal.TabIndex = 20;
            lblDecimal.Text = "Decimal";
            // 
            // btnCopy1
            // 
            btnCopy1.Location = new Point(251, 374);
            btnCopy1.Name = "btnCopy1";
            btnCopy1.Size = new Size(154, 23);
            btnCopy1.TabIndex = 21;
            btnCopy1.Text = "Copiar para transferência";
            btnCopy1.UseVisualStyleBackColor = true;
            btnCopy1.Click += btnCopy1_Click_1;
            // 
            // lblDelimitador
            // 
            lblDelimitador.AutoSize = true;
            lblDelimitador.Location = new Point(281, 98);
            lblDelimitador.Name = "lblDelimitador";
            lblDelimitador.Size = new Size(69, 15);
            lblDelimitador.TabIndex = 22;
            lblDelimitador.Text = "Delimitador";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(306, 219);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(99, 23);
            btnLimpar.TabIndex = 23;
            btnLimpar.Text = "Limpar Texto";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCopy2
            // 
            btnCopy2.Location = new Point(251, 510);
            btnCopy2.Name = "btnCopy2";
            btnCopy2.Size = new Size(154, 23);
            btnCopy2.TabIndex = 24;
            btnCopy2.Text = "Copiar para transferência";
            btnCopy2.UseVisualStyleBackColor = true;
            btnCopy2.Click += btnCopy2_Click;
            // 
            // btnCopy3
            // 
            btnCopy3.Location = new Point(251, 634);
            btnCopy3.Name = "btnCopy3";
            btnCopy3.Size = new Size(154, 23);
            btnCopy3.TabIndex = 25;
            btnCopy3.Text = "Copiar para transferência";
            btnCopy3.UseVisualStyleBackColor = true;
            btnCopy3.Click += btnCopy3_Click;
            // 
            // lblContagemASCII
            // 
            lblContagemASCII.AutoSize = true;
            lblContagemASCII.Location = new Point(12, 216);
            lblContagemASCII.Name = "lblContagemASCII";
            lblContagemASCII.Size = new Size(60, 15);
            lblContagemASCII.TabIndex = 26;
            lblContagemASCII.Text = "(0 digitos)";
            lblContagemASCII.Click += lblContagemASCII_Click;
            // 
            // lblContagemHexadecimal
            // 
            lblContagemHexadecimal.AutoSize = true;
            lblContagemHexadecimal.Location = new Point(12, 371);
            lblContagemHexadecimal.Name = "lblContagemHexadecimal";
            lblContagemHexadecimal.Size = new Size(60, 15);
            lblContagemHexadecimal.TabIndex = 27;
            lblContagemHexadecimal.Text = "(0 digitos)";
            // 
            // lblContagemBinario
            // 
            lblContagemBinario.AutoSize = true;
            lblContagemBinario.Location = new Point(12, 502);
            lblContagemBinario.Name = "lblContagemBinario";
            lblContagemBinario.Size = new Size(60, 15);
            lblContagemBinario.TabIndex = 28;
            lblContagemBinario.Text = "(0 digitos)";
            // 
            // lblContagemDecimal
            // 
            lblContagemDecimal.AutoSize = true;
            lblContagemDecimal.Location = new Point(12, 631);
            lblContagemDecimal.Name = "lblContagemDecimal";
            lblContagemDecimal.Size = new Size(60, 15);
            lblContagemDecimal.TabIndex = 29;
            lblContagemDecimal.Text = "(0 digitos)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 716);
            Controls.Add(lblContagemDecimal);
            Controls.Add(lblContagemBinario);
            Controls.Add(lblContagemHexadecimal);
            Controls.Add(lblContagemASCII);
            Controls.Add(btnCopy3);
            Controls.Add(btnCopy2);
            Controls.Add(btnLimpar);
            Controls.Add(lblDelimitador);
            Controls.Add(btnCopy1);
            Controls.Add(lblDecimal);
            Controls.Add(lblBinario);
            Controls.Add(lblHexadecimal);
            Controls.Add(lblASCIIDescicao);
            Controls.Add(txtDelimitador);
            Controls.Add(rxtDecimal);
            Controls.Add(rtxBinario);
            Controls.Add(rtxHexadecimal);
            Controls.Add(dgvASCII);
            Controls.Add(rdbExtendedChar);
            Controls.Add(rdbPrintChar);
            Controls.Add(rdbControlChar);
            Controls.Add(rtbASCII);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor ASCII";
            ((System.ComponentModel.ISupportInitialize)dgvASCII).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbASCII;
        private RadioButton rdbControlChar;
        private RadioButton rdbPrintChar;
        private RadioButton rdbExtendedChar;
        private DataGridView dgvASCII;
        private RichTextBox rtxHexadecimal;
        private RichTextBox rtxBinario;
        private RichTextBox rxtDecimal;
        private TextBox txtDelimitador;
        private Label lblASCIIDescicao;
        private Label lblHexadecimal;
        private Label lblBinario;
        private Label lblDecimal;
        private Button btnCopy1;
        private Label lblDelimitador;
        private Button btnLimpar;
        private Button btnCopy2;
        private Button btnCopy3;
        private Label lblContagemASCII;
        private Label lblContagemHexadecimal;
        private Label lblContagemBinario;
        private Label lblContagemDecimal;
    }
}