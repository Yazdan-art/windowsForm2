using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace teyfe_rang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label5.Text = Convert.ToString(hScrollBar1.Value);

            label1.BackColor = Color.FromArgb((byte)hScrollBar1.Value, (byte)hScrollBar2.Value, (byte)hScrollBar3.Value);
            //label1.BackColor = Color.FromArgb(Convert.ToInt16(label5.Text), Convert.ToInt16(label6.Text), Convert.ToInt16(label7.Text));// in this type cast  we will have type error
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label6.Text = Convert.ToString(hScrollBar2.Value);
            label1.BackColor = Color.FromArgb((byte)hScrollBar1.Value, (byte)hScrollBar2.Value, (byte)hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label7.Text = Convert.ToString(hScrollBar3.Value);
            label1.BackColor = Color.FromArgb((byte)hScrollBar1.Value, (byte)hScrollBar2.Value, (byte)hScrollBar3.Value);
        }
    }
}
