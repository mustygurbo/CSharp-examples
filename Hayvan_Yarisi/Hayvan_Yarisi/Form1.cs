using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hayvan_Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        int rakip1konum, rakip2konum, rakip3konum;
        int finish;

        private void timer1_Tick(object sender, EventArgs e)
        {
            rakip1konum = pictureBox1.Left;
            rakip2konum = pictureBox2.Left;
            rakip3konum = pictureBox3.Left;

            if (rakip1konum >= finish)
            {
                timer1.Enabled = false;
                MessageBox.Show("Kuş Kazandı..");
                button3.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                rakip1konum = rakip1konum + rnd.Next(1, 10);
            }

            if (rakip2konum >= finish)
            {
                timer1.Enabled = false;
                MessageBox.Show("Kedi Kazandı..");
                button3.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                rakip2konum = rakip2konum + rnd.Next(1, 10);
            }

            if (rakip3konum >= finish)
            {
                timer1.Enabled = false;
                MessageBox.Show("Köpek Kazandı..");
                button3.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                rakip3konum = rakip3konum + rnd.Next(1, 10);
            }

            pictureBox1.Left = rakip1konum;
            pictureBox2.Left = rakip2konum;
            pictureBox3.Left = rakip3konum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            finish = pictureBox4.Left-120;
            button3.Enabled = false;
            button2.Enabled = false;
        }
    }
}
