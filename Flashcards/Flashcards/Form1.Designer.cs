namespace Flashcards
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
            this.Connection_test = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Show_all_words = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.learnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Learn_from_dictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.Learn_from_flash_cards = new System.Windows.Forms.ToolStripMenuItem();
            this.Test_dictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.Test_flash_cards = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_flash_card1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_collection = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_from_file = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connection_test
            // 
            this.Connection_test.Location = new System.Drawing.Point(13, 191);
            this.Connection_test.Name = "Connection_test";
            this.Connection_test.Size = new System.Drawing.Size(110, 23);
            this.Connection_test.TabIndex = 0;
            this.Connection_test.Text = "Connection test";
            this.Connection_test.UseVisualStyleBackColor = true;
            this.Connection_test.Click += new System.EventHandler(this.Connection_test_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(259, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Show_all_words
            // 
            this.Show_all_words.Location = new System.Drawing.Point(146, 191);
            this.Show_all_words.Name = "Show_all_words";
            this.Show_all_words.Size = new System.Drawing.Size(111, 23);
            this.Show_all_words.TabIndex = 2;
            this.Show_all_words.Text = "Show all words";
            this.Show_all_words.UseVisualStyleBackColor = true;
            this.Show_all_words.Click += new System.EventHandler(this.Show_all_words_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.learnToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(289, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // learnToolStripMenuItem
            // 
            this.learnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Learn_from_dictionary,
            this.Learn_from_flash_cards});
            this.learnToolStripMenuItem.Name = "learnToolStripMenuItem";
            this.learnToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.learnToolStripMenuItem.Text = "Learn";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Test_dictionary,
            this.Test_flash_cards});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // Learn_from_dictionary
            // 
            this.Learn_from_dictionary.Name = "Learn_from_dictionary";
            this.Learn_from_dictionary.Size = new System.Drawing.Size(161, 22);
            this.Learn_from_dictionary.Text = "From dictionary";
            // 
            // Learn_from_flash_cards
            // 
            this.Learn_from_flash_cards.Name = "Learn_from_flash_cards";
            this.Learn_from_flash_cards.Size = new System.Drawing.Size(161, 22);
            this.Learn_from_flash_cards.Text = "From flash cards";
            // 
            // Test_dictionary
            // 
            this.Test_dictionary.Name = "Test_dictionary";
            this.Test_dictionary.Size = new System.Drawing.Size(152, 22);
            this.Test_dictionary.Text = "Dictionary";
            // 
            // Test_flash_cards
            // 
            this.Test_flash_cards.Name = "Test_flash_cards";
            this.Test_flash_cards.Size = new System.Drawing.Size(152, 22);
            this.Test_flash_cards.Text = "Flash cards";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_flash_card1,
            this.Add_collection,
            this.Add_from_file});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // Add_flash_card1
            // 
            this.Add_flash_card1.Name = "Add_flash_card1";
            this.Add_flash_card1.Size = new System.Drawing.Size(152, 22);
            this.Add_flash_card1.Text = "Add flash card";
            this.Add_flash_card1.Click += new System.EventHandler(this.Add_flash_card_Click);
            // 
            // Add_collection
            // 
            this.Add_collection.Name = "Add_collection";
            this.Add_collection.Size = new System.Drawing.Size(152, 22);
            this.Add_collection.Text = "Add collection";
            // 
            // Add_from_file
            // 
            this.Add_from_file.Name = "Add_from_file";
            this.Add_from_file.Size = new System.Drawing.Size(152, 22);
            this.Add_from_file.Text = "Add from file";
            this.Add_from_file.Click += new System.EventHandler(this.Add_from_file_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 259);
            this.Controls.Add(this.Show_all_words);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Connection_test);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connection_test;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Show_all_words;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem learnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Learn_from_dictionary;
        private System.Windows.Forms.ToolStripMenuItem Learn_from_flash_cards;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Test_dictionary;
        private System.Windows.Forms.ToolStripMenuItem Test_flash_cards;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_flash_card1;
        private System.Windows.Forms.ToolStripMenuItem Add_collection;
        private System.Windows.Forms.ToolStripMenuItem Add_from_file;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

