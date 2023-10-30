using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmlistbox.Items.Add(filmTextBox.Text);
        }
        
       
        
            
      
        private void removesingleBtn_Click(object sender, EventArgs e)
        {
            filmlistbox.Items.Remove(filmlistbox.SelectedItem);
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(filmlistbox.Items.Count.ToString());
        }

        private void clearlistBtn_Click(object sender, EventArgs e)
        {
            filmlistbox.Items.Clear();
        }

        private void Addcopybooks_Click(object sender, EventArgs e)
        {
            filmlistbox.Items.Add(comboBox1.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
