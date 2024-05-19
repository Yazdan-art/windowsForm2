using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baner
{
    public partial class Form1 : Form
    {
        //int red = 1;
        int step = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int x, y;
            x = label1.Location.X + step;
            y = label1.Location.Y;
            if (step<0 &&  x < -310)
                x = this.Size.Width;
            if (step > 0 && x > this.Size.Width)
                x = -310;
            label1.Location = new System.Drawing.Point(x, y);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                step = -10;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                step = +10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       /* private void timer2_Tick(object sender, EventArgs e)
        {
            
            red = (red + 10) % 255;
            label1.ForeColor = Color.FromArgb(red, 0, 0);
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
