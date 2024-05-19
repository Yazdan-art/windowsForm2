using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace arz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            listBox3.SelectedIndex = listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            listBox3.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox3.SelectedIndex;
            listBox2.SelectedIndex = listBox3.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("اطلاعات ناقص است");
            else
            {
                listBox1.Items.Add(textBox2.Text);
                listBox2.Items.Add(textBox3.Text);
                listBox3.Items.Add(textBox4.Text);
            }
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(listBox1.Items[listBox1.SelectedIndex]);
            textBox3.Text = Convert.ToString(listBox2.Items[listBox2.SelectedIndex]);
            textBox4.Text = Convert.ToString(listBox3.Items[listBox3.SelectedIndex]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            listBox1.Items.Insert(i, textBox2.Text);
            listBox2.Items.RemoveAt(i);
            listBox2.Items.Insert(i, textBox3.Text);
            listBox3.Items.RemoveAt(i);
            listBox3.Items.Insert(i, textBox4.Text);
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            listBox2.Items.RemoveAt(i);
            listBox3.Items.RemoveAt(i);
        }
    }
}
