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
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data.Sql;

namespace HastaneOtomasyon
{
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //sekreter ekleme butonu
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                EntitySekreter ent = new EntitySekreter();
                ent.SekreterTC1 = txtSekreterTC.Text;
                ent.SekreterAdi1 = txtSekreterAdi.Text;
                ent.SekreterSoyadi1 = txtSekreterSoyadi.Text;
                ent.SekreterSifre1 = txtSekreterSifre.Text;

                LogicSekreter.LLSekreterEkle(ent);
                List<EntitySekreter> SekreterList = LogicSekreter.LLSekreterLİstesi();
                dataGridView1.DataSource = SekreterList;

                MessageBox.Show("Sekreter başarıyla eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ekleme işlemi gerçekleştirilemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        //Sekreter Listeleme
        private void button7_Click(object sender, EventArgs e)
        {
            List<EntitySekreter> SekreterList = LogicSekreter.LLSekreterLİstesi();
            dataGridView1.DataSource = SekreterList;
        }

        //Sekreter Güncelleme
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EntitySekreter ent = new EntitySekreter();
                ent.SekreterTC1 = txtSekreterTC.Text;
                ent.SekreterAdi1 = txtSekreterAdi.Text;
                ent.SekreterSoyadi1 = txtSekreterSoyadi.Text;
                ent.SekreterSifre1 = txtSekreterSifre.Text;

                LogicSekreter.LLSekreterGuncelle(ent);

                List<EntitySekreter> SekreterList = LogicSekreter.LLSekreterLİstesi();
                dataGridView1.DataSource = SekreterList;
                MessageBox.Show("Sekreter başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Güncelleme işleminiz gerçekleştirilemdi.\n\n Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        //Sekreter bilgilerini tutmak için oluşturduğumuz değişkenler
        public string SekreterAdi, SekreterSoyadi, SekreterTC, SekreterSifre;
        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.TextAlign = ContentAlignment.MiddleLeft;


            //Form yüklendiğinde otomatik tüm sekreterleri getirir
            List<EntitySekreter> sekreter = LogicSekreter.LLSekreterLİstesi();
            dataGridView1.DataSource = sekreter;

            //Form yüklendiğinde doktorları listeler
            List<EntityDoktor> doktor = LogicDoktor.LLDoktorLİstesi();
            dataGridView2.DataSource = doktor;


            //Form yüklendiğinde Klinik Adlarını combobox içine listeler
            List<EntityKlinik> klinik = LogicKlinik.KlinikListesi();
            comboBox1.DataSource = null;
            int i = 0;
            while (i < klinik.Count)
            {
                comboBox1.Items.Add(klinik[i].KlinikAdi1);
                i++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGrid'de seçilen değerleri textbox içine doldurur
            try
            {
                txtSekreterTC.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtSekreterAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSekreterSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtSekreterSifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seçme işleminiz gerçekleştirilemdi.\n\n Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Sekreter Silme Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                EntitySekreter ent = new EntitySekreter();
                ent.SekreterTC1 = txtSekreterTC.Text;
                LogicSekreter.LLSekreterSil(ent.SekreterTC1);
                //TextBox içini temizler
                txtSekreterAdi.Text = "";
                txtSekreterSoyadi.Text = "";
                txtSekreterSoyadi.Text = "";
                txtSekreterTC.Text = "";
                txtSekreterSifre.Text = "";
                // tüm hastaları getirir
                List<EntitySekreter> hasta = LogicSekreter.LLSekreterLİstesi();
                dataGridView1.DataSource = hasta;
                MessageBox.Show("Sekreter başarıyla silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Silme işleminiz gerçekleştirilemdi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        //Doktor Ekleme Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            // doktor ekleme işlemi için gerekli olan kodlar
            try
            {
                EntityDoktor ent = new EntityDoktor();
                ent.DoktorTC1 = textDoktorTC.Text;
                ent.DoktorAdi1 = txtDoktorAdi.Text;
                ent.DoktorSoyadi1 = txtDoktorSoyadi.Text;
                ent.DoktorSifre1 = txtDoktorSifre.Text;

                ent.KlinikID = int.Parse(txtid.Text);

                LogicDoktor.LLDoktorEkle(ent);

                List<EntityDoktor> doktor = LogicDoktor.LLDoktorLİstesi();
                dataGridView2.DataSource = doktor;

                MessageBox.Show("Doktor başarıyla eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ekleme işleniniz gerçekleştirilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


  


        }

        //Klinik adı combobox1'den seçildiğinde Klinik ıd textbox içine otomatik gelir.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntityKlinik klinik = new EntityKlinik();
            klinik.KlinikAdi1 = comboBox1.Text;
            klinik = LogicKlinik.LLKlinikIDListele(klinik);
            txtid.Text = klinik.KlinikID1.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DataGrid'de seçilen değerleri textbox içine doldurur
                textDoktorTC.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtDoktorAdi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtDoktorSoyadi.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtid.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                txtDoktorSifre.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seçme işleminiz gerçekleştirilemedi.\n\n Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Doktor Güncelleme butonu 
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {


                EntityDoktor ent = new EntityDoktor();
                ent.DoktorTC1 = textDoktorTC.Text;
                ent.DoktorAdi1 = txtDoktorAdi.Text;
                ent.KlinikID = Convert.ToInt32(txtid.Text);
                ent.DoktorSoyadi1 = txtDoktorSoyadi.Text;
                ent.DoktorSifre1 = txtDoktorSifre.Text;

                LogicDoktor.LLDoktorGuncelle(ent);

                // tüm doktorları getirir
                List<EntityDoktor> doktor = LogicDoktor.LLDoktorLİstesi();
                dataGridView2.DataSource = doktor;
                MessageBox.Show("Doktor başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Güncelleme işleminiz gerçekleştirilemedi.\n\n Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        //Doktor Silme Butonu
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                EntityDoktor ent = new EntityDoktor();
                ent.DoktorTC1 = textDoktorTC.Text;
                LogicDoktor.LLDoktorSil(ent.DoktorTC1);
                //TextBox içini temizler
                txtDoktorAdi.Text = "";
                txtDoktorSoyadi.Text = "";
                textDoktorTC.Text = "";
                txtDoktorSifre.Text = "";
                MessageBox.Show("Doktor başarıyla silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Silmek istediğiniz doktora ait randevu kayıtları bulunmaktadır"+"\n"+"İşleminizi gerçekleştiremiyoruz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            List<EntityDoktor> doktor = LogicDoktor.LLDoktorLİstesi();
            dataGridView2.DataSource = doktor;
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

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            


        }

        private void Kullanicilar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
