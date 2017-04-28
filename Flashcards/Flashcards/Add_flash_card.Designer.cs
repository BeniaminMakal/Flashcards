namespace Flashcards
{
    partial class Add_flash_card
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
            this.Add = new System.Windows.Forms.Button();
            this.Foreign_word = new System.Windows.Forms.RichTextBox();
            this.Translated_word = new System.Windows.Forms.RichTextBox();
            this.F_word = new System.Windows.Forms.Label();
            this.T_word = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(248, 299);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Foreign_word
            // 
            this.Foreign_word.Location = new System.Drawing.Point(25, 37);
            this.Foreign_word.Name = "Foreign_word";
            this.Foreign_word.Size = new System.Drawing.Size(303, 81);
            this.Foreign_word.TabIndex = 3;
            this.Foreign_word.Text = "";
            this.Foreign_word.TextChanged += new System.EventHandler(this.Foreign_word_TextChanged);
            // 
            // Translated_word
            // 
            this.Translated_word.Location = new System.Drawing.Point(22, 152);
            this.Translated_word.Name = "Translated_word";
            this.Translated_word.Size = new System.Drawing.Size(303, 81);
            this.Translated_word.TabIndex = 4;
            this.Translated_word.Text = "";
            this.Translated_word.TextChanged += new System.EventHandler(this.Translated_word_TextChanged);
            // 
            // F_word
            // 
            this.F_word.AutoSize = true;
            this.F_word.Location = new System.Drawing.Point(22, 21);
            this.F_word.Name = "F_word";
            this.F_word.Size = new System.Drawing.Size(68, 13);
            this.F_word.TabIndex = 5;
            this.F_word.Text = "Foreign word";
            // 
            // T_word
            // 
            this.T_word.AutoSize = true;
            this.T_word.Location = new System.Drawing.Point(22, 136);
            this.T_word.Name = "T_word";
            this.T_word.Size = new System.Drawing.Size(81, 13);
            this.T_word.TabIndex = 6;
            this.T_word.Text = "Transated word";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add picture";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(23, 298);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Collection1_EN_PL",
            "Collection2_EN_PL"});
            this.comboBox1.Location = new System.Drawing.Point(202, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Add_flash_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 334);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.T_word);
            this.Controls.Add(this.F_word);
            this.Controls.Add(this.Translated_word);
            this.Controls.Add(this.Foreign_word);
            this.Controls.Add(this.Add);
            this.Name = "Add_flash_card";
            this.Text = "Add_flash_card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.RichTextBox Foreign_word;
        private System.Windows.Forms.RichTextBox Translated_word;
        private System.Windows.Forms.Label F_word;
        private System.Windows.Forms.Label T_word;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}