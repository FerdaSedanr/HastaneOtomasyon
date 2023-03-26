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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Net.Mail;

namespace HastaneOtomasyon
{
    
    public partial class HastaGoruntuleme : Form
    {
        public HastaGoruntuleme()
        {
            InitializeComponent();
        }

        //Hastaları Listeleme
        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityHasta> HastaList = LogicHasta.LLHastaLİstesi();
            dataGridView1.DataSource = HastaList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Hasta Ekleme Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //ekleme işlemi için gerekli olan kodlar
                EntityHasta ent = new EntityHasta();
                ent.HastaTc = txthtc.Text;
                ent.HastaAdi = txthadi.Text;
                ent.HastaSoyadi = txtHsoyadi.Text;
                ent.DogumTarihi = txthdogumtarihi.Text;
                ent.Cinsiyeti = comboBox3_cinsiyet.Text;
                ent.Ceptel = maskedTextBox1_telno.Text;
                ent.EPosta = txtheposta.Text;
                ent.KlinikID1 = int.Parse(txtKlinik.Text);
                ent.Teshis1 = richTextBox1.Text;
                ent.DoktorNotu1 = richTextBox2.Text;
                ent.DoktorTC1 = txtDoktor.Text;
                ent.KanTahlil1 = comboBox2_Tahlil.Text;
                ent.Rontgen1 = comboBox3_Rntgn.Text;

                LogicHasta.LLHastaEkle(ent);


