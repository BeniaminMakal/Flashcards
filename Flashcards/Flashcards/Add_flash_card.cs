using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class Add_flash_card : Form
    {
        string Foreg_word;
        string Transaltion;
        string Collection;
        string Foreign_language;
        string Translation_languagel;
        int result = 0;
        public Add_flash_card()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Foreign_word_TextChanged(object sender, EventArgs e)
        {
            Foreg_word = Foreign_word.Text;
        }

        private void Translated_word_TextChanged(object sender, EventArgs e)
        {
            Transaltion = Translated_word.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Collection = Translation_language.Text;
        }

        private void Add_new_collection_Click(object sender, EventArgs e)
        {
            var newCollection = new AddCollection();
            newCollection.Visible = true;
            newCollection.TopMost = true;
            newCollection.Show();
        }

        private void Foreing_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arr = new string[10];
            var database = new Connect_to_database();
            var languages = database.FindLanguages();
            

        }

        private void Collection_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var database = new Connect_to_database();
                var languages = database.FindLanguages();
                var a = languages.GetEnumerator();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
