using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        //Sekreter giriş yap butonu
        private void button1_Click(object sender, EventArgs e)
        {
            //SekreterGirisYap sayfasına yönlendirir
            SekreterGirisYap yeni = new SekreterGirisYap();
            yeni.Show();
            this.Hide();
        }
        //Doktor giriş yap butonu
        private void button2_Click(object sender, EventArgs e)
        {
            //DoktorGirisYap sayfasına yönlendirir
            DoktorGirisYap yeni = new DoktorGirisYap();
            yeni.Show();
            this.Hide();

        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }


        private void GirisEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
