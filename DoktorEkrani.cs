using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Net.Mail;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace HastaneOtomasyon
{
    public partial class DoktorEkrani : Form
    {
        public DoktorEkrani()
        {
            InitializeComponent();
        }
        //Kullanıcı (doktor giriş yaptığında mevcut doktorun tc-ad-soyadını yazdırmak için tanımlandı )
        public string DoktorAdi, DoktorSoyadi, DoktorKlinikAdi, DoktorTC;
        public int klinikID;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorGirisYap doktorGirisYap = new DoktorGirisYap();
            doktorGirisYap.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçilen hastanın bilgilerini textBoxlara yerleştirir
            txthtc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txthadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtHsoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txthdogumtarihi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox3_cinsiyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox1_telno.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtheposta.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtKlinikid.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            richTextBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtDoktor.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //txtDoktor.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            comboBox2_Tahlil.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            comboBox3_Rntgn.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            //txtHastaTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); ;
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2_Tahlil.Enabled = true;
        }

        private void checkBox1_Tahlil_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2_Tahlil.Enabled = true;
        }

        private void checkBox2_rntgn_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3_Rntgn.Enabled = true;
        }

        private void comboBox3_Rntgn_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Röntgeler için oluşturulan comboboxlar
            //Ortopedik Muayene seçildiğinde açılan diğer itemlar
            string secilendeger = comboBox3_Rntgn.SelectedItem.ToString();
            if (secilendeger == "Ortopedik Muayene")
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

        private void geriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DoktorGirisYap doktorGirisYap = new DoktorGirisYap();
            doktorGirisYap.Show();
            this.Hide();
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuKayitlari randevuKayitlari = new RandevuKayitlari();
            randevuKayitlari.ShowDialog();
        }

        private void hastalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaGoruntuleme hastaGoruntuleme = new HastaGoruntuleme();
            hastaGoruntuleme.ShowDialog();
        }

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        //Hasta Güncelleme
        private void button4_Click(object sender, EventArgs e)
        {
            EntityHasta ent = new EntityHasta();
            ent.HastaTc = txthtc.Text;
            ent.HastaAdi = txthadi.Text;
            ent.HastaSoyadi = txtHsoyadi.Text;
            ent.DogumTarihi = txthdogumtarihi.Text;
            ent.Cinsiyeti = comboBox3_cinsiyet.Text;
            ent.Ceptel = maskedTextBox1_telno.Text;
            ent.EPosta = txtheposta.Text;
            ent.KlinikID1 = Convert.ToInt32(txtKlinikid.Text);
            ent.Teshis1 = richTextBox1.Text;
            ent.DoktorNotu1 = richTextBox2.Text;
            ent.DoktorTC1 = txtDoktor.Text;
            ent.KanTahlil1 = comboBox2_Tahlil.Text;
            ent.Rontgen1 = comboBox3_Rntgn.Text;

            LogicHasta.LLHastaGuncelle(ent);

            //Doktorun hastalarını listeler
            List<EntityHasta> hasta = LogicHasta.IlgiliHastaListesi(DoktorTC);
            dataGridView1.DataSource = hasta;
            MessageBox.Show("Güncelleme İşlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mail göderme butonu
        private void button1_Click(object sender, EventArgs e)
        {
            if (txthtc.Text == "" )
            {
                MessageBox.Show("Lütfen mail göndermek istediğiniz randevu sonucunu seçiniz");
            }
            else
            {
                try
                {
                    //EntityKlinik branch = LogicKlinik.IlgiliBranchAdiGetir(branchID);

                    MailMessage mail = new MailMessage();
                    SmtpClient istemci = new SmtpClient();
                    istemci.Credentials = new System.Net.NetworkCredential("gorselprogramlamaproje@outlook.com", "gorsel_81");
                    istemci.Port = 587;
                    istemci.Host = "smtp-mail.outlook.com";
                    istemci.EnableSsl = true;
                    mail.To.Add(txtheposta.Text);
                    mail.From = new MailAddress("gorselprogramlamaproje@outlook.com");
                   mail.Subject = "Hasta Muayene Görüşme Kaydı ";
                    mail.Body = "Doktor Adı: " + label3.Text + " " + label4.Text + "\n\nBölüm: " + label8.Text + "\n\nİstenilen Tahliller: " + comboBox2_Tahlil.Text + "\n\nDoktor Teşhisi: " + richTextBox2.Text + "\n\n ";
                    istemci.Send(mail);

                    MessageBox.Show("Mail hastaya başarı ile gönderilmiştir");
                }
                catch
                {
                    MessageBox.Show("Mail Gönderilemedi. Lütfen internet bağlantınızı kontrol ediniz");
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //pdf oluşturma butonu
        private void pdfButon_Click(object sender, EventArgs e)
        {
            if (txthtc.Text != "")
            {
                string pdfstring = "HASTA KAYITLARI " + " " + Environment.NewLine + "Doktor Adı : " + label3.Text + " " + label4.Text + Environment.NewLine + "Doktor Branşı : " + label8.Text + " "+ Environment.NewLine + " "  + Environment.NewLine + "Hasta Tc No: " + txtHastaTc.Text + Environment.NewLine
                    + "Hasta Mail Adresi: " + txtheposta.Text + Environment.NewLine + "Hasta Telefon Numarası: " + maskedTextBox1_telno.Text + Environment.NewLine + "Hasta Tahlil: " + comboBox2_Tahlil.Text + Environment.NewLine + "Hasta Röntgen: "
                    + comboBox3_Rntgn.Text + Environment.NewLine + "Teşhis Sonucu: " + richTextBox1.Text + Environment.NewLine; ;


                SaveFileDialog file = new SaveFileDialog();
                file.Filter = "PDF DOSYALARI(*.pdf) | *.pdf";
                file.Title = "PDF DOSYASI OLUŞTURMA";
                file.FileName = txthtc.Text + "Rapor" + DateTime.Now.ToString("MM/dd/yyyy");
                if (file.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileStream dosya = File.Open(file.FileName, FileMode.Create);
                    Document pdf = new Document();
                    PdfWriter.GetInstance(pdf, dosya);
                    pdf.Open();
                    pdf.AddAuthor(label3.Text+ " "+label4.Text);
                    pdf.AddCreator(label3.Text + " " + label4.Text);
                    pdf.AddTitle(txtHastaTc + " _Rapor");
                    pdf.AddSubject(txtHastaTc + "_Rapor");
                    //pdf.AddKeywords(lblHastaTcNo + "_Rapor");
                    pdf.AddCreationDate();
                    BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, "CP1254", BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.NORMAL);
                    Paragraph paragraph = new Paragraph(pdfstring, font);
                    pdf.Add(paragraph);
                    pdf.Close();
                    MessageBox.Show("Pdf başarıyla kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                    MessageBox.Show("Seçmiş olduğunuz hastanın bir raporu bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            ent.KlinikID1 = Convert.ToInt32(txtKlinikid.Text);
            ent.Teshis1 = richTextBox1.Text;
            ent.DoktorNotu1 = richTextBox2.Text;
            ent.DoktorTC1 = txtDoktor.Text;
            ent.KanTahlil1 = comboBox2_Tahlil.Text;
            ent.Rontgen1 = comboBox3_Rntgn.Text;

            LogicHasta.LLHastaEkle(ent);
            //Doktorun hastalarını listeler
            List<EntityHasta> hasta = LogicHasta.IlgiliHastaListesi(DoktorTC);
            dataGridView1.DataSource = hasta;
            MessageBox.Show("Ekleme İşlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_klinikid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntityKlinik klinik = new EntityKlinik();
            klinik.KlinikAdi1 = comboBox1.Text;
            klinik = LogicKlinik.LLKlinikIDListele(klinik);
            txtKlinikid.Text = klinik.KlinikID1.ToString();
        }

        //Hasta Silme kodları
        private void button3_Click(object sender, EventArgs e)
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

            //Doktorun hastalarını listeler
            List<EntityHasta> hasta = LogicHasta.IlgiliHastaListesi(DoktorTC);
            dataGridView1.DataSource = hasta;
            MessageBox.Show("Silme İşlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void tümHastalarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaGoruntuleme hastagoruntule = new HastaGoruntuleme();
            hastagoruntule.Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DoktorEkrani_Load(object sender, EventArgs e)
        {
            txtDoktor.Text = this.DoktorTC;

            //Giriş yapan doktorların adını soyadını ve branşını yazdırır
            EntityKlinik klinik = LogicKlinik.IlgiliKlinikAdiGetir(klinikID);
            label7.Text = this.DoktorTC;
            label3.Text = this.DoktorAdi;
            label4.Text = this.DoktorSoyadi;
            label8.Text =  klinikID.ToString();
            label8.Text = klinik.KlinikAdi1;
            txtDoktor.Text = this.DoktorTC;


            //Doktorun hastalarını listeler
            List<EntityHasta> hasta = LogicHasta.IlgiliHastaListesi(DoktorTC);
            dataGridView1.DataSource = hasta;

            List<EntityKlinik> klinik1 = LogicKlinik.KlinikListesi();
            comboBox1.DataSource = null;
            int i = 0;
            while (i < klinik1.Count)
            {
                comboBox1.Items.Add(klinik1[i].KlinikAdi1);
                i++;
            }







        }
    }
}
