namespace DataEncryptionTest
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxBytes = new System.Windows.Forms.ComboBox();
            this.labelBytes = new System.Windows.Forms.Label();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxBytes
            // 
            this.comboBoxBytes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBytes.FormattingEnabled = true;
            this.comboBoxBytes.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "12",
            "16"});
            this.comboBoxBytes.Location = new System.Drawing.Point(68, 24);
            this.comboBoxBytes.Name = "comboBoxBytes";
            this.comboBoxBytes.Size = new System.Drawing.Size(42, 21);
            this.comboBoxBytes.TabIndex = 97;
            // 
            // labelBytes
            // 
            this.labelBytes.AutoSize = true;
            this.labelBytes.Location = new System.Drawing.Point(26, 27);
            this.labelBytes.Name = "labelBytes";
            this.labelBytes.Size = new System.Drawing.Size(36, 13);
            this.labelBytes.TabIndex = 96;
            this.labelBytes.Text = "Bytes:";
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "12",
            "16"});
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(68, 64);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(42, 21);
            this.comboBoxAlgorithm.TabIndex = 99;
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Location = new System.Drawing.Point(9, 67);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(53, 13);
            this.labelAlgorithm.TabIndex = 98;
            this.labelAlgorithm.Text = "Algorithm:";
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "12",
            "16"});
            this.comboBoxAction.Location = new System.Drawing.Point(68, 101);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(42, 21);
            this.comboBoxAction.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Action:";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.AllowDrop = true;
            this.textBoxSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSerial.Location = new System.Drawing.Point(227, 24);
            this.textBoxSerial.MaxLength = 15;
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(98, 20);
            this.textBoxSerial.TabIndex = 102;
            this.textBoxSerial.Text = "865473033253934";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Plaintext:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Cyphertext:";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(227, 64);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 104;
            this.textBox1.Text = "865473033253934";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 106;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 156);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSerial);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAlgorithm);
            this.Controls.Add(this.labelAlgorithm);
            this.Controls.Add(this.comboBoxBytes);
            this.Controls.Add(this.labelBytes);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBytes;
        private System.Windows.Forms.Label labelBytes;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

