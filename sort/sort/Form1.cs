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
        public Form1()
        {
            InitializeComponent();
        }

        int[] x = new int[7];
        int i = 0;
        private void add_btn_Click(object sender, EventArgs e)
        {
            
            if (i <= 6)
            {
                x[i] = Convert.ToInt32(textBox1.Text);
                listBox1.Items.Add(x[i]);
                i++;
            }
           else
                MessageBox.Show("the arry is full");

        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            int temp, i, j;
            for (i = 3; i >= 1; i--)
            {
                for (j = 0; j < i ; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        temp = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = temp;
                    }
                }
            }

            for (i = 0; i <= 6; i++)
                listBox2.Items.Add(Convert.ToString(x[i]));


        }

        private void elements_show_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(listBox1.Items.Count));

        }

        private void index_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(listBox1.SelectedIndex));
        }

        private void selected_item_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(listBox1.Items[listBox1.SelectedIndex]));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(listBox1.Items[listBox1.SelectedIndex]);
        }
    }
}