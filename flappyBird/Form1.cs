using System;
using System.Drawing;
using System.Windows.Forms;

namespace flappyBird
{
    public partial class Form1 : Form
    {
        int boruHizi = 10;
        int yerCekimi = 8;
        int skor = 0;
        bool gameOver = true;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(gamekeyisdown);
            this.KeyUp += new KeyEventHandler(gamekeyisup);
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            // Kuşun hareketi
            flappyBird.Top += yerCekimi;

            // Borular aynı anda hareket ediyor
            boruAlt.Left -= boruHizi;
            boruUst.Left -= boruHizi;

            skorText.Text = "Skor: " + skor;

            // Eğer borular ekran dışına çıktıysa, ikisini aynı anda resetle
            if (boruAlt.Left < -150)
            {
                int gap = 200; // üst ve alt boru arasındaki boşluk (geçiş yeri)
                int boruAltY = rnd.Next(250, 450); // alt borunun yüksekliği

                // Alt boru
                boruAlt.Left = 800;
                boruAlt.Top = boruAltY;

                // Üst boru, alt borunun tam üstüne gap mesafesi bırakılarak yerleştiriliyor
                boruUst.Left = 800;
                boruUst.Top = boruAltY - boruUst.Height - gap;

                skor++;
            }
            // Kuşun hitbox ı
            Rectangle birdHitbox = new Rectangle(
                flappyBird.Left + 5,
                flappyBird.Top + 5,
                flappyBird.Width - 10,
                flappyBird.Height - 10
            );

            

            // Çarpışma kontrolü
            if (birdHitbox.IntersectsWith(boruAlt.Bounds) ||
                birdHitbox.IntersectsWith(boruUst.Bounds) ||
                flappyBird.Top < -25 ||
                birdHitbox.IntersectsWith(yer.Bounds))
            {
                endGame();
            }

            // Zorluk artışı
            if (skor > 2) boruHizi = 12;
            if (skor > 5) boruHizi = 16;
            if (skor > 10) boruHizi = 23;
            if (skor > 15) boruHizi = 30;
            if (skor > 20) boruHizi = 40;
            if (skor > 30) boruHizi = 50;
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (gameOver)
                {
                    resetGame();
                    gameOver = false;
                }
                yerCekimi = -8;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = 8;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            skorText.Text += "  - Oyun Bitti!!!";
            gameOver = true;
            btnStart.Visible = true;
        }

        private void resetGame()
        {
            skor = 0;
            boruHizi = 10;
            yerCekimi = 8;

            skorText.Text = "Skor: 0";

            flappyBird.Top = 200;
            flappyBird.Left = 50;

            int gap = 200;
            int boruAltY = rnd.Next(250, 450);

            boruAlt.Left = 800;
            boruAlt.Top = boruAltY;

            boruUst.Left = 800;
            boruUst.Top = boruAltY - boruUst.Height - gap;

            btnStart.Visible = false;
            gameTimer.Start();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { resetGame(); }
        private void Form1_Load(object sender, EventArgs e)
        {
            gameTimer.Stop();
            btnStart.Visible = false;
            skorText.Text = "Skor: 0";
            this.KeyPreview = true;

            flappyBird.Top = 200;
            flappyBird.Left = 50;

            int gap = 200;
            int boruAltY = rnd.Next(250, 450);

            boruAlt.Left = 800;
            boruAlt.Top = boruAltY;

            boruUst.Left = 800;
            boruUst.Top = boruAltY - boruUst.Height - gap;
        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }

        private void yer_Click(object sender, EventArgs e)
        {

        }
    }
}