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
                DateTime Ac_data = DateTime.Now;
                Connect_to_database conn = new Connect_to_database();
                result = conn.insert_data(Collection, Foreg_word, Transaltion, Convert.ToString(Ac_data));
                if(result > 0)
                {
                    MessageBox.Show("Udało sie.");
                }
                else
                {
                    MessageBox.Show("Coś nie poszło.");
                }
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
            Collection = comboBox1.Text;
        }
    }
}
