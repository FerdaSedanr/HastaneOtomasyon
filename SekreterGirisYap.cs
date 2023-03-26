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
    public partial class SekreterGirisYap : Form
    {
        public SekreterGirisYap()
        {
            InitializeComponent();
        }
        

        //GİRİŞ YAP BUTONU
        private void button1_Click(object sender, EventArgs e)
        {
            //Kullanıcının girdiği bilgileri alır ent ile vt'de karşılaştırma işlemi yapılır
            EntitySekreter ent = new EntitySekreter();
            ent.SekreterTC1 = txtSekreterTC.Text;
            ent.SekreterSifre1 = txtSekreterSifre.Text;
           
            if (txtSekreterTC.Text == "" || txtSekreterSifre.Text == "")
            {
                MessageBox.Show("TC ve Şifre alanları boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                if (LogicSekreter.LLSekreterGiris(ent) == 1)
                {
                    //eğer giriş başarılı olursa
                    MessageBox.Show("Giriş Başarılı","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SekreterEkranı sekreterEkrani = new SekreterEkranı();
                    EntitySekreter sekreter = LogicSekreter.LLSekreterBilgiTut(ent);

                    sekreterEkrani.SekreterAdi = sekreter.SekreterAdi1;
                    sekreterEkrani.SekreterSoyadi= sekreter.SekreterSoyadi1;
                    sekreterEkrani.SekreterTC = sekreter.SekreterTC1;
                    sekreterEkrani.SekreterSifre = sekreter.SekreterSifre1;
                    sekreterEkrani.Show();
                    this.Hide();
                }
                else if (LogicSekreter.LLSekreterGiris(ent) == 2)
                {
                    MessageBox.Show("Kimlik Numaranız ya da şifreniz hatalıdır.\n\n Lütfen kimlik numaranızı ya da şifrenizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
    }

        private void SekreterGirisYap_Load(object sender, EventArgs e)
        {
            txtSekreterSifre.PasswordChar = '*';
        }

        private void geriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void txtSekreterSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Text(object sender, EventArgs e)
        {
            if (txtSekreterTC.Text == "TC")
            {
                txtSekreterTC.Text = "";

                txtSekreterTC.ForeColor = Color.Black;
            }
        }

        private void txtSekreterTC_Leave(object sender, EventArgs e)
        {
            if (txtSekreterTC.Text == "")
            {
                txtSekreterTC.Text = "TC";

                txtSekreterTC.ForeColor = Color.Gray;
            }
        }

        private void txtSekreterSifre_Enter(object sender, EventArgs e)
        {
            if (txtSekreterSifre.Text == "Şifre")
            {
                txtSekreterSifre.Text = "";

                txtSekreterSifre.ForeColor = Color.Black;
            }
        }

        private void txtSekreterSifre_Leave(object sender, EventArgs e)
        {
            if (txtSekreterSifre.Text == "")
            {
                txtSekreterSifre.Text = "Şifre";

                txtSekreterSifre.ForeColor = Color.Gray;
            }
        }
    }
}
