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
    public partial class AddCollection : Form
    {
        string collectionName { get; set; }
        string foreignLanguage { get; set; }
        string translationLanguage { get; set; }
        int result { get; set; }
    
        public AddCollection()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CollectionName_TextChanged(object sender, EventArgs e)
        {
            collectionName = Collection_name.Text;
        }

        private void Foreign_language_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Translation_language_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                


                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
