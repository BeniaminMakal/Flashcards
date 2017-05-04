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
            this.Translation_language = new System.Windows.Forms.ComboBox();
            this.Foreing_language = new System.Windows.Forms.ComboBox();
            this.Foreign_lan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Collection_name = new System.Windows.Forms.ComboBox();
            this.Add_new_collection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(253, 361);
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
            this.button2.Location = new System.Drawing.Point(141, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add picture";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(28, 360);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Translation_language
            // 
            this.Translation_language.FormattingEnabled = true;
            this.Translation_language.Items.AddRange(new object[] {
            "Collection1_EN_PL",
            "Collection2_EN_PL"});
            this.Translation_language.Location = new System.Drawing.Point(21, 324);
            this.Translation_language.Name = "Translation_language";
            this.Translation_language.Size = new System.Drawing.Size(121, 21);
            this.Translation_language.TabIndex = 9;
            this.Translation_language.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Foreing_language
            // 
            this.Foreing_language.FormattingEnabled = true;
            this.Foreing_language.Location = new System.Drawing.Point(21, 272);
            this.Foreing_language.Name = "Foreing_language";
            this.Foreing_language.Size = new System.Drawing.Size(121, 21);
            this.Foreing_language.TabIndex = 10;
            this.Foreing_language.SelectedIndexChanged += new System.EventHandler(this.Foreing_language_SelectedIndexChanged);
            // 
            // Foreign_lan
            // 
            this.Foreign_lan.AutoSize = true;
            this.Foreign_lan.Location = new System.Drawing.Point(18, 253);
            this.Foreign_lan.Name = "Foreign_lan";
            this.Foreign_lan.Size = new System.Drawing.Size(89, 13);
            this.Foreign_lan.TabIndex = 11;
            this.Foreign_lan.Text = "Foreign language";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Translation language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Collection";
            // 
            // Collection_name
            // 
            this.Collection_name.FormattingEnabled = true;
            this.Collection_name.Location = new System.Drawing.Point(195, 272);
            this.Collection_name.Name = "Collection_name";
            this.Collection_name.Size = new System.Drawing.Size(121, 21);
            this.Collection_name.TabIndex = 14;
            this.Collection_name.SelectedIndexChanged += new System.EventHandler(this.Collection_name_SelectedIndexChanged);
            // 
            // Add_new_collection
            // 
            this.Add_new_collection.Location = new System.Drawing.Point(195, 322);
            this.Add_new_collection.Name = "Add_new_collection";
            this.Add_new_collection.Size = new System.Drawing.Size(121, 23);
            this.Add_new_collection.TabIndex = 15;
            this.Add_new_collection.Text = "Add new collection";
            this.Add_new_collection.UseVisualStyleBackColor = true;
            this.Add_new_collection.Click += new System.EventHandler(this.Add_new_collection_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_flash_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_new_collection);
            this.Controls.Add(this.Collection_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Foreign_lan);
            this.Controls.Add(this.Foreing_language);
            this.Controls.Add(this.Translation_language);
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
        private System.Windows.Forms.ComboBox Translation_language;
        private System.Windows.Forms.ComboBox Foreing_language;
        private System.Windows.Forms.Label Foreign_lan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Collection_name;
        private System.Windows.Forms.Button Add_new_collection;
        private System.Windows.Forms.Button button1;
    }
}