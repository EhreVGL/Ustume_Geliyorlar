using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ustume_Geliyorlar
{
    public partial class Form1 : Form
    {
        PictureBox player = new PictureBox();
        bool goup; // oyuncunun ekranda yukarı gitmesi için kullanılacak
        bool godown; // oyuncunun ekranda aşağı gitmesi için kullanılacak
        bool goleft; // oyuncunun ekranda sola gitmesi için kullanılacak
        bool goright; // oyuncunun ekranda sağa gitmesi için kullanılacak
        string facing = "up"; // mermiyi yonlendirmek icin kullanilacak.
        int speed = 10; // oyuncu hızı.
        int ammo = 10; // oyuncunun baslangicta sahip oldugu mermi
        int botSpeed = 3; // bot hızı.
        int botSayisi = 1; // oyunda kaç bot olduğunu belirleyen degisken.
        int can = 6;    // can değerini tutan int.
        int score = 0; // oyuncu skoru.
        bool gameOver = false; // sanirim bir tur virus. true olursa oyun bitiyor. :((
        int total_ammo = 0; // toplam alınan cephane miktarını tutar.
        int total_shoot = 0; // toplam edilen ateş sayısını tutar.
        int sure = 0;   // toplam geçen süreyi tutar.
        Random rnd = new Random(); //kafasi biraz karisik
        Bitmap[] myImages = new Bitmap[8];
        PictureBox[] kalpler = new PictureBox[6];


        public Form1()
        {
            InitializeComponent();
            myImages[0] = Properties.Resources.bot;
            myImages[1] = Properties.Resources.bullet;
            myImages[2] = Properties.Resources.player;
            myImages[3] = Properties.Resources.playerasagi;
            myImages[4] = Properties.Resources.playersag;
            myImages[5] = Properties.Resources.playersol;
            myImages[6] = Properties.Resources.playeryukari;
            myImages[7] = Properties.Resources.ammo;

            kalpler[0] = kalp1;
            kalpler[1] = kalp2;
            kalpler[2] = kalp3;
            kalpler[3] = kalp4;
            kalpler[4] = kalp5;
            kalpler[5] = kalp6;
        }

        private void gameEngine(object sender, EventArgs e)
        {
            lblammo.Text = "Ammo: " + ammo;
            lblskor.Text = "Skor: " + score;

            if (goleft && player.Left > 0)
            {
                player.Left -= speed;
                // sola hareket edildiyse ve oyuncu ekranın soluna dayanmadıysa sola hareket ettir.
            }
            if (goright && player.Left + player.Width < pnloyun.Width - 10)
            {
                player.Left += speed;
                // saga hareket edildiyse ve oyuncu ekranın sagina dayanmadıysa saga hareket ettir.
            }
            if (goup && player.Top > 40)
            {
                player.Top -= speed;
                // yukari hareket edildiyse ve oyuncu ekranın ustune dayanmadıysa yukari hareket ettir.
            }

            if (godown && player.Top + player.Height < pnloyun.Height - 10)
            {
                player.Top += speed;
                // asagi hareket edildiyse ve oyuncu ekranın altina dayanmadıysa asagi hareket ettir.
            }

            foreach (Control x in pnloyun.Controls)
            {
                // Eger "ammo" tagli bir PictureBox varsa 
                if (x is PictureBox && x.Tag == "ammo")
                {
                    // "ammo" tagli PictureBox player ile çakıştıysa
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        //PictureBox'ı kaldır ve ammo'yu 5 arttır.
                        pnloyun.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                        total_ammo++;
                    }
                }

                // bulletler alandan çıktıysa onları silecek.
                if (x is PictureBox && x.Tag == "bullet")
                {
                    // Oyun panelinin 4 kenarından birinden çıktıysa mermiyi sil.
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > pnloyun.Width || ((PictureBox)x).Top < 1 || ((PictureBox)x).Top > pnloyun.Height)
                    {
                        pnloyun.Controls.Remove((PictureBox)x);
                        ((PictureBox)x).Dispose();
                    }
                }

                // Eger "bot" tagli bir PictureBox varsa 
                if (x is PictureBox && x.Tag == "bot")
                {
                    // "bot" tagli PictureBox player ile çakıştıysa
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        pnloyun.Controls.Remove((PictureBox)x);
                        x.Dispose();
                        makeBots();
                        can--;
                        kalpler[can].Visible = false;
                        if(can == 0)
                        {
                            OyunBitti();
                            timer1.Enabled = false;
                            zaman.Enabled = false;
                        }
                    }

                    // botlari oyuncuya dogru yurutme.
                    if (((PictureBox)x).Left > player.Left)
                    {
                        ((PictureBox)x).Left -= botSpeed;
                    }
                    if (((PictureBox)x).Left < player.Left)
                    {
                        ((PictureBox)x).Left += botSpeed;
                    }
                    if (((PictureBox)x).Top > player.Top)
                    {
                        ((PictureBox)x).Top -= botSpeed;
                    }
                    if (((PictureBox)x).Top < player.Top)
                    {
                        ((PictureBox)x).Top += botSpeed;
                    }
                }

                /*
                 * foreach ile bullet mermiyi vurursa kısmı eklenecek.
                 */
                foreach(Control y in pnloyun.Controls)
                {
                    if ((y is PictureBox && y.Tag == "bullet") && (x is PictureBox && x.Tag == "bot"))
                    {
                        if (x.Bounds.IntersectsWith(y.Bounds))
                        {
                            score++;
                            pnloyun.Controls.Remove((PictureBox)y);
                            y.Dispose();
                            pnloyun.Controls.Remove((PictureBox)x);
                            x.Dispose();
                            makeBots();

                            if (score % 3 == 0 && score > 0)
                            {
                                DropAmmo();
                            }
                            // Skor her onun katı olduğunda bot sayısı 1 artsın.
                            if (score / 5 == botSayisi)
                            {
                                botSayisi++;
                                makeBots();
                            }
                        }
                    }
                }
            }
        }

        private void DropAmmo()
        {
            //Cephane görüntüsü yaratma.
            PictureBox ammo = new PictureBox()
            {
                /***************************************************************************************************************************/ // İMAGE DEİS
                Image = myImages[7],                    // PictureBox görseli
                SizeMode = PictureBoxSizeMode.AutoSize, // PictureBox boyutunu auto-size yapıyor.
                Left = rnd.Next(10, pnloyun.Width),     // PictuareBox'ın Location.X'ini oyun içerisinde random bir yere atıyor.
                Top = rnd.Next(50, pnloyun.Height),     // PictureBox'ın Location.Y'sini oyun içerisinde random bir yere atıyor.
                Tag = "ammo",                           // PictureBox'ın Tag'ini "ammo" olarak ayarlıyor.
            };
            pnloyun.Controls.Add(ammo);         // ammo'yu pnloyun'a ekliyor.
            ammo.BringToFront();                // ammo'yu en öne çıkartıyor.
            player.BringToFront();              // player'ı en öne çıkartıyor.
        }

        private void shoot(string direct)
        {
            total_shoot++;
            // Mermi görüntüsü yaratma.
            Bullet shoot = new Bullet()
            {
                bulletimage = myImages[1],
                direction = direct,                                 // Merminin ilerleyeceği yonu belirtir.
                bulletleft = player.Left + (player.Width / 2),      // Merminin Location.X'ini belirtir.
                bullettop = player.Top + (player.Height / 2),       // Merminin Location.Y'sini belirtir.
            };
            shoot.bulletTimer_Tick(pnloyun);       //Mermiyi ilerleten fonksiyonu belirtir.
        }

        private void makeBots()
        {
            // Bot görüntüsü yaratma.
            Bot bots = new Bot()
            {
                botimage = myImages[0],           // PictureBox görseli.
                botleft = rnd.Next(0, pnloyun.Width + 10),     // PictureBox'ın Location.X'ini oyunda random bir yere atıyor.
                bottop = rnd.Next(0, pnloyun.Height + 100),    // PictureBox'ın Location.Y'ini oyunda random bir yere atıyor.
            };
            bots.botTimer_Tick(pnloyun);
            player.BringToFront();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (gameOver) return;
            if(e.KeyCode == Keys.A)
            {
                goleft = true;
                facing = "left";
                player.Image = null;
                player.Image = myImages[5];
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
                facing = "right";
                player.Image = myImages[4];
            }
            if (e.KeyCode == Keys.W)
            {
                goup = true;
                facing = "up";
                player.Image = myImages[6];
            }
            if (e.KeyCode == Keys.S)
            {
                godown = true;
                facing = "down";
                player.Image = myImages[3];
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (gameOver) return;
            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = false;
            }

            // mermi ateşleme tuşu.
            if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;
                // ateşleme fonksiyonu
                shoot(facing);
                
                // mermi 0 ise cephane düsür.
                if(ammo < 1)
                {
                    DropAmmo();
                }
            }
        }

        private void OyunBitti()
        {

            pnloyun.Controls.Clear();

            for (int i = 0; i < 6; i++)
            {
                kalpler[i].Visible = true;
            }

            ana_menu.Enabled = true;
            pnlson.BringToFront();
            lblskor_son.Text = "Skorun : " + score.ToString();
            lbl_total_ammo.Text = "Toplam Aldığın Ammo Miktarı : " + total_ammo.ToString();
            lbl_total_shoot.Text = "Toplam Ettiğin Ateş Sayısı : " + total_shoot.ToString();
            lbl_live_time.Text = "Hayatta Kaldığın Süre : " + sure.ToString() + " saniye";
            lbl_level.Text = "Ulaştığın Zorluk Seviyesi : " + botSayisi;

        }

        private void Gecen_Sure(object sender, EventArgs e)
        {
            sure++;
            lblsure.Text = "Süre : " + sure;
        }

        private void ana_menu_Click(object sender, EventArgs e)
        {
            baslat.Enabled = true;
            cikis.Enabled = true;
            pnlanamenu.BringToFront();
            variableReset();           
        }

        private void baslat_Click(object sender, EventArgs e)
        {
            baslat.Enabled = false;
            cikis.Enabled = false;
            ana_menu.Enabled = false;
            makePlayer();
            makeBots();

            timer1.Enabled = true;
            zaman.Enabled = true;

            pnloyun.BringToFront();
            panel1.BringToFront();
            KeyPreview = true;
        }

        private void makePlayer()
        {
            player.Name = "player";
            player.Image = myImages[4];                     // PictureBox görseli.
            player.Left = pnloyun.Width / 2;                // PictureBox'ın Location.X'ini oyunda random bir yere atıyor.
            player.Top = pnloyun.Height / 2;                // PictureBox'ın Location.Y'ini oyunda random bir yere atıyor.
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.Tag = "player";

            pnloyun.Controls.Add(player);
            player.BringToFront();
        }

        private void variableReset()
        {
            facing = "up"; // mermiyi yonlendirmek icin kullanilacak.
            speed = 10; // oyuncu hızı.
            ammo = 10; // oyuncunun baslangicta sahip oldugu mermi
            botSpeed = 3; // bot hızı.
            botSayisi = 1; // oyunda kaç bot olduğunu belirleyen degisken.
            can = 6;    // can değerini tutan int.
            score = 0; // oyuncu skoru.
            gameOver = false; // sanirim bir tur virus. true olursa oyun bitiyor. :((
            total_ammo = 0; // toplam alınan cephane miktarını tutar.
            total_shoot = 0; // toplam edilen ateş sayısını tutar.
            sure = 0;   // toplam geçen süreyi tutar.
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
