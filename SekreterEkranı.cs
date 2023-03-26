using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using LogicLayer;

namespace HastaneOtomasyon
{
    public partial class SekreterEkranı : Form
    {
        public SekreterEkranı()
        {
            InitializeComponent();
            
        }
        
        public string SekreterAdi, SekreterSoyadi,SekreterTC, SekreterSifre;

        private void SekreterEkranı_Load(object sender, EventArgs e)
        {
            //Giriş yapan Sekreterin Ad-soyad ve TC'sini labelllara yazdırır

            label6.Text = this.SekreterTC;
            label2.Text = this.SekreterAdi;
            label3.Text = this.SekreterSoyadi;
        }

        //Randevu oluşturma ekranına gider
        private void button1_Click(object sender, EventArgs e)
        {
            RandevuOlustur randevuEkrani = new RandevuOlustur();
            randevuEkrani.SekreterAdi = this.SekreterAdi;
            randevuEkrani.SekreterSoyadi = this.SekreterSoyadi;
            randevuEkrani.SekreterTC = this.SekreterTC;

            randevuEkrani.Show();
            this.Hide();
        }

        //Hasta Görüntüleme ekranına gider
        private void button3_Click(object sender, EventArgs e)
        {
            
            HastaGoruntuleme hastaGoruntuleme = new HastaGoruntuleme();
            hastaGoruntuleme.SekreterAdi = this.SekreterAdi;
            hastaGoruntuleme.SekreterSoyadi = this.SekreterSoyadi;
            hastaGoruntuleme.SekreterTC = this.SekreterTC;

            hastaGoruntuleme.Show();
            this.Hide();
        }

        //Hasta Görüntüleme Ekranını Açar
        private void hastalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaGoruntuleme hastaGoruntuleme = new HastaGoruntuleme();
            hastaGoruntuleme.SekreterAdi= this.SekreterAdi;
            hastaGoruntuleme.SekreterSoyadi = this.SekreterSoyadi;
            hastaGoruntuleme.SekreterTC = this.SekreterTC;
            hastaGoruntuleme.ShowDialog();
        }

        //Geri butonu sekreter Giriş ekranına döner
        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SekreterGirisYap sekreterGirisYap = new SekreterGirisYap();
            sekreterGirisYap.Show();
            this.Hide();
        }

        //Kullanıcılar sayfasına gider
        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        { Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.Show();
            this.Hide();

        }
        //Grafikler sayfasına gider
        private void grafikler_Click(object sender, EventArgs e)
        {
            Grafikler grafikler = new Grafikler();
            grafikler.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ;

            PoliklinikIslemleri poliklinikIslemleri = new PoliklinikIslemleri();
            poliklinikIslemleri.SekreterAdi = this.SekreterAdi;
            poliklinikIslemleri.SekreterSoyadi = this.SekreterSoyadi;
            poliklinikIslemleri.SekreterTC = this.SekreterTC;
            poliklinikIslemleri.Show();
            this.Hide();
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuKayitlari randevuKayitlari = new RandevuKayitlari();
            randevuKayitlari.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.SekreterAdi = this.SekreterAdi;
            kullanicilar.SekreterSoyadi = this.SekreterSoyadi;
            kullanicilar.SekreterTC = this.SekreterTC;

            kullanicilar.Show();
            this.Hide();

        }
    }
}
