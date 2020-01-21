using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animasyon
{
    public partial class Form1 : Form
    {

        int sira;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sira == 1)
            {
                pictureBox1.Left = pictureBox1.Left + 15;
                pictureBox1.Image = Properties.Resources._1111;
                sira += 1;
            }
            else if (sira == 2)
            {
                pictureBox1.Left = pictureBox1.Left + 15;
                pictureBox1.Image = Properties.Resources._2222;
                sira += 1;
            }
            else if (sira == 3)
            {
                pictureBox1.Left = pictureBox1.Left + 15;
                pictureBox1.Image = Properties.Resources._3333;
                sira += 1;
            }
            else if (sira == 4)
            {
                pictureBox1.Left = pictureBox1.Left + 15;
                pictureBox1.Image = Properties.Resources._4444;
                sira += 1;
            }
            else if (sira == 5)
            {
                pictureBox1.Left = pictureBox1.Left + 15;
                pictureBox1.Image = Properties.Resources._5555;
                sira = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Animasyon";
            this.BackColor = Color.Black;
            pictureBox1.Location = new Point(0,0);
            sira = 1;
            timer1.Interval = 100;
            timer2.Interval = 100;
            timer1.Enabled = true;
            timer2.Enabled = true;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left>=863)
            {
                pictureBox1.Left = -200;
            }
        }
    }
}
