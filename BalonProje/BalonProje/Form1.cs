using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // Yuvarlak butonlar oluşturmamıza yardımcı bu kütüphaneyi ekledik
using System.Data.SqlClient;

namespace BalonProje
{

    public partial class Form1 : Form
    {
        sqlbaglanti bgl = new sqlbaglanti();

        public string Playername;
        private int score = 0; //// Oyun skoru
        private int mineIndex, mineIndex2;  // Mayın olarak ayarlanan balonların indisleri
        private int balloonsClicked = 0;   // Tıklanan balon sayısı
        private const int totalBalloons = 12; // Toplam balon sayısı

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            mineIndex = rnd.Next(totalBalloons); // Rastgele bir balona mayın yerleştir
            do
            {
                mineIndex2 = rnd.Next(totalBalloons);     // Rastgele ikinci bir balona mayın yerleştir
            } while (mineIndex2 == mineIndex);     // Mayınların aynı yerde olmaması böylr bir döngü kullandık, do while kullandık çünkü önce mayın atamasını yapması gerekli sonra eşit mi değilmi kontrol edeceğiz.

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yuvarlakbuton bbtn = new yuvarlakbuton();
            bbtn.Size = new Size(80, 80); // Boyut ayarı
            bbtn.Location = new System.Drawing.Point(20, 20); // Konum ayarı
            bbtn.BackColor = Color.Red;  // Arka plan rengi
            bbtn.Tag = 0;      // Balonun indeks değeri
            bbtn.FlatAppearance.BorderSize = 0;
            bbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn.FlatAppearance.BorderColor = Color.Green;
            bbtn.Click += new EventHandler(btnn_Click);            // Tıklama olayını tanımla
            this.Controls.Add(bbtn);                        // Form üzerine ekle

            yuvarlakbuton bbtn2 = new yuvarlakbuton();
            bbtn2.Size = new Size(80, 80);
            bbtn2.Location = new System.Drawing.Point(150, 20);
            bbtn2.BackColor = Color.Blue;
            bbtn2.Tag = 1;
            bbtn2.FlatAppearance.BorderSize = 0;
            bbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn2.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn2);

