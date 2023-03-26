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
    public partial class RandevuOlustur : Form
    {
        public RandevuOlustur()
        {
            InitializeComponent();
        }
        //Sekreter bilgilerini tutmak için oluşturduğumuz değişkenler
        public string SekreterAdi, SekreterSoyadi, SekreterTC,SekreterSifre;
        private void RandevuOlustur_Load(object sender, EventArgs e)
        {
            //Sekreter bilgileri labellara yazdırılır
            label8.Text = this.SekreterTC;
            label10.Text = this.SekreterAdi;
            label11.Text = this.SekreterSoyadi;

            //Veri tabanında bulunan klinikleri listeler
            List<EntityKlinik> klinik = LogicKlinik.KlinikListesi();
            comboBox1.DataSource = null;
            int i = 0;
            while (i < klinik.Count)
            {
                comboBox1.Items.Add(klinik[i].KlinikAdi1);
                i++;
            }

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHastaTC.Text == "" || dateTimePicker1.Text == "" || comboBox1.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    EntityRandevu randevu = new EntityRandevu();

                    randevu.HastaTC1 = txtHastaTC.Text;
                    randevu.KlinikID1 = Convert.ToInt32(textBox3.Text);
                    randevu.DoktorTC1 = (txtDoktorTC.Text).ToString();
                    randevu.Date = dateTimePicker1.Value;
                    randevu.HastaAdi1 = txtHastaAdi.Text;
                    randevu.HastaSoyadi1 = txtHastaSoyadi.Text;
                    randevu.Eposta = textBox1.Text;

                    LogicRandevu.LLRandevuOlustur(randevu);

                    MessageBox.Show("Randevunuz başarıyla oluşturulmuştur !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Randevu oluşturma işlemi gerçekleştirilmedi.\n\n Tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Klinik adı seçildikten sonra seçilen kliniklere göre doktorların isimlerini listeler
            comboBox2.Items.Clear();
            int klinikID = Convert.ToInt32(textBox3.Text);
            List<EntityDoktor> doktorListele = LogicKlinik.IlgiliBranchDoctorListele(klinikID);
            comboBox2.DataSource = null;
            int a = 0;
            while (a < doktorListele.Count)
            {
                comboBox2.Items.Add(doktorListele[a].DoktorAdi1);
                a++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox da klinik adı seçildiğinde textbox içine klinikID yazdırılır
            EntityKlinik klinik = new EntityKlinik();
            klinik.KlinikAdi1 = comboBox1.Text;
            klinik = LogicKlinik.LLKlinikIDListele(klinik);
            textBox3.Text = klinik.KlinikID1.ToString();
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuKayitlari randevuKayitlari = new RandevuKayitlari();
            randevuKayitlari.Show();
            this.Hide();
        }

        private void txtDoktorTC_TextChanged(object sender, EventArgs e)
        {

        }

        //Sekreter ekranına geri döner
        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SekreterEkranı sekreterEkranı= new SekreterEkranı();
            sekreterEkranı.SekreterAdi = this.SekreterAdi;
            sekreterEkranı.SekreterSoyadi = this.SekreterSoyadi;
            sekreterEkranı.SekreterTC = this.SekreterTC;

            sekreterEkranı.Show();
            this.Close();
        }

        //kullanıcal sayfasına döner
        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar =new Kullanicilar();
            kullanicilar.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Comboboxda doktor adı seçildiğinde textboxda DoktorID yazdırılır
            EntityDoktor doktor = new EntityDoktor();
            doktor.DoktorAdi1 = comboBox2.Text;
            doktor = LogicDoktor.LLDoktorIDListele(doktor);
            txtDoktorTC.Text = doktor.DoktorTC1.ToString();



        }
    }
}
