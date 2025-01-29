using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BalonProje
{


    public partial class Giris : Form
    {

        public Giris()
        {
            InitializeComponent();
            // textBox1'deki KeyPress olayını dinler ve bu olay gerçekleştiğinde textBox1_KeyPress fonksiyonunu tetikler
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);

            // textBox1'deki TextChanged olayını dinler ve bu olay gerçekleştiğinde textBox1_TextChanged fonksiyonunu tetikler
            textBox1.TextChanged += textBox1_TextChanged;

            // SQL sorgusundan gelen verileri tutmak için DataTable oluşturulur
            DataTable dt = new DataTable();

            // Veritabanından oyuncu isimlerini ve en yüksek skorlarını çekmek için SQL sorgusu oluşturulur
            SqlDataAdapter da = new SqlDataAdapter("select top 10 PlayerName, Max(Score) As Score  from TBL_GECMISOYUNLAR group by PlayerName order by Score DESC ", bgl.baglanti());
            da.Fill(dt); // Sorgu sonucunu DataTable içerisine doldurur
            dataGridView1.DataSource = dt; // DataGridView'e verileri bağlar

        }

        // sqlbaglanti sınıfından bir nesne oluşturulur, bu nesne veritabanı bağlantısını sağlar
        sqlbaglanti bgl = new sqlbaglanti();


        private void Giris_Load(object sender, EventArgs e)
        {


        }
        // Oyuncunun daha önce oynayıp oynamadığını kontrol eden bir değişken
        bool PlayerControl = false;
        string playerName; //Oynayan oyuncunun adını alıp, gönderip geri çekmeden kullanacağız
        // "Play" butonuna basıldığında gerçekleşecek olaylar
        private void button1_Click(object sender, EventArgs e)
        {


            // Oyuncu isimlerini veritabanından seçen SQL komutu
            SqlCommand kmt3 = new SqlCommand("SELECT PlayerName FROM TBL_GECMISOYUNLAR", bgl.baglanti());

            // SQL sorgusunu çalıştırıp verileri okuyacak SqlDataReader
            SqlDataReader reader = kmt3.ExecuteReader();

            // Veritabanındaki her oyuncu ismini kontrol eden döngü
            while (reader.Read())
            {
                playerName = reader["PlayerName"].ToString().ToLower(); // Oyuncu ismi küçük harfe çevrilir

                // Kullanıcının girdiği ismin veritabanındaki isimlerle aynı olup olmadığını kontrol eder
                if (playerName == textBox1.Text.ToLower())
                {

                    PlayerControl = true; // Oyuncu bulunduğunu belirler

                    break;

                }
            }
            if (PlayerControl)
            {
                // Oyuncunun en yüksek skorunu bulmak için SQL komutu oluşturulur
                SqlCommand kmt2 = new SqlCommand("SELECT Score FROM TBL_GECMISOYUNLAR WHERE PlayerName = @PlayerName", bgl.baglanti());
                kmt2.Parameters.AddWithValue("@PlayerName", playerName); // Parametre olarak oyuncu ismini ekler
                var result = kmt2.ExecuteScalar(); // Sonuç döner (en yüksek skor)

                // Skoru integer tipine çevirir
                int maxScore = Convert.ToInt32(result);

                // Oyuncunun daha önce oynadığını ve rekor puanını gösteren bir uyarı penceresi açılır
                var dialogResult = MessageBox.Show($"{playerName} isimli oyuncu daha önce oynadı. Yaptığı rekor puan: {maxScore}. Tekrar oynamak istiyor musun?", "Uyarı", MessageBoxButtons.YesNo);

                // Eğer oyuncu 'Yes' derse oyun başlar
                if (dialogResult == DialogResult.Yes)
                {
                    Form1 fr = new Form1(); // Yeni bir oyun formu açılır
                    fr.Playername = textBox1.Text; // Oyuncu ismi yeni forma aktarılır
                    this.Hide();
                    fr.Show(); // Form açılır
                }
                else if (dialogResult == DialogResult.No) // Eğer 'No' derse TextBox temizlenir ve tekrar giriş formu gösterilir
                {
                    textBox1.Clear();
                    // Giriş formu tekrar gösterilir
                }
            }
            if (!PlayerControl) // Eğer oyuncu daha önce oynamamışsa direkt yeni oyun formu açılır
            {
                Form1 fr = new Form1();
                fr.Playername = textBox1.Text;
                this.Hide();
                fr.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayı kapat
        }

        // textBox1'in içeriği her değiştiğinde bu metod tetiklenir
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Eğer TextBox boş değilse Play butonunu gösterir
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                btnPlay.Visible = true; // Butonu görünür hale getirir
            }
            else // Eğer TextBox boşsa Play butonunu gizler
            {
                btnPlay.Visible = false; // Butonu gizler
            }
        }



        // textBox1'in KeyPress olayı: sadece harf girişine izin verir
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// Yalnızca harf girişine izin ver (backspace hariç)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // İşlemi iptal eder
            }
        }

        

        //private void btnPlay_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
