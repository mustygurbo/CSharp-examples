using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void koçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "21 Mart - 20 Nisan";
        }

        private void koçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Bugün büyük adımlar atmaya hazırlanıyorsun. Adeta yeni yılı karşılarcasına kişisel değişimlere giderken, uzun zamandır hayal ettiğin seyahat için de planlar yapacaksın. Bugün çevrendeki insanların sorunlarıyla ilgilenmek isteyebilirsin ancak bazı insanlara karşı da tavrını net olarak ortaya koymayı planlıyorsun. Bu durum seni oldukça sosyal, dışa dönük ve biraz da aceleci yapacak.";
        }

        private void boğaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "21 Nisan - 20 Mayıs";
        }

        private void ikizlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "21 Mayıs - 21 Haziran";
        }

        private void yengeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "22 Haziran - 22 Temmuz";
        }

        private void aslanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "23 Temmuz - 22 Ağustos";
        }

        private void başakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "23 Ağustos - 22 Eylül";
        }

        private void teraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "23 Eylül - 23 Ekim";
        }

        private void akrepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "24 Ekim - 22 Kasım";
        }

        private void yayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "23 Kasım - 21 Aralık";
        }

        private void oğlakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "22 Aralık - 20 Ocak";
        }

        private void kovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "21 Ocak - 18 Şubat";
        }

        private void balıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "19 Şubat - 20 Mart";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Burç Defteri";
            pictureBox1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void burçYorumlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            label2.Text = "";
            label2.BackColor = Color.DarkSeaGreen;
        }

        private void burçTarihleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label2.Visible = false;
            label1.Visible = true;
            label1.Text = "";

        }

        private void boğaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Aşk konusunda daha da seçici olacağın günler başlıyor. Olacak olsaydı birlikteliğim zaten bitmezdi dediğin günlerde birlikte olduğun kişiye benzer kişilerle karşılaşabilirsin. Bir daha aynı şeyleri yaşayamam diyebilirsin. Evet, şu an kafan gerçekten çok karışık. 'Bu ne zaman bitecek, bunu ne zaman yapacaktım' gibi sorular aklına yığılıp kalmış bir vaziyette.";
        }

        private void ikizlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Ruhsal anlamda kendini besleyecek işler yapabilir, seninle aynı düşüncede olan insanlarla vakit geçirmek isteyebilirsin. Senin için çalışma, üretme, yenilenme ve değişim ön planda olacak. Bu süreci tetikleyen olaylar da var. Özellikle yaşam alanını ve günlük hayatını daha verimli kılmak adına farklı topluluklara ya da gruplara dâhil olabilirsin.";
        }

        private void yengeçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Mücadele edeceğin alanlarda saldırgan olmamalısın. Hızlı ve ani kararlar üzülmene neden olabilir. Kendi işini yapan bir Yengeç burcuysan, sektörünü ön plana çıkarmak için reklam kampanyalarına dâhil olabilirsin. İlişkisi olmayan bir Yengeç burcuysan, artık daha kararlı adımlar atmak isteyeceksin.";
        }

        private void aslanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Katılacağın etkinliklerde önemli işler yapmış insanlarla bir arada olabilirsin. Fikirlerinle çevreni etki altında bırakacaksın. Bu durum seni son derece besleyecek. Ekonomik olarak yeni düzenlemelere gidebilirsin. Gereksiz harcamaların üzerinde büyük yük oluşturduğunu biliyorsun. İş arayışındaysan, kendini umutsuz hissedebilirsin.";
        }

        private void başakToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Bu zamana kadar ne yaptıysam olmadı, başarısız oldum dediğin konuların kapısının sana bir bir açıldığına şahit olacaksın. Eğer bir süredir iş yerinde sorun yaşayan bir Başak burcuysan bugün başaracağın tek bir projeyle herkesin önüne geçebilir, vazgeçilmezi oynayabilirsin. Kendi işini yapan bir Başak burcuysan, yurtdışı bağlantılı anlaşmaya imza atabilirsin.";
        }

        private void teraziToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Bugün hırsın ve mücadeleci yanın herkes tarafından fark ediliyor. Aynı zamanda birilerine yön vermek, yönlendirmek de bir o kadar kontrolün altında olacak. Tek sorun ise bu döngüde dikkatini toparlaman gereken konularda, kararsız kalışın. Bazı fikirleri çok kişiselleştirip, konuşmaları bir anda tartışmalara çevirebilirsin.";
        }

        private void akrepToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Eğer ailenle ortaklı bir iş yapısı içindeysen statünü güçlendirebilir, işleri lehine çevirebilirsin. Bugünden itibaren güç gösterisinde bulunacağın olaylar yaşayacaksın. Yaşam alanına dair ve finansal konularda sessiz sakin çaba gösterirken, bir yandan da öğrenmek, keşfetmek, kafandaki düşünceleri ehlileştirmek adına önemli bir mesai harcıyor olacaksın.";
        }

        private void yayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"İşlerin yoğun olacağı bir döneme giriyorsun. Kendi işini büyütmek ya da çalışan sayısını artırmak istiyorsan elini çabuk tutmalısın. Maddi anlamda beklenti içinde olduğun iş bağlantıların bugün çözülebilir. Bu sayede para akışını arttırabilirsin. Kendinden emin davranman birilerinin hoşuna gidecektir ama bunu profesyonel bir boyutta tutmaya ayrıca özen göstermelisin.";
        }

        private void oğlakToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Bugünlerde yine her zamanki gibi iş ve sorumluluk derken adeta kendini unutabilirsin. Fakat dış dünyadan kendini geri çekip, biraz daha kendine dönebilirsin. Çevrendeki insanlarla mücadele etmekte sıkıldığın bir dönemde değişim başlayacak senin için. Eğer evli bir Oğlak burcuysan eşinin ailesiyle ilgili maddi konular gündeme gelebilir ve yatırım yapmakla ilgili planlar yapmak isteyebilirsin.";
        }

        private void kovaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Genel olarak kariyer alanında yükseldiğin ve finans alanında sonuçlar yaşayacağın bir gün olacak. Geçen ay yapmış olduğun harcamaları bugün toparlayabilirsin. Ay sonuna doğru gelir ve giderlerin arasında fark olmamasına dikkat etmelisin. İş arayışında olan bir Kova burcuysan, önemli bir referans sayesinde iş görüşmesine davet edilebilirsin.";
        }

        private void balıkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = @"Maddi konular gündeminde olacak. Kazancını arttırmanın yollarını arayacaksın. Sorumlulukların üzerinde ağırlık oluşturuyor. Pes etmekse sana göre değil. Hayatına yön vermek için detayları görmelisin. Gün içerisinde geçmişine ve yüreğine gömdüklerinin zihninde canlandığına tanıklık edebilirsin. 'Ben bunları çoktan aştım' dediğin çok mesele var. Peki, gerçekten üstüne bir çizik atabildin mi?";
        }

        private void burçRenkleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = true;
            label2.Text = "";
            label2.BackColor = Color.White;
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void koçToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void boğaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.CornflowerBlue;
        }

        private void ikizlerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Yellow;
        }

        private void yengeçToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Silver;
        }

        private void aslanToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Orange;
        }

        private void başakToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Green;
        }

        private void teraziToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Blue;
        }

        private void akrepToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.DarkRed;
        }

        private void yayToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Purple;
        }

        private void oğlakToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.SaddleBrown;
        }

        private void kovaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.LightBlue;
        }

        private void balıkToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Turquoise;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
