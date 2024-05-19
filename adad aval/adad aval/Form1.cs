using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace adad_aval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, i, j;
            bool f;
            n = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();
            if (n < 1)
            {
                MessageBox.Show("عدد نامعتبر است");
            }
            else
                listBox1.Items.Add(1);
            for (i = 2; i <= n; i++)
            {
                f = true;
                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        f = false;
                        break;
                    }
                }
                if (f == true)
                {
                    listBox1.Items.Add(i);
                    textBox2.Text = Convert.ToString(listBox1.Items.Count);
                }
                textBox1.Focus();

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
