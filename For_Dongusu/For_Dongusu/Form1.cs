using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Dongusu
{
    public partial class Form1 : Form
    {
        double ilksayi = 0;
        double sonsayi = 0;
        double artis = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label4.Text = "";
            ilksayi = Convert.ToDouble(textBox1.Text);
            sonsayi = Convert.ToDouble(textBox2.Text);
            artis = Convert.ToDouble(textBox3.Text);

            double i;
            if (ilksayi <= sonsayi)
            {
                for (i = ilksayi; i <= sonsayi; i = i + artis)
                {
                    listBox1.Items.Add(i);
                }
            }
            else
            {
                listBox1.Items.Clear();
                MessageBox.Show("İşlem Hatası..");
            }

            label4.Text = Convert.ToString(listBox1.Items.Count);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label4.Text = "";
        }
    }
}
