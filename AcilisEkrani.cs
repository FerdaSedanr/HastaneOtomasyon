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
    public partial class AcilisEkrani : Form
    {
        public AcilisEkrani()
        {
            InitializeComponent();
        }

        private void AcilisEkrani_Load(object sender, EventArgs e)
        {
            //Timer kullanarak giriş süresi belirlenir.
            timer1.Interval = 1500;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcilisEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            e.Cancel = true;
            timer1.Enabled = false;
            this.Hide();
            

        }
    }
}
