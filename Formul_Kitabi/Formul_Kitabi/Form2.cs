﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formul_Kitabi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
    }
}