            yuvarlakbuton bbtn3 = new yuvarlakbuton();
            bbtn3.Size = new Size(80, 80);
            bbtn3.Location = new System.Drawing.Point(280, 20);
            bbtn3.BackColor = Color.Yellow;
            bbtn3.Tag = 2;
            bbtn3.FlatAppearance.BorderSize = 0;
            bbtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn3.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn3);

            yuvarlakbuton bbtn4 = new yuvarlakbuton();
            bbtn4.Size = new Size(80, 80);
            bbtn4.Location = new System.Drawing.Point(410, 20);
            bbtn4.BackColor = Color.Green;
            bbtn4.Tag = 3;
            bbtn4.FlatAppearance.BorderSize = 0;
            bbtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn4.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn4);

            yuvarlakbuton bbtn5 = new yuvarlakbuton();
            bbtn5.Size = new Size(80, 80);
            bbtn5.Location = new System.Drawing.Point(20, 150);
            bbtn5.BackColor = Color.Orange;
            bbtn5.Tag = 4;
            bbtn5.FlatAppearance.BorderSize = 0;
            bbtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn5.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn5);

            yuvarlakbuton bbtn6 = new yuvarlakbuton();
            bbtn6.Size = new Size(80, 80);
            bbtn6.Location = new System.Drawing.Point(150, 150);
            bbtn6.BackColor = Color.Purple;
            bbtn6.Tag = 5;
            bbtn6.FlatAppearance.BorderSize = 0;
            bbtn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn6.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn6);

            yuvarlakbuton bbtn7 = new yuvarlakbuton();
            bbtn7.Size = new Size(80, 80);
            bbtn7.Location = new System.Drawing.Point(280, 150);
            bbtn7.BackColor = Color.Cyan;
            bbtn7.Tag = 6;
            bbtn7.FlatAppearance.BorderSize = 0;
            bbtn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn7.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn7);

            yuvarlakbuton bbtn8 = new yuvarlakbuton();
            bbtn8.Size = new Size(80, 80);
            bbtn8.Location = new System.Drawing.Point(410, 150);
            bbtn8.BackColor = Color.Pink;
            bbtn8.Tag = 7;
            bbtn8.FlatAppearance.BorderSize = 0;
            bbtn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn8.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn8);

            yuvarlakbuton bbtn9 = new yuvarlakbuton();
            bbtn9.Size = new Size(80, 80);
            bbtn9.Location = new System.Drawing.Point(20, 280);
            bbtn9.BackColor = Color.Brown;
            bbtn9.Tag = 8;
            bbtn9.FlatAppearance.BorderSize = 0;
            bbtn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn9.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn9);

            yuvarlakbuton bbtn10 = new yuvarlakbuton();
            bbtn10.Size = new Size(80, 80);
            bbtn10.Location = new System.Drawing.Point(150, 280);
            bbtn10.BackColor = Color.Lime;
            bbtn10.Tag = 9;
            bbtn10.FlatAppearance.BorderSize = 0;
            bbtn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn10.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn10);

            yuvarlakbuton bbtn11 = new yuvarlakbuton();
            bbtn11.Size = new Size(80, 80);
            bbtn11.Location = new System.Drawing.Point(280, 280);
            bbtn11.BackColor = Color.Magenta;
            bbtn11.Tag = 10;
            bbtn11.FlatAppearance.BorderSize = 0;
            bbtn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn11.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn11);

            yuvarlakbuton bbtn12 = new yuvarlakbuton();
            bbtn12.Size = new Size(80, 80);
            bbtn12.Location = new System.Drawing.Point(410, 280);
            bbtn12.BackColor = Color.DarkSlateGray;
            bbtn12.Tag = 11;
            bbtn12.FlatAppearance.BorderSize = 0;
            bbtn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bbtn12.Click += new EventHandler(btnn_Click);
            this.Controls.Add(bbtn12);

            Button randomColorButton = new Button();
            randomColorButton.Size = new Size(103, 100);
            randomColorButton.Location = new Point(550, 120);
            randomColorButton.BackColor = Color.Silver;
            randomColorButton.ForeColor = Color.WhiteSmoke;
            randomColorButton.Text = "RENK DEĞİŞTİR";
            randomColorButton.Tag = 12;
            randomColorButton.Click += new EventHandler(RandomColorButton_Click);
            this.Controls.Add(randomColorButton);
            //randomColorButton.BackgroundImage = System.Drawing.Image.FromFile();

        }

        private void btnn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; // Tıklanan butonu alma
            int index = (int)clickedButton.Tag;   // Tıklanan butonun indexsini alma

            if (index == mineIndex || index == mineIndex2)  // Mayınlı balonların index kontrolü
            {

                // Mayınlı balonların rengini kırmızı yapma
                foreach (Control ctrl in this.Controls)  // Form üzerindeki bütün nesneleri ctrl içine alıyoruz
                {
                    if (ctrl is Button button) //Döngü içerisinde kontrol ediyoruz eğer butonsa, if yapısı içine gir
                    {
                        int? indexm = button.Tag as int?;  //int?, nullable int anlamına gelir. Yani bir int? değeri hem bir int değeri içerebilir, hem de null olabilir.
                                                           //as operatörü, bir nesneyi belirli bir türe dönüştürmeye çalışır. Eğer dönüştürülemezse, sonuç null olur.
                                                           //Burada button.Tag, object türündedir (çünkü Tag özelliği herhangi bir türde veri tutabilir).
                                                           //button.Tag'in bir int olup olmadığını kontrol eder. Eğer Tag bir int ise, bu değeri int? türüne dönüştürerek indexm'e atar.

                        //indexm.HasValue, indexm değişkeninin bir değere sahip olup olmadığını kontrol eder.Eğer indexm null değilse, kontrolün ikinci kısmı değerlendirilir.
                        if (indexm.HasValue && (indexm == mineIndex || indexm == mineIndex2))
                        {
                            button.BackColor = Color.Red; // Mayınlı balonları kırmızıya boyar
                            button.Text = "💣"; // Butona mayın sembolü eklemek

                        }
                    }
                }

                SqlCommand kmt = new SqlCommand("insert into TBL_GECMISOYUNLAR (PlayerName,Score) values (@p1,@p2)", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", Playername);
                kmt.Parameters.AddWithValue("@p2", score);
                kmt.ExecuteNonQuery();
                bgl.baglanti().Close();

                ShowEndGameMessage();   // Oyunu bitirme mesajı göster  
            }
            else
            {
                score += 10;     // Skor artırma
                clickedButton.Visible = false;   // Tıklanan balonu görünmez yap
                balloonsClicked++;  // Tıklanan balon sayısını artır
                if (balloonsClicked == totalBalloons - 2)   // Eğer tüm balonlar tıklandıysa
                {
                    MessageBox.Show($"TEBRİKLER MAYINA BASMADAN BÜTÜN MALONLARI PATLATTINIZ. \n PUANINIZ : {score}");

                    SqlCommand kmt = new SqlCommand("insert into TBL_GECMISOYUNLAR (PlayerName,Score) values (@p1,@p2)", bgl.baglanti());
                    kmt.Parameters.AddWithValue("@p1", Playername);
                    kmt.Parameters.AddWithValue("@p2", score);
                    kmt.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    ShowEndGameMessage();   // Oyunu bitirme mesajı göster  

                }
            }
        }


        // Renkleri rastgele değiştirme işlemi
        private void RandomColorButton_Click(object sender, EventArgs e)
        {
           
            Random rnd = new Random();
            foreach (Control ctrl in this.Controls)  // Tüm form kontrollerini dolaş
            {
                if (ctrl is Button && ctrl != sender && (int)ctrl.Tag != 12)  // Eğer kontrol butonsa ve renk değiştirme butonu değilse
                {
                    ctrl.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));  // Rastgele renk atama
                }
            }

        }


        public void ShowEndGameMessage()
        {

            DialogResult result = MessageBox.Show($"Oyun bitti! Puanınız: {score} \nDevam etmek istiyor musunuz?", "Oyun Sonu", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Oyun sonu mesajı
            if (result == DialogResult.Yes)  // Eğer "Evet" seçilirse
            {
                ResetGame(); // Oyunu yeniden başlat
            }
            else if (result == DialogResult.No)  // Eğer "Hayır" seçilirse
            {
                ResetGame();
                //// Giriş formunu oluştur
                Giris fr = new Giris();
                fr.Show();
                this.Hide();
            }
        }

        // Oyunu sıfırlama işlemi
        private void ResetGame()
        {

            // Mayınlı balonları sıfırlama
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button button)
                {
                    int? indexm = button.Tag as int?;
                    if (indexm.HasValue && (indexm == mineIndex || indexm == mineIndex2))
                    {
                        RandomColorButton_Click(this, EventArgs.Empty);   //Mayın butonlarına rasgele renk atama
                     

                        button.Text = " "; // Butondaki mayın sembolünü silmek

                    }
                }
            }
            score = 0;
            balloonsClicked = 0;
            Random rnd = new Random();
            mineIndex = rnd.Next(totalBalloons);  // Yeni mayınlı balon ayarla
            do
            {
                Random rnd2 = new Random();
                mineIndex2 = rnd2.Next(1, 12);
            } while (mineIndex2 == mineIndex); ;



            foreach (Control ctrl in this.Controls) // Tüm form kontrollerini dolaş
            {
                if (ctrl is Button) // Eğer kontrol bir butonsa
                {
                    ctrl.Visible = true;  // Balonları yeniden görünür yap
                }
            }
        }
    }
}

public class yuvarlakbuton : Button
{
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        GraphicsPath gp = new GraphicsPath();
        gp.AddEllipse(new Rectangle(Point.Empty, this.Size));   // Butonun şeklini yuvarlak yap
        this.Region = new Region(gp); // Bölgeyi belirle
    }
}

