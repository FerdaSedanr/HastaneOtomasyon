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
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        //DALKlinikte grafiklerde oluşturduğumuz fonksiyonlar çağrıldı.
        //Kliniklerdeki hasta sayısını listeler
        private void Grafikler_Load(object sender, EventArgs e)
        {
            List<string> entityKliniks = LogicKlinik.KlinikListesiGrafik();


            foreach (var klinikListe in entityKliniks) 
            {
                EntityKlinik entityKlinikGrafik = new EntityKlinik();
                entityKlinikGrafik.KlinikAdi1= klinikListe;
                EntityKlinik klinikGrafik =  LogicKlinik.LLKlinikIDListele(entityKlinikGrafik);

                chartKlinik.Series["Klinikler"].Points.AddXY(klinikListe,LogicHasta.LLHastaSayisinaGoreKlinik(klinikGrafik.KlinikID1));
            }
            //Doktorların hasta sayısını listeler

            List<EntityDoktor> entityDoktors = LogicDoktor.LLDoktorLİstesi();

            foreach (var doktorListe in entityDoktors)
            {
                chartDoktor.Series["Doktorlar"].Points.AddXY(doktorListe.DoktorAdi1 + " " + doktorListe.DoktorSoyadi1,LogicHasta.LLHastaSayisinaGoreDoktor(doktorListe.DoktorTC1));
            }

        }
    }
}
