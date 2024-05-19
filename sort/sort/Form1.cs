using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sort
{
    public partial class Form1 : Form
    {
        int[] x = new int[7];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (i <= 6)
            {
                x[i] = Convert.ToInt32(textBox1.Text);
                listBox1.Items.Add(x[i]);
                i++;
            }
           else
                MessageBox.Show("آرایه پر است");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t;
            int i, j;
            for (i = 6; i >= 1; i--)
            {
                for (j = 0; j < i ; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        t = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = t;
                    }
                }
            }

            for (i = 0; i <= 6; i++)
                listBox2.Items.Add(Convert.ToString(x[i]));


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(listBox1.Items.Count));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(listBox1.SelectedIndex));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(listBox1.Items[listBox1.SelectedIndex]));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(listBox1.Items[listBox1.SelectedIndex]);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}