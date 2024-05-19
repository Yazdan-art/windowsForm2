using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculater
{
    public partial class Form1 : Form
    {
        double x;
        double temp;
        int d;
        int f = 0;
        int n;
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (led.Text == "0")
                led.Text = "1";
            else
            led.Text = led.Text + 1;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (led.Text == "0")
                led.Text = "0";
            else
            led.Text = led.Text + 0;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (led.Text == "0")
                led.Text = "2";
            else
                led.Text = led.Text + 2;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (led.Text == "0")
                led.Text = "3";
            else
                led.Text = led.Text + 3;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (led.Text == "0")
                led.Text = "4";
            else
                led.Text = led.Text + 4;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (led.Text == "0")
                led.Text = "5";
            else
                led.Text = led.Text + 5;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (led.Text == "0")
                led.Text = "6";
            else
                led.Text = led.Text + 6;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (led.Text == "0")
                led.Text = "7";
            else
                led.Text = led.Text + 7;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (led.Text == "0")
                led.Text = "8";
            else
                led.Text = led.Text + 8;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (led.Text == "0")
                led.Text = "9";
            else
                led.Text = led.Text + 9;
        }

        private void bdod_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
      
                led.Text = led.Text + ".";
                f = 1;
            }
        }

        private void bc_Click(object sender, EventArgs e)
        {
            led.Text = "0";
        }

        private void bce_Click(object sender, EventArgs e)
        {
            
            s = led.Text;
            n = s.Length;
            if (n > 0)
            {
                if (s.Substring(n - 1, 1) == ".")
                    f = 0;
                s = s.Substring(0, n - 1);
            }
            led.Text = s;
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bp_Click(object sender, EventArgs e)
        {
            d = 1;
            temp = Convert.ToDouble(led.Text);
            f = 0;
            led.Text = "";
        }

        private void bm_Click(object sender, EventArgs e)
        {
            d = 2;
            temp = Convert.ToDouble(led.Text);
            f = 0;
            led.Text = "";
        }

        private void bmu_Click(object sender, EventArgs e)
        {
            d = 3;
            temp = Convert.ToDouble(led.Text);
            f = 0;
            led.Text = "";
        }

        private void bd_Click(object sender, EventArgs e)
        {
            d = 4;
            temp = Convert.ToDouble(led.Text);
            f = 0;
            led.Text = "";
        }

        private void be_Click(object sender, EventArgs e)
        {
            switch (d)
            {
                case 1:
                    x = Convert.ToDouble(led.Text) + temp;
                    led.Text = Convert.ToString(x);
                    break;
                case 2:
                     x = Convert.ToDouble(led.Text) - temp;
                    led.Text = Convert.ToString(x);
                    break;
                case 3:
                    led.Text = Convert.ToString(Convert.ToDouble(led.Text) * temp);
                    break;
                case 4:
                    led.Text = Convert.ToString(Convert.ToDouble(led.Text) / temp);
                    break;
            }
        }

        private void bsin_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(led.Text);
            x = Math.Sin(x);
            led.Text = Convert.ToString(x);
        }

        private void btas_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int k;
            k = x.Next(6) + 1;
            led.Text = Convert.ToString(k);

        }

        private void bla_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int k;
            k = x.Next(6) + 15;
            led.Text = Convert.ToString(k);
        }

        private void bdo_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            double k;
            k = x.NextDouble();
            led.Text = Convert.ToString(k);

        }

        private void bred_CheckedChanged(object sender, EventArgs e)
        {
            if (bred.Checked == true)
                this.BackColor = Color.Red;
        }

        private void bgreen_CheckedChanged(object sender, EventArgs e)
        {

            if (bgreen.Checked == true)
                this.BackColor = Color.Green;
        }

        private void bblue_CheckedChanged(object sender, EventArgs e)
        {

            if (bblue.Checked == true)
                this.BackColor = Color.Blue;
        }

        private void bcom1_CheckedChanged(object sender, EventArgs e)
        {
            if (bcom1.Checked == true)
                this.Width = 306;
                 bsin.Visible = false;
                 btas.Visible = false;
                 bla.Visible = false;
                 bdo.Visible = false;

        }

        private void bcom2_CheckedChanged(object sender, EventArgs e)
        {
            if (bcom1.Checked == true)
                this.Width = 340;
            bsin.Visible = true;
            btas.Visible = true;
            bla.Visible = true;
            bdo.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