                // tüm hastaları getirir
                List<EntityHasta> hasta = LogicHasta.LLHastaLİstesi();
                dataGridView1.DataSource = hasta;
            }
            catch
            {
                MessageBox.Show("Ekleme işlemi gerçekleştirilemedi...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //Hasta Silme Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EntityHasta ent = new EntityHasta();
                ent.HastaTc = txthtc.Text;
                LogicHasta.LLHastaSil(ent.HastaTc);
                txthtc.Text = "";
                txthadi.Text = "";
                txtHsoyadi.Text = "";
                txthdogumtarihi.Text = "";
                comboBox3_cinsiyet.Text = "";
                maskedTextBox1_telno.Text = "";
                txtheposta.Text = "";
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox1.Text = "";
                comboBox2_Tahlil.Text = "";
                comboBox3_Rntgn.Text = "";

                MessageBox.Show("Silme işlemi gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // tüm hastaları getirir
                List<EntityHasta> hasta = LogicHasta.LLHastaLİstesi();
                dataGridView1.DataSource = hasta;
            }
            catch
            {
                MessageBox.Show("Silme işlemi gerçekleştirilemedi...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //Güncelleme Butonu
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                EntityHasta ent = new EntityHasta();
                ent.HastaTc = txthtc.Text;
                ent.HastaAdi = txthadi.Text;
                ent.HastaSoyadi = txtHsoyadi.Text;
                ent.DogumTarihi = txthdogumtarihi.Text;
                ent.Cinsiyeti = comboBox3_cinsiyet.Text;
                ent.Ceptel = maskedTextBox1_telno.Text;
                ent.EPosta = txtheposta.Text;
                ent.KlinikID1 = Convert.ToInt32(txtKlinik.Text);
                ent.Teshis1 = richTextBox1.Text;
                ent.DoktorNotu1 = richTextBox2.Text;
                ent.DoktorTC1 = txtDoktor.Text;
                ent.KanTahlil1 = comboBox2_Tahlil.Text;
                ent.Rontgen1 = comboBox3_Rntgn.Text;


                LogicHasta.LLHastaGuncelle(ent);

                List<EntityHasta> HastaList = LogicHasta.LLHastaLİstesi();
                dataGridView1.DataSource = HastaList;
                MessageBox.Show("Güncelleme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Güncelleme işlemi gerçekleştirilemedi...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sekreter bilgilerini tutmak için oluşturduğumuz değişkenler
        public string SekreterAdi, SekreterSoyadi, SekreterTC, SekreterSifre;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Form yüklendiğinde otomatik tüm hastaları getirir
            List<EntityHasta> hasta = LogicHasta.LLHastaLİstesi();
            dataGridView1.DataSource = hasta;

            //combobax klinik adlarını listeleme

            List<EntityKlinik> klinik = LogicKlinik.KlinikListesi();
            comboBox1.DataSource = null;
            int i = 0;
            while (i < klinik.Count)
            {
                comboBox1.Items.Add(klinik[i].KlinikAdi1);
                i++;
            }

           






        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntityDoktor doktor = new EntityDoktor();
            doktor.DoktorAdi1 = comboBox2.Text;
            doktor = LogicDoktor.LLDoktorIDListele(doktor);
            txtDoktor.Text = doktor.DoktorTC1;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            comboBox2_Tahlil.Enabled = true;
            comboBox3_Rntgn.Enabled = true;
            try
            {

                //DataGrid'de seçilen alanları TexBoxların içine getirir
                txthtc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                txthadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtHsoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txthdogumtarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox3_cinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                maskedTextBox1_telno.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtheposta.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtKlinik.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

                richTextBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                richTextBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtDoktor.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

                comboBox2_Tahlil.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                comboBox3_Rntgn.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seçme işleminiz gerçekleştirilemedi. \n\n Lütfen tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntityKlinik klinik = new EntityKlinik();
            klinik.KlinikAdi1 = comboBox1.Text;
            klinik = LogicKlinik.LLKlinikIDListele(klinik);
            txtKlinik.Text = klinik.KlinikID1.ToString();

        }

        

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SekreterEkranı sekreterEkranı = new SekreterEkranı();
            sekreterEkranı.Show();
            this.Hide();
        }

        private void geriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SekreterEkranı sekreterEkranı = new SekreterEkranı();

            sekreterEkranı.SekreterAdi = this.SekreterAdi;
            sekreterEkranı.SekreterSoyadi = this.SekreterSoyadi;
            sekreterEkranı.SekreterTC = this.SekreterTC;

            sekreterEkranı.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            comboBox2_Tahlil.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3_Rntgn.Enabled = true;
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_Rntgn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilendeger = comboBox3_Rntgn.SelectedItem.ToString();
            if(secilendeger== "Ortopedik Muayene")
            {
                comboBox2.Enabled = true;
                comboBox2.Items.Add("Kol");
                comboBox2.Items.Add("Bacak");
                comboBox2.Items.Add("Bilek");
                comboBox2.Items.Add("Diz");
                
            }
            else
            {
                comboBox2.Enabled = false;
            }
        }

        //pdf oluşturma kodları
        private void pdfButon_Click(object sender, EventArgs e)
        {
            if (txthtc.Text != "")
            {
                string pdfstring = "Hastanın Adı Soyadı: " + txthadi.Text + " " + txtHsoyadi.Text + Environment.NewLine + "Hasta Tc No: " + txtHastaTc.Text + Environment.NewLine
                    + "Hasta Mail Adresi: " + txtheposta.Text + Environment.NewLine + "Hasta Telefon Numarası: " + maskedTextBox1_telno.Text + Environment.NewLine + "Hasta Tahlil: " + comboBox2_Tahlil.Text + Environment.NewLine + "Hasta Röntgen: " 
                    + comboBox3_Rntgn.Text + Environment.NewLine + "Teşhis Sonucu: " + richTextBox1.Text + Environment.NewLine; ; 
                    

                SaveFileDialog file = new SaveFileDialog();
                file.Filter = "PDF DOSYALARI(*.pdf) | *.pdf";
                file.Title = "PDF DOSYASI OLUŞTURMA";
                file.FileName = txthtc.Text + "Rapor" + DateTime.Now.ToString("MM/dd/yyyy");
                if (file.ShowDialog() == DialogResult.OK)
                {
                    FileStream dosya = File.Open(file.FileName, FileMode.Create);
                    Document pdf = new Document();
                    PdfWriter.GetInstance(pdf, dosya);
                    pdf.Open();
                    //pdf.AddAuthor(Doktoradi);
                   // pdf.AddCreator(Doktoradi);
                   // pdf.AddTitle( + "_Rapor");
                    pdf.AddSubject(txtHastaTc + "_Rapor");
                    //pdf.AddKeywords(lblHastaTcNo + "_Rapor");
                    pdf.AddCreationDate();
                    BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, "CP1254", BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.NORMAL);
                    Paragraph paragraph = new Paragraph(pdfstring, font);
                    pdf.Add(paragraph);
                    pdf.Close();
                    MessageBox.Show("Pdf başarıyla kaydedilmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


                }
            }
            else
            {
                if (txthtc.Text == "")
                {
                    MessageBox.Show("Lütfen bir hasta seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Seçmiş olduğunuz hastanın bir raporu bulunmamaktadır.");
                }
            }
        }

        private void HastaGoruntuleme_DoubleClick(object sender, EventArgs e)
        {
            txthtc.Text = "";
            txthadi.Text = "";
            txtHsoyadi.Text = "";
            txthdogumtarihi.Text = "";
            comboBox3_cinsiyet.Text = "";
            maskedTextBox1_telno.Text = "";
            txtheposta.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            txtKlinik.Text = "";
            comboBox1.Text = "";
            comboBox2_Tahlil.Text = "";
            comboBox3_Rntgn.Text = "";
        }

        private void txtDoktor_TextChanged(object sender, EventArgs e)
        {

        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtKlinik_TextChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            int klinikID = Convert.ToInt32(txtKlinik.Text);
            List<EntityDoktor> doktorListele = LogicKlinik.IlgiliBranchDoctorListele(klinikID);
            comboBox3.DataSource = null;
            int a = 0;
            while (a < doktorListele.Count)
            {
                comboBox3.Items.Add(doktorListele[a].DoktorAdi1);
                a++;
            }
        }
    }
}