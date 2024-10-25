namespace flappybird
{
    public partial class Form1 : Form
    {
        // Oyun için gerekli olan değişkenleri tanımlıyoruz.
        int boruHizi = 7, yerCekimi = 15, skor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Tanımladığımız GameTimeEvent adlı metotun içine oyun çalışırken yapılacak hesaplamaların
        // ve işlemlerin yapıldığı kodları yazıyoruz.
        private void gameTimeEvent(object sender, EventArgs e)
        {
            kus.Top += yerCekimi;
            boruAsagi.Left -= boruHizi;
            boruYukarı.Left -= boruHizi;
            skorTahtasi.Text = "Skor: " + skor;

            // Borular formun sağ sınırını geçtiğinde skoru.
            if (boruAsagi.Left < -150)
            {
                boruAsagi.Left = 800;
                skor++;
            }
            if (boruYukarı.Left < -180)
            {
                boruYukarı.Left = 950;
                skor++;
            }

            // Kuş borulara, yere ya da formun üst sınırına değdiğini kontrol edip oyunu bitiriyoruz.
            if (kus.Bounds.IntersectsWith(boruAsagi.Bounds) | kus.Bounds.IntersectsWith(boruYukarı.Bounds) | kus.Bounds.IntersectsWith(yer.Bounds) | kus.Top < -25)
            {
                endGame();
            }

            // Eğer skor 5'ten büyükse boruların gelme hızını arttırıyoruz
            if (skor > 5)
            {
                boruHizi = 15;
            }
        }

        // Space tuşuna basılınca kuşun yükselmesi için yerçekimini "-15" yapıyoruz..
        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = -15;
            }
        }

        // Space tuşuna basılmayınca kuşun alçalması için yerçekimini "+15" yapıyoruz.
        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = 15;
            }
        }

        // Oyunun durması için sayacı durduruyoruz ve oyun sonunda çıkan oyun bitti yazısını görünür yapıyoruz.
        private void endGame()
        {
            oyunSayaci.Stop();
            oyunSonu.Visible = true;
        }

        private void oyunSonu_Click(object sender, EventArgs e)
        {

        }
    }
}