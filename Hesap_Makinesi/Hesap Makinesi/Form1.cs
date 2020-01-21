using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        byte sira;
        byte islem;
        double sayi1;
        double sayi2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte sira = 1;
            byte islem = 0;
            double sayi1 = 0;
            double sayi2 = 0;
            buttonesittir.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
        }

        private void buttonbol_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                label1.Text = "";
                sira = 2;
                islem = 4;
                buttontopla.Enabled = false;
                buttoncikar.Enabled = false;
                buttoncarp.Enabled = false;
                buttonbol.Enabled = false;
                buttonesittir.Enabled = true;
                buttonvirgul.Enabled = true;
            }
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
        }

        private void buttoncarp_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                label1.Text = "";
                sira = 2;
                islem = 3;
                buttontopla.Enabled = false;
                buttoncikar.Enabled = false;
                buttoncarp.Enabled = false;
                buttonbol.Enabled = false;
                buttonesittir.Enabled = true;
                buttonvirgul.Enabled = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            byte sira = 1;
            byte islem = 0;
            double sayi1 = 0;
            double sayi2 = 0;
            buttonesittir.Enabled = false;
            buttontopla.Enabled = true;
            buttoncikar.Enabled = true;
            buttoncarp.Enabled = true;
            buttonbol.Enabled = true;
            buttonvirgul.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttontopla_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                label1.Text = "";
                sira = 2;
                islem = 1;
                buttontopla.Enabled = false;
                buttoncikar.Enabled = false;
                buttoncarp.Enabled = false;
                buttonbol.Enabled = false;
                buttonesittir.Enabled = true;
                buttonvirgul.Enabled = true;
            }
            
        }

        private void buttonesittir_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                sayi2 = Convert.ToDouble(label1.Text);
                if (islem == 1)
                {
                    label1.Text = Convert.ToString(sayi1 + sayi2);
                    buttonesittir.Enabled = false;
                }
                else if (islem == 2)
                {
                    label1.Text = Convert.ToString(sayi1 - sayi2);
                    buttonesittir.Enabled = false;
                }
                else if (islem == 3)
                {
                    label1.Text = Convert.ToString(sayi1 * sayi2);
                    buttonesittir.Enabled = false;
                }
                else if (islem == 4)
                {
                    label1.Text = Convert.ToString(sayi1 / sayi2);
                    buttonesittir.Enabled = false;
                }
                else
                {
                    label1.Text = "";
                    buttonesittir.Enabled = false;
                }
                sira = 1;
                islem = 0;
                buttontopla.Enabled = true;
                buttoncikar.Enabled = true;
                buttoncarp.Enabled = true;
                buttonbol.Enabled = true;
                buttonesittir.Enabled = false;
                buttonvirgul.Enabled = true;
            }

                

        }

        private void buttoncikar_Click(object sender, EventArgs e)
        {
            if(label1.Text != "")
            {
                sayi1 = Convert.ToDouble(label1.Text);
                label1.Text = "";
                sira = 2;
                islem = 2;
                buttontopla.Enabled = false;
                buttoncikar.Enabled = false;
                buttoncarp.Enabled = false;
                buttonbol.Enabled = false;
                buttonesittir.Enabled = true;
                buttonvirgul.Enabled = true;
            }
            
        }

        private void buttonvirgul_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                label1.Text = "0,";
            }
            else
            {
                label1.Text = label1.Text + ",";
                buttonvirgul.Enabled = false;
                buttontopla.Enabled = false;
                buttoncikar.Enabled = false;
                buttoncarp.Enabled = false;
                buttonbol.Enabled = false;

            }      
        }
    }
}
