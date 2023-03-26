
namespace HastaneOtomasyon
{
    partial class HastaGoruntuleme
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGoruntuleme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHastaTc = new System.Windows.Forms.Label();
            this.txthtc = new System.Windows.Forms.TextBox();
            this.txthadi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.Label();
            this.txtHsoyadi = new System.Windows.Forms.TextBox();
            this.txtHastaSoyadi = new System.Windows.Forms.Label();
            this.txthdogumtarihi = new System.Windows.Forms.TextBox();
            this.txtDogumTarihi = new System.Windows.Forms.Label();
            this.txtCinsiyet = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.Label();
            this.txtheposta = new System.Windows.Forms.TextBox();
            this.txteposta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.txtKlinik = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.geriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1_Tahlil = new System.Windows.Forms.CheckBox();
            this.comboBox2_Tahlil = new System.Windows.Forms.ComboBox();
            this.checkBox2_rntgn = new System.Windows.Forms.CheckBox();
            this.comboBox3_Rntgn = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pdfButon = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDoktor = new System.Windows.Forms.TextBox();
            this.comboBox3_cinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1_telno = new System.Windows.Forms.MaskedTextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 446);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(153, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHastaTc
            // 
            this.txtHastaTc.AutoSize = true;
            this.txtHastaTc.Location = new System.Drawing.Point(39, 78);
            this.txtHastaTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHastaTc.Name = "txtHastaTc";
            this.txtHastaTc.Size = new System.Drawing.Size(71, 20);
            this.txtHastaTc.TabIndex = 4;
            this.txtHastaTc.Text = "Hasta TC";
            this.txtHastaTc.Click += new System.EventHandler(this.label1_Click);
            // 
            // txthtc
            // 
            this.txthtc.Location = new System.Drawing.Point(152, 75);
            this.txthtc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txthtc.MaxLength = 11;
            this.txthtc.Name = "txthtc";
            this.txthtc.Size = new System.Drawing.Size(150, 26);
            this.txthtc.TabIndex = 5;
            // 
            // txthadi
            // 
            this.txthadi.Location = new System.Drawing.Point(152, 117);
            this.txthadi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txthadi.Name = "txthadi";
            this.txthadi.Size = new System.Drawing.Size(150, 26);
            this.txthadi.TabIndex = 7;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.AutoSize = true;
            this.txtHastaAdi.Location = new System.Drawing.Point(42, 124);
            this.txtHastaAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(78, 20);
            this.txtHastaAdi.TabIndex = 6;
            this.txtHastaAdi.Text = "Hasta Adı";
            // 
            // txtHsoyadi
            // 
            this.txtHsoyadi.Location = new System.Drawing.Point(152, 159);
            this.txtHsoyadi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHsoyadi.Name = "txtHsoyadi";
            this.txtHsoyadi.Size = new System.Drawing.Size(150, 26);
            this.txtHsoyadi.TabIndex = 9;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.AutoSize = true;
            this.txtHastaSoyadi.Location = new System.Drawing.Point(36, 165);
            this.txtHastaSoyadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(102, 20);
            this.txtHastaSoyadi.TabIndex = 8;
            this.txtHastaSoyadi.Text = "Hasta Soyadı";
            // 
            // txthdogumtarihi
            // 
            this.txthdogumtarihi.Location = new System.Drawing.Point(152, 208);
            this.txthdogumtarihi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txthdogumtarihi.Name = "txthdogumtarihi";
            this.txthdogumtarihi.Size = new System.Drawing.Size(150, 26);
            this.txthdogumtarihi.TabIndex = 11;
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.AutoSize = true;
            this.txtDogumTarihi.Location = new System.Drawing.Point(36, 216);
            this.txtDogumTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(101, 20);
            this.txtDogumTarihi.TabIndex = 10;
            this.txtDogumTarihi.Text = "Doğum Tarihi";
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.AutoSize = true;
            this.txtCinsiyet.Location = new System.Drawing.Point(42, 262);
            this.txtCinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(68, 20);
            this.txtCinsiyet.TabIndex = 12;
            this.txtCinsiyet.Text = "Cinsiyeti";
            // 
            // txtTelNo
            // 
            this.txtTelNo.AutoSize = true;
            this.txtTelNo.Location = new System.Drawing.Point(42, 303);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(86, 20);
            this.txtTelNo.TabIndex = 14;
            this.txtTelNo.Text = "Telefon No";
            // 
            // txtheposta
            // 
            this.txtheposta.Location = new System.Drawing.Point(420, 75);
            this.txtheposta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtheposta.Name = "txtheposta";
            this.txtheposta.Size = new System.Drawing.Size(150, 26);
            this.txtheposta.TabIndex = 17;
            // 
            // txteposta
            // 
            this.txteposta.AutoSize = true;
            this.txteposta.Location = new System.Drawing.Point(316, 78);
            this.txteposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txteposta.Name = "txteposta";
            this.txteposta.Size = new System.Drawing.Size(62, 20);
            this.txteposta.TabIndex = 16;
            this.txteposta.Text = "E-Posta";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(310, 370);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(486, 370);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(638, 370);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 39);
            this.button4.TabIndex = 20;
            this.button4.Text = "Güncelle";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 120);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Klinik Adı\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Klinik Id";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(599, 178);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 123);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Teşhis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(958, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "NOT";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(962, 87);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(246, 214);
            this.richTextBox2.TabIndex = 31;
            this.richTextBox2.Text = "";
            // 
            // txtKlinik
            // 
            this.txtKlinik.Enabled = false;
            this.txtKlinik.Location = new System.Drawing.Point(420, 165);
            this.txtKlinik.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKlinik.Name = "txtKlinik";
            this.txtKlinik.Size = new System.Drawing.Size(150, 26);
            this.txtKlinik.TabIndex = 32;
            this.txtKlinik.TextChanged += new System.EventHandler(this.txtKlinik_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 31);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // geriToolStripMenuItem
            // 
            this.geriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("geriToolStripMenuItem.Image")));
            this.geriToolStripMenuItem.Name = "geriToolStripMenuItem";
            this.geriToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.geriToolStripMenuItem.Text = "Geri";
            this.geriToolStripMenuItem.Click += new System.EventHandler(this.geriToolStripMenuItem_Click_1);
            // 
            // checkBox1_Tahlil
            // 
            this.checkBox1_Tahlil.AutoSize = true;
            this.checkBox1_Tahlil.Location = new System.Drawing.Point(599, 57);
            this.checkBox1_Tahlil.Name = "checkBox1_Tahlil";
            this.checkBox1_Tahlil.Size = new System.Drawing.Size(94, 24);
            this.checkBox1_Tahlil.TabIndex = 34;
            this.checkBox1_Tahlil.Text = "Tahlil İste";
            this.checkBox1_Tahlil.UseVisualStyleBackColor = true;
            this.checkBox1_Tahlil.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox2_Tahlil
            // 
            this.comboBox2_Tahlil.Enabled = false;
            this.comboBox2_Tahlil.FormattingEnabled = true;
            this.comboBox2_Tahlil.Items.AddRange(new object[] {
            "Kan ",
            "Biyokimya",
            "Kan-Hormon",
            "İdrar",
            "Tükürük"});
            this.comboBox2_Tahlil.Location = new System.Drawing.Point(599, 87);
            this.comboBox2_Tahlil.Name = "comboBox2_Tahlil";
            this.comboBox2_Tahlil.Size = new System.Drawing.Size(133, 28);
            this.comboBox2_Tahlil.TabIndex = 35;
            // 
            // checkBox2_rntgn
            // 
            this.checkBox2_rntgn.AutoSize = true;
            this.checkBox2_rntgn.Location = new System.Drawing.Point(792, 57);
            this.checkBox2_rntgn.Name = "checkBox2_rntgn";
            this.checkBox2_rntgn.Size = new System.Drawing.Size(123, 24);
            this.checkBox2_rntgn.TabIndex = 36;
            this.checkBox2_rntgn.Text = "Röntgen İste";
            this.checkBox2_rntgn.UseVisualStyleBackColor = true;
            this.checkBox2_rntgn.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox3_Rntgn
            // 
            this.comboBox3_Rntgn.Enabled = false;
            this.comboBox3_Rntgn.FormattingEnabled = true;
            this.comboBox3_Rntgn.Items.AddRange(new object[] {
            "Akciğer",
            "Tomogrofi",
            "Ultrason",
            "Ortopedik Muayene"});
            this.comboBox3_Rntgn.Location = new System.Drawing.Point(792, 87);
            this.comboBox3_Rntgn.Name = "comboBox3_Rntgn";
            this.comboBox3_Rntgn.Size = new System.Drawing.Size(133, 28);
            this.comboBox3_Rntgn.TabIndex = 37;
            this.comboBox3_Rntgn.SelectedIndexChanged += new System.EventHandler(this.comboBox3_Rntgn_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(792, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 28);
            this.comboBox2.TabIndex = 38;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pdfButon
            // 
            this.pdfButon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pdfButon.Image = ((System.Drawing.Image)(resources.GetObject("pdfButon.Image")));
            this.pdfButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pdfButon.Location = new System.Drawing.Point(792, 370);
            this.pdfButon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdfButon.Name = "pdfButon";
            this.pdfButon.Size = new System.Drawing.Size(117, 39);
            this.pdfButon.TabIndex = 39;
            this.pdfButon.Text = "Pdf Oluştur";
            this.pdfButon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pdfButon.UseVisualStyleBackColor = false;
            this.pdfButon.Click += new System.EventHandler(this.pdfButon_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 254);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 20);
            this.label14.TabIndex = 75;
            this.label14.Text = "Doktor TC";
            // 
            // txtDoktor
            // 
            this.txtDoktor.Location = new System.Drawing.Point(420, 254);
            this.txtDoktor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDoktor.Name = "txtDoktor";
            this.txtDoktor.Size = new System.Drawing.Size(150, 26);
            this.txtDoktor.TabIndex = 74;
            this.txtDoktor.TextChanged += new System.EventHandler(this.txtDoktor_TextChanged);
            // 
            // comboBox3_cinsiyet
            // 
            this.comboBox3_cinsiyet.FormattingEnabled = true;
            this.comboBox3_cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Belirtmek İstemiyor"});
            this.comboBox3_cinsiyet.Location = new System.Drawing.Point(152, 254);
            this.comboBox3_cinsiyet.Name = "comboBox3_cinsiyet";
            this.comboBox3_cinsiyet.Size = new System.Drawing.Size(150, 28);
            this.comboBox3_cinsiyet.TabIndex = 80;
            // 
            // maskedTextBox1_telno
            // 
            this.maskedTextBox1_telno.Location = new System.Drawing.Point(152, 297);
            this.maskedTextBox1_telno.Mask = "(999) 000-0000";
            this.maskedTextBox1_telno.Name = "maskedTextBox1_telno";
            this.maskedTextBox1_telno.Size = new System.Drawing.Size(150, 26);
            this.maskedTextBox1_telno.TabIndex = 81;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(420, 208);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 28);
            this.comboBox3.TabIndex = 82;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Doktor Adı";
            // 
            // HastaGoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1347, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.maskedTextBox1_telno);
            this.Controls.Add(this.comboBox3_cinsiyet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDoktor);
            this.Controls.Add(this.pdfButon);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3_Rntgn);
            this.Controls.Add(this.checkBox2_rntgn);
            this.Controls.Add(this.comboBox2_Tahlil);
            this.Controls.Add(this.checkBox1_Tahlil);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtKlinik);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtheposta);
            this.Controls.Add(this.txteposta);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtCinsiyet);
            this.Controls.Add(this.txthdogumtarihi);
            this.Controls.Add(this.txtDogumTarihi);
            this.Controls.Add(this.txtHsoyadi);
            this.Controls.Add(this.txtHastaSoyadi);
            this.Controls.Add(this.txthadi);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.txthtc);
            this.Controls.Add(this.txtHastaTc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "HastaGoruntuleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Hastalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.HastaGoruntuleme_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtHastaTc;
        private System.Windows.Forms.TextBox txthtc;
        private System.Windows.Forms.TextBox txthadi;
        private System.Windows.Forms.Label txtHastaAdi;
        private System.Windows.Forms.TextBox txtHsoyadi;
        private System.Windows.Forms.Label txtHastaSoyadi;
        private System.Windows.Forms.TextBox txthdogumtarihi;
        private System.Windows.Forms.Label txtDogumTarihi;
        private System.Windows.Forms.Label txtCinsiyet;
        private System.Windows.Forms.Label txtTelNo;
        private System.Windows.Forms.TextBox txtheposta;
        private System.Windows.Forms.Label txteposta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox txtKlinik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem geriToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1_Tahlil;
        private System.Windows.Forms.ComboBox comboBox2_Tahlil;
        private System.Windows.Forms.CheckBox checkBox2_rntgn;
        private System.Windows.Forms.ComboBox comboBox3_Rntgn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button pdfButon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDoktor;
        private System.Windows.Forms.ComboBox comboBox3_cinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1_telno;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
    }
}

