using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dosya_Duzenleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
            this.Text = "IMG Office";
            textBox1.Text = "Klasör Adı..";
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Metin Dosyası Seçiniz..";
            openFileDialog1.Filter = "Metin Belgesi |*.txt";
            openFileDialog1.RestoreDirectory = true;
            
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyayolu = openFileDialog1.FileName;
                richTextBox1.LoadFile(dosyayolu, 
                    RichTextBoxStreamType.PlainText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.txt";
            saveFileDialog1.Filter = "Metin Belgesi|*.txt";
            saveFileDialog1.Title = "Kaydedilecek Dosya";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string kayıtyolu = saveFileDialog1.FileName;
                richTextBox1.SaveFile(kayıtyolu,
                    RichTextBoxStreamType.PlainText);
                MessageBox.Show("Dosya Kaydedildi!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!= "")
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string klasoradi = textBox1.Text;
                    Directory.CreateDirectory((folderBrowserDialog1.SelectedPath) + "\\" + klasoradi);
                    MessageBox.Show("Klasör Oluşturuldu!");
                }   
            }
            else
            {
                MessageBox.Show("Klasör Adı Boş Bırakılamaz!!");
            }
            
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Klasör Adı..";
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Klasör Adı..";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
