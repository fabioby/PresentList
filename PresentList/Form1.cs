using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int id = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_present.Items.Add(string.Format("{0,-40}\t{1,-40}\t{2,-40}", "id", "Név", "Üzlet"));
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(textBox_name.Text.Length == 0 || textBox_shop.Text.Length == 0)
            {
                MessageBox.Show("Tölts ki minden mezőt!");
            } else
            {
                listBox_present.Items.Add(string.Format("{0,-40}\t{1,-40}\t{2,-40}", id, textBox_name.Text, textBox_shop.Text));
                id++;
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox_present.SelectedIndex == -1 || listBox_present.SelectedIndex == 0)
            {
                MessageBox.Show("Válassz ki egy mezőt!");
            } else
            {
                listBox_present.Items.Remove(listBox_present.SelectedItem);
            }
        }
    }
}
