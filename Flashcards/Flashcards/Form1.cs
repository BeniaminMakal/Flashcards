using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class Form1 : Form
    {
        FbConnection conn1;
        string line;
        public Form1()
        {
            InitializeComponent();
            string database = @"C:\Users\benia\OneDrive\Dokumenty\Repositories\Flashcards\Flashcards\FLASH_CARDS.FDB";
            string connectionstring;
            FbConnectionStringBuilder ConString = new FbConnectionStringBuilder();
            ConString.Database = database;
            ConString.ServerType = FbServerType.Embedded;
            ConString.UserID = "sysdba";
            connectionstring = ConString.ToString();
            
            conn1 = new FbConnection(connectionstring);
            try
            {
                //open connection

                conn1.Open();
                MessageBox.Show("Connect success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Connection_test_Click(object sender, EventArgs e)
        {
            
            string database = @"C:\Users\benia\OneDrive\Dokumenty\Repositories\Flashcards\Flashcards\FLASH_CARDS.FDB";
            string connectionstring;
            FbConnectionStringBuilder ConString = new FbConnectionStringBuilder();
            ConString.Database = database;
            ConString.ServerType = FbServerType.Embedded;
            ConString.UserID = "sysdba";
            connectionstring = ConString.ToString();
            MessageBox.Show(connectionstring);
            var conn1 = new FbConnection(connectionstring);
            try
            {
                //open connection
                
                conn1.Open();
                MessageBox.Show("Connect success!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
        }

        private void Show_all_words_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (dt != null)
                dt.Clear();
            try
            {
                var get_data = new Connect_to_database();
                dataGridView1.DataSource = get_data.get_data("SELECT FOREIGN_word, PL_word FROM Collection1_EN_PL;");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newFlashCardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Add_flash_card_Click(object sender, EventArgs e)
        {
            Add_flash_card add = new Add_flash_card();
            add.Visible = true;
            add.TopMost = true;
            add.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn1.Close();
            this.Close();
        }

        private void Add_from_file_Click(object sender, EventArgs e)
        {
             
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = @"E:\SQL\Test\slowka";
            int a = 0;
            string[] items = new string[1000000];
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Success.żżńńł");
                try
                {
                    using (StreamReader myStreamreader = new StreamReader(openFileDialog1.FileName, Encoding.UTF8))
                    {
                        while ((line = myStreamreader.ReadLine()) != null)
                        {
                            
                            items = line.Split('\n');
                            string foreign_transate = items[a];
                            a++;
                            foreach (string i in items)
                                MessageBox.Show(i);
                        }
                        line = myStreamreader.ReadToEnd();
                        MessageBox.Show(line);
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           else
            {
                
            }

        }
    }
}
