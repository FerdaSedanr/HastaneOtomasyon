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
    public partial class PoliklinikIslemleri : Form
    {
        public PoliklinikIslemleri()
        {
            InitializeComponent();
        }

        //Sekreter bilgilerini tutmak için oluşturduğumuz değişkenler
        public string SekreterAdi, SekreterSoyadi, SekreterTC, SekreterSifre;

        //Polikilinik ekleme butonu
        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            EntityKlinik ent = new EntityKlinik();
            ent.KlinikID1 = int.Parse(txtID.Text);
            ent.KlinikAdi1 = txtAd.Text;
              

            LogicKlinik.LLKlinikEkle(ent);
                MessageBox.Show("Ekleme işlemi gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch {
                MessageBox.Show("Ekleme işlemi gerçekleştirilmedi.\n\n Tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // tüm hastaları getirir
            List<EntityKlinik> klinik = LogicKlinik.LLEntityKlinik();
            dataGridView1.DataSource = klinik;


        }

        private void PoliklinikIslemleri_Load(object sender, EventArgs e)
        {
            //Form yüklendiğinde tüm poliklinikeri getirir.
            List<EntityKlinik> klinik = LogicKlinik.LLEntityKlinik();
            dataGridView1.DataSource = klinik;
        }

        //Polikilinik silme butonu
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EntityKlinik ent = new EntityKlinik();
                ent.KlinikID1 = int.Parse(txtID.Text);

                LogicKlinik.LLKlinikSil(ent.KlinikID1);
                txtID.Text = "";
                txtAd.Text = "";
                MessageBox.Show("Silme işlemi gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Silme işlemi gerçekleştirilmedi.\n\n Tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            // tüm hastaları getirir
            List<EntityKlinik> klinik = LogicKlinik.LLEntityKlinik();
            dataGridView1.DataSource = klinik;
        }


        //Polikilinik güncelleme butonu
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                EntityKlinik ent = new EntityKlinik();
                ent.KlinikID1 = int.Parse(txtID.Text);
                ent.KlinikAdi1 = txtAd.Text;

                LogicKlinik.LLKlinikGuncelle(ent);
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Güncelleme işlemi gerçekleştirilmedi.\n\n Tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            List<EntityKlinik> klinik = LogicKlinik.LLEntityKlinik();
            dataGridView1.DataSource = klinik;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SekreterEkranı sekreterEkranı = new SekreterEkranı();

            sekreterEkranı.SekreterAdi = this.SekreterAdi;
            sekreterEkranı.SekreterSoyadi = this.SekreterSoyadi;
            sekreterEkranı.SekreterTC = this.SekreterTC;

            sekreterEkranı.Show();
            this.Close();
        }
    }
}
