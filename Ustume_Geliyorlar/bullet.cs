using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Ustume_Geliyorlar
{
    internal class Bullet
    {
        public string direction;
        public int bulletleft;
        public int bullettop;
        public int speed = 20;

        PictureBox bullet = new PictureBox();
        Timer bulletTimer = new Timer();
        public Bitmap bulletimage;

        public void bulletTimer_Tick(Panel pnloyun)
        {
            bullet.Image = bulletimage;                         // mermi resmini ekler.
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;      // PictureBox'u resim boyutuna sabitler.
            bullet.Tag = "bullet";                              // PictureBox'ın tag'ini "bullet" yapar.
            bullet.Left = bulletleft;                           // merminin Location.X'ini belirtir.    
            bullet.Top = bullettop;                             // merminin Location.Y'sini belirtir.
            bullet.BringToFront();                              // mermiyi en üste çıkartır.

            pnloyun.Controls.Add(bullet);                       // mermiyi pnloyun'a ekler.

            bulletTimer.Interval = 20;                               // mermi hızını belirleyen timer'ı ayarlar
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);     // timer'ın her tick'inde çalışacak fonksiyonu belirtir.
            bulletTimer.Start();                                        // timer'ı başlatır.
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if(direction == "left")
            {
                bullet.Left -= speed;
            }
            if (direction == "right")
            {
                bullet.Left += speed;
            }
            if (direction == "up")
            {
                bullet.Top -= speed;
            }
            if (direction == "down")
            {
                bullet.Top += speed;
            }
        }

    }
}
