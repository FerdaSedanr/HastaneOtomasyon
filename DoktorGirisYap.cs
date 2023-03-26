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
    public partial class DoktorGirisYap : Form
    {
        public DoktorGirisYap()
        {
            InitializeComponent();
        }

       

        private void DoktorGirisYap_Load(object sender, EventArgs e)
        {
            txtDoktorSifre.PasswordChar = '*';
              
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void DoktorGirisYap_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Doktor giriş yap butonu
        //girilen verilerin vt'de doğrulanması
        private void button1_Click(object sender, EventArgs e)
        {
            EntityDoktor ent = new EntityDoktor();
            ent.DoktorTC1 = txtDoktorTC.Text;
            ent.DoktorSifre1 = txtDoktorSifre.Text;
            

            if (txtDoktorTC.Text == "" || txtDoktorSifre.Text == "")
            {
                MessageBox.Show("TC ve Şifre alanları boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (LogicDoktor.LLDoktorGiris(ent) == 1)
                {
                    MessageBox.Show("Giriş Başarılı");

                    DoktorEkrani doktorEkrani = new DoktorEkrani();
                    EntityDoktor doktor = LogicDoktor.LLDoktorBilgiTut(ent);

                    doktorEkrani.DoktorAdi = doktor.DoktorAdi1;
                    doktorEkrani.DoktorSoyadi = doktor.DoktorSoyadi1;
                    doktorEkrani.klinikID = doktor.KlinikID;
                    doktorEkrani.DoktorTC = doktor.DoktorTC1;


                    doktorEkrani.Show();
                    this.Hide();
                }
                else if (LogicDoktor.LLDoktorGiris(ent) == 2)
                {
                    MessageBox.Show("Kimlik Numaranız ya da şifreniz hatalıdır. Lütfen kimlik numaranızı ya da şifrenizi kontrol ediniz.");
                }
            }
        }

        private void txtDoktorTC_Enter(object sender, EventArgs e)
        {
            if (txtDoktorTC.Text == "TC")
            {
                txtDoktorTC.Text = "";

                txtDoktorTC.ForeColor = Color.Black;
            }
        }

        private void txtDoktorTC_Leave(object sender, EventArgs e)
        {
            if (txtDoktorTC.Text == "")
            {
                txtDoktorTC.Text = "TC";

                txtDoktorTC.ForeColor = Color.Gray;
            }
        }

        private void txtDoktorSifre_Enter(object sender, EventArgs e)
        {
            if (txtDoktorSifre.Text == "Şifre")
            {
                txtDoktorSifre.Text = "";

                txtDoktorSifre.ForeColor = Color.Black;
            }
        }

        private void txtDoktorSifre_Leave(object sender, EventArgs e)
        {
            if (txtDoktorSifre.Text == "")
            {
                txtDoktorSifre.Text = "Şifre";

                txtDoktorSifre.ForeColor = Color.Gray;
            }
        }
    }
}
