using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Tasarimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = ("BAŞLIK 1");return;
            }
            else if (radioButton2.Checked == true)
            {
                label1.Text = ("BAŞLIK 2");return;
            }
            else
            {
                label1.Text = ("BAŞLIK 3");return;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = ("BAŞLIK 1"); return;
            }
            else if (radioButton2.Checked == true)
            {
                label1.Text = ("BAŞLIK 2"); return;
            }
            else
            {
                label1.Text = ("BAŞLIK 3"); return;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = ("BAŞLIK 1"); return;
            }
            else if (radioButton2.Checked == true)
            {
                label1.Text = ("BAŞLIK 2"); return;
            }
            else if (radioButton3.Checked == true)
            {
                label1.Text = ("BAŞLIK 3"); return;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label3.BackColor = Color.DarkSlateBlue;
                label2.BackColor=Color.DarkSlateBlue; return;
            }
            else if (radioButton5.Checked == true)
            {
                label3.BackColor = Color.IndianRed;
                label2.BackColor = Color.IndianRed; return;
            }
            else if (radioButton6.Checked==true)
            {
                label3.BackColor = Color.Orange;
                label2.BackColor = Color.Orange; return;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label3.BackColor = Color.DarkSlateBlue;
                label2.BackColor = Color.DarkSlateBlue; return;
            }
            else if (radioButton5.Checked == true)
            {
                label3.BackColor = Color.IndianRed;
                label2.BackColor = Color.IndianRed; return;
            }
            else if (radioButton6.Checked == true)
            {
                label3.BackColor = Color.Orange;
                label2.BackColor = Color.Orange; return;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label3.BackColor = Color.DarkSlateBlue;
                label2.BackColor = Color.DarkSlateBlue; return;
            }
            else if (radioButton5.Checked == true)
            {
                label3.BackColor = Color.IndianRed;
                label2.BackColor = Color.IndianRed; return;
            }
            else if (radioButton6.Checked == true)
            {
                label3.BackColor = Color.Orange;
                label2.BackColor = Color.Orange; return;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton7.Checked == true)
            {
                label3.ForeColor = Color.Black;return;
            }
            else if (radioButton8.Checked == true)
            {
                label3.ForeColor = Color.White; return;
            }
            else if (radioButton9.Checked == true)
            {
                label3.ForeColor = Color.Red; return;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                label3.ForeColor = Color.Black; return;
            }
            else if (radioButton8.Checked == true)
            {
                label3.ForeColor = Color.White; return;
            }
            else if (radioButton9.Checked == true)
            {
                label3.ForeColor = Color.Red; return;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                label3.ForeColor = Color.Black; return;
            }
            else if (radioButton8.Checked == true)
            {
                label3.ForeColor = Color.White; return;
            }
            else if (radioButton9.Checked == true)
            {
                label3.ForeColor = Color.Red; return;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true) 
            {
                label3.TextAlign = ContentAlignment.MiddleLeft;return;
            }
            else if (radioButton11.Checked== true)
            {
                label3.TextAlign = ContentAlignment.MiddleCenter; return;
            }
            else if (radioButton12.Checked == true)
            {
                label3.TextAlign = ContentAlignment.MiddleRight; return;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton10.Checked == true)
            {
                label3.TextAlign = ContentAlignment.MiddleLeft; return;
            }
            else if (radioButton11.Checked == true)
            {
                label3.TextAlign = ContentAlignment.MiddleCenter; return;
            }
            else if (radioButton12.Checked == true)
            {
                label3.TextAlign = ContentAlignment.MiddleRight; return;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton10.Checked == true)
            {
                label3.TextAlign = ContentAlignment.MiddleLeft; return;
            }
            else if (radioButton11.Checked == true)
            {
                label3.TextAlign = ContentAlignment.MiddleCenter; return;
            }
            else if (radioButton12.Checked == true)
            {
                label3.TextAlign = ContentAlignment.MiddleRight; return;
            }
        }
    }
}
