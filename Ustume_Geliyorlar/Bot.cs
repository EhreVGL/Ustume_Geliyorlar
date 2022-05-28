using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Ustume_Geliyorlar
{
    internal class Bot
    {
       
        public int botleft;
        public int bottop;
        public int speed;

        PictureBox bot = new PictureBox();
        public Bitmap botimage;

        public void botTimer_Tick(Panel pnloyun)
        {
            bot.Image = botimage;                            // mermi resmini ekler.
            bot.SizeMode = PictureBoxSizeMode.AutoSize;      // PictureBox'u resim boyutuna sabitler.
            bot.Tag = "bot";                                 // PictureBox'ın tag'ini "bullet" yapar.
            bot.Left = botleft;                              // merminin Location.X'ini belirtir.    
            bot.Top = bottop;                                // merminin Location.Y'sini belirtir.
            bot.BringToFront();                              // mermiyi en üste çıkartır.

            pnloyun.Controls.Add(bot);                       // mermiyi pnloyun'a ekler.
        }
    }
}
