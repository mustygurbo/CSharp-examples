using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Emlak_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath.ToString()+"\\emlakkayit.mdb");

        private void verigoruntule()
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand veri = new OleDbCommand();
            veri.Connection = baglanti;
            veri.CommandText = ("Select * From emlaktablo");
            OleDbDataReader oku = veri.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["durum"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["pazarlik"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
            int kayitsayisi = listView1.Items.Count;
            label10.Text = kayitsayisi.ToString();
        }

        private void verikayit()
        {
            if (textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!=""&& textBox5.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                baglanti.Open();
                OleDbCommand kaydet = new OleDbCommand("insert into emlaktablo (site,durum,oda,metre,fiyat,pazarlik,adsoyad,telefon) values " +
                    "('" + textBox1.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "')", baglanti);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                verigoruntule();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                comboBox1.SelectedItem = null;
                comboBox2.SelectedItem = null;
                comboBox3.SelectedItem = null;
                groupBox1.Enabled = false;
                groupBox1.Text = null;
                button4.Enabled = true;
                button3.Enabled = true;
                button6.Enabled = true;
                
                MessageBox.Show("Yeni Kayıt Eklendi..");
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!!");
            }
        }

        private void verisil()
        {
            if (listView1.SelectedItems.Count == 1)
            {
                var cevap = MessageBox.Show("Silmek İstediğinize Emin Misiniz ?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    baglanti.Open();
                    OleDbCommand sil = new OleDbCommand("delete from emlaktablo where id=" + listView1.SelectedItems[0].SubItems[0].Text.ToString() + "", baglanti);
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                    verigoruntule();
                    MessageBox.Show("Kayıt Silindi..");
                }
                else
                {
                    verigoruntule();
                }
                
            }
            else if (listView1.SelectedItems.Count>1)
            {
                MessageBox.Show("Lütfen Tek Bir Kayıt Seçiniz !!");
            }
            else
            {
                MessageBox.Show("Lütfen Önce Bir Kayıt Seçiniz !!");
            }
            
        }

        private void veriduzenle()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                baglanti.Open();
                OleDbCommand duzenle = new OleDbCommand("update emlaktablo set site='" + textBox1.Text + "',durum='" + comboBox1.Text + "',oda='" + comboBox2.Text + "',metre='" + textBox2.Text + "',fiyat='" + textBox3.Text + "',pazarlik='" + comboBox3.Text + "',adsoyad='" + textBox4.Text + "',telefon='" + textBox5.Text + "' where id=" + listView1.SelectedItems[0].SubItems[0].Text.ToString() + "", baglanti);
                duzenle.ExecuteNonQuery();
                baglanti.Close();
                verigoruntule();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                comboBox1.SelectedItem = null;
                comboBox2.SelectedItem = null;
                comboBox3.SelectedItem = null;
                groupBox1.Enabled = false;
                groupBox1.Text = null;
                button6.Enabled = true;
                button4.Enabled = true;
                button3.Enabled = true;
                MessageBox.Show("Kayıt Düzenlendi..");
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Emlak Kayıt";
            groupBox1.Enabled = false;
            button7.Visible = false;
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verigoruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verikayit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            verisil();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            button2.Visible = true;
            button7.Visible = false;
            groupBox1.Text = "Yeni Kayıt";
            button4.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            groupBox1.Enabled = false;
            groupBox1.Text = null;
            button4.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = true;
            verigoruntule();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                string[] veriler = { listView1.SelectedItems[0].SubItems[0].Text.ToString(),
                listView1.SelectedItems[0].SubItems[1].Text.ToString(),
                listView1.SelectedItems[0].SubItems[2].Text.ToString(),
                listView1.SelectedItems[0].SubItems[3].Text.ToString(),
                listView1.SelectedItems[0].SubItems[4].Text.ToString(),
                listView1.SelectedItems[0].SubItems[5].Text.ToString(),
                listView1.SelectedItems[0].SubItems[6].Text.ToString(),
                listView1.SelectedItems[0].SubItems[7].Text.ToString(),
                listView1.SelectedItems[0].SubItems[8].Text.ToString() };
                textBox1.Text = veriler[1];
                comboBox1.Text = veriler[2];
                comboBox2.Text = veriler[3];
                textBox2.Text = veriler[4];
                textBox3.Text = veriler[5];
                comboBox3.Text = veriler[6];
                textBox4.Text = veriler[7];
                textBox5.Text = veriler[8];
                groupBox1.Enabled = true;
                button2.Visible = false;
                button7.Visible = true;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                groupBox1.Text = "Kayıt Düzenleme";
            }
            else if (listView1.SelectedItems.Count > 1)
            {
                MessageBox.Show("Lütfen Tek Bir Kayıt Seçiniz !!");
            }
            else
            {
                MessageBox.Show("Lütfen Önce Bir Kayıt Seçiniz !!");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            veriduzenle();
        }
    }
}
