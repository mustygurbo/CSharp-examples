using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = @"Küpün hacmi : a3
Dikdörtgenler prizmasının hacmi: a.b.c
Silindirin hacmi: π.r2.h
Kürenin hacmi: 4/3. π.r2
Düzgün hacimli olmayan cisimlerin hacmi: Taşırma kabıyla bulunur.
Şimdi de kütle, hacim, öz kütle ve eşit kollu terazi kavramlarına bakalım.
Kütle m, hacim V, öz kütle d olarak ifade edilir.
m/V = d ⇒ kütle / hacim = öz kütle
Öz ağırlık p = d.g olur.
Eşit hacimde karıştırılan iki sıvının öz kütlesi (d1 + d2) /2 olur.
Eşit kütlede karıştırılan iki sıvının öz kütlesi 2.d1.d2 / (d1 + d2) olur.
Sıvıların kaldırma kuvveti F = Vbatan.dsıvı olur.
Ağırlık G = g. m şeklindedir. Burada g yer çekimi ivmesi, m ise kütledir.
Eşit kollu terazide binici kütlesi m, terazideki bölme sayısı N olmak üzere, terazinin hassasiyeti m/N olur.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = @"Kuvvet F ile gösterilir. Burada x ya da d uzunluk/yol olur. Hız ise v ile gösterilir.

Hız = yol / zaman, v = x/t olur.

Teldeki uzama x= F.k olur.

Bileşke kuvvet için arada arada 90 derece varsa √2 katı, 60 derece varsa √3 katı, 120 derece varsa 1 katı olur. Burada iki kuvvetin eşit büyüklükte olması gerekir.

Birden çok kuvvet için Lami teoremi uygulanır. F1 /sina = F2/sinb … şeklinde gider.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = @"Mekanik enerji = potansiyel enerji + kinetik enerji
Potansiyel enerji = m.g.h
Kinetik enerji = 1/2.m.v2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = @"Öncelikle ısı ve sıcaklık farkını iyi bilmemiz gerekir Isı bir enerjidir. Sıcaklık ise moleküllerin ortalama kinetik enerjisinin ölçümüdür.

Sıcaklığı yüksek olandan düşük olana doğru ısı geçişi olur.

Q = m.c.Δt hal değiştirme sırasında ise Q = m.L formülü uygulanır. Q ısı, m kütle, c öz ısı, t ise zamandır.

Genleşme cismin ilk boyu, sıcaklık ve madde cinsiyle ilişkilidir.

Genleşme miktarı ΔL =  L0.λ.Δt olur. Yani ilk boy, genleşme katsayısı ve sıcaklık farkının çarpımıdır.";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = @"Dış bükey bir çokgenin n tane kenarı var ise iç açılarının toplamı

 (n - 2) . 180°

Dış açılar toplamı: Bütün dışbükey çokgenlerde

 Dış açılar toplamı =360°

Köşegenlerin sayısı: n kenarlı dışbükey bir çokgenin

 n.(n-3) / 2

Bir köşeden (n – 3) tane köşegen çizilebilir.

n kenarlı dışbükey bir çokgenin içerisinde, bir köşeden köşegenler çizilerek
(n – 2) adet üçgen elde edilebilir.

n kenarlı düzgün bir çokgende bir iç açının ölçüsü

(n - 2) . 180°/ n

Konveks çokgenlerin dış açıları toplamı 360° olduğundan düzgün çokgenin bir dış açısının ölçüsü

360° / n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = @"KARE'NİN ALANI:
 
A=a.a
(a karenin bir kenarı)


DİKDÖRTGEN'İN ALANI:

 A = a.b
(a kısa kenarı, b uzun kenarı)


YAMUK'UN ALANI:

 A = (a+c).h / 2 (a alt taban uzunluğu, c üst taban uzunluğu, h yükseklik)


PARALELKENAR'IN ALANI:

 A = a.h (a taban kenarı, h tabana inen yükseklik)

DAİRE'NİN ALANI:
A = π.r.r
(π=3,14 alırız r dairenin yarıçapı)";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = @"SİLİNDİR'İN HACMİ:
H = taban alan.yükseklik
H = π.r.r.h
(π=3,14 alırız, r taban yarıçapı, h yükseklik)
(konserve tenekesi) 

KÜP'ÜN HACMİ:
H = a.a.a
(a küpün bir kenarının uzunluğu)
(küp şeker)

DİKDÖRTGENLER PRİZMASI'NIN HACMİ:
H = a.b.c
(a en, b boy, c yüksekliği)
(kibrit kutusu)

KARE PRİZMA'NIN HACMİ:
H = taban alan.yüksekliği H = a.a.b
(a kare olan tabanın bir kenarı, b yükseklik)

DİK PRİZMALARIN HACMİ: V= (taban alanı) X (yükseklik)";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = @"İki Kare Farkı - Toplamı

I) a2 – b2 = (a – b) (a + b)
II) a2 + b2 = (a + b)2 – 2ab  ya da
a2 + b2 = (a – b)2 + 2ab  dir.

 İki Küp Farkı - Toplamı

I) a3 – b3 = (a – b) (a2 + ab + b2 )
II) a3 + b3 = (a + b) (a2 – ab + b2 )
III) a3 – b3 = (a – b)3 + 3ab (a – b)
IV) a3 + b3 = (a + b)3 – 3ab (a + b)

Tam Kare İfadeler

I) (a + b)2 = a2 + 2ab + b2
(a + b)2 = (a – b)2 + 4ab
II) (a – b)2 = a2 – 2ab + b2
(a – b)2 = (a + b)2 – 4ab
III) (a + b + c)2 = a2 + b2 + c2 + 2(ab + ac + bc)
IV) (a + b – c)2 = a2 + b2 + c2 + 2(ab – ac – bc)

(a + b)3 = a3 + 3a2b + 3ab2 + b3
(a – b)3 = a3 – 3a2b + 3ab2 – b3
(a + b)4 = a4 + 4a3b + 6a2b2 + 4ab3 +b4
(a – b)4 = a4 – 4a3b + 6a2b2 – 4ab3 + b4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }
    }
}
