using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace HastaneOtomasyon
{
    public partial class RandevuKayitlari : Form
    {
        public RandevuKayitlari()
        {
            InitializeComponent();
        }


        private void RandevuKayitlari_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
            //Form yüklendiğinde otomatik tüm hastaları getirir
            List<EntityRandevu> randevu = LogicRandevu.LLRandevuİstesi();
            dataGridView1.DataSource = randevu;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtrandevuID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtdoktortc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtklinikid.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();  
            //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            txtHastaAdi.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtHastaSoyadi.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txteposta.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        //Randevu silme işlemi
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                EntityRandevu ent = new EntityRandevu();
                ent.RandevuID1 = int.Parse(txtrandevuID.Text);
                LogicRandevu.LLRandevuSil(Convert.ToInt32(ent.RandevuID1).ToString());
                //TextBox içini temizler
                txtrandevuID.Text = "";
                txtdoktortc.Text = "";
                txtklinikid.Text = "";
                dateTimePicker1.Text = "";
                txttc.Text = "";
                //Form yüklendiğinde otomatik tüm hastaları getirir
                List<EntityRandevu> hasta = LogicRandevu.LLRandevuİstesi();
                dataGridView1.DataSource = hasta;
            }
            catch
            {
                MessageBox.Show("Silme işlemi gerçekleştirilmedi.\n\n Tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Randevu güncelleme butonu
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                EntityRandevu ent = new EntityRandevu();
                ent.RandevuID1 = Convert.ToInt32(txtrandevuID.Text);
                ent.DoktorTC1 = txtdoktortc.Text;
                ent.KlinikID1 = Convert.ToInt32(txtklinikid.Text); ;
                ent.HastaTC1 = txttc.Text;
                ent.Date = dateTimePicker1.Value;


                LogicRandevu.LLRandevuGuncelle(ent);

                List<EntityRandevu> randevu = LogicRandevu.LLRandevuİstesi();
                dataGridView1.DataSource = randevu;
            }
            catch
            {
                MessageBox.Show("Güncelleme işlemi gerçekleştirilmedi.\n\n Tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtrandevuID.Text == "")
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
                    mail.To.Add(txteposta.Text);
                    mail.From = new MailAddress("gorselprogramlamaproje@outlook.com");
                    mail.Subject = "Hasta Randevu Bilgilendirme Maili ";
                    mail.Body = "Sayın ," + txtHastaAdi.Text + " " + txtHastaSoyadi.Text + " " + dateTimePicker1.Value + " tarihinde " + " hastanemizde randevunuz bulunmaktadır...  ";
                    istemci.Send(mail);

                    MessageBox.Show("Mail hastaya başarı ile gönderilmiştir");
                }
                catch
                {
                    MessageBox.Show("Mail Gönderilemedi. Lütfen internet bağlantınızı kontrol ediniz");
                }
            }
        }
    }
}
