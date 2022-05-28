namespace Ustume_Geliyorlar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnloyun = new System.Windows.Forms.Panel();
            this.kalp6 = new System.Windows.Forms.PictureBox();
            this.kalp5 = new System.Windows.Forms.PictureBox();
            this.kalp4 = new System.Windows.Forms.PictureBox();
            this.kalp3 = new System.Windows.Forms.PictureBox();
            this.kalp2 = new System.Windows.Forms.PictureBox();
            this.kalp1 = new System.Windows.Forms.PictureBox();
            this.lblammo = new System.Windows.Forms.Label();
            this.lblskor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlson = new System.Windows.Forms.Panel();
            this.ana_menu = new System.Windows.Forms.Button();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_live_time = new System.Windows.Forms.Label();
            this.lbl_total_shoot = new System.Windows.Forms.Label();
            this.lbl_total_ammo = new System.Windows.Forms.Label();
            this.lblskor_son = new System.Windows.Forms.Label();
            this.zaman = new System.Windows.Forms.Timer(this.components);
            this.lblsure = new System.Windows.Forms.Label();
            this.pnlanamenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.baslat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kalp6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalp5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalp1)).BeginInit();
            this.pnlson.SuspendLayout();
            this.pnlanamenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnloyun
            // 
            this.pnloyun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnloyun.Location = new System.Drawing.Point(0, 0);
            this.pnloyun.Name = "pnloyun";
            this.pnloyun.Size = new System.Drawing.Size(984, 661);
            this.pnloyun.TabIndex = 0;
            // 
            // kalp6
            // 
            this.kalp6.Image = global::Ustume_Geliyorlar.Properties.Resources.kalp;
            this.kalp6.Location = new System.Drawing.Point(364, 25);
            this.kalp6.Name = "kalp6";
            this.kalp6.Size = new System.Drawing.Size(15, 15);
            this.kalp6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kalp6.TabIndex = 9;
            this.kalp6.TabStop = false;
            // 
            // kalp5
            // 
            this.kalp5.Image = global::Ustume_Geliyorlar.Properties.Resources.kalp;
            this.kalp5.Location = new System.Drawing.Point(343, 25);
            this.kalp5.Name = "kalp5";
            this.kalp5.Size = new System.Drawing.Size(15, 15);
            this.kalp5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kalp5.TabIndex = 8;
            this.kalp5.TabStop = false;
            // 
            // kalp4
            // 
            this.kalp4.Image = global::Ustume_Geliyorlar.Properties.Resources.kalp;
            this.kalp4.Location = new System.Drawing.Point(322, 25);
            this.kalp4.Name = "kalp4";
            this.kalp4.Size = new System.Drawing.Size(15, 15);
            this.kalp4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kalp4.TabIndex = 7;
            this.kalp4.TabStop = false;
            // 
            // kalp3
            // 
            this.kalp3.Image = global::Ustume_Geliyorlar.Properties.Resources.kalp;
            this.kalp3.Location = new System.Drawing.Point(302, 25);
            this.kalp3.Name = "kalp3";
            this.kalp3.Size = new System.Drawing.Size(15, 15);
            this.kalp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kalp3.TabIndex = 6;
            this.kalp3.TabStop = false;
            // 
            // kalp2
            // 
            this.kalp2.Image = global::Ustume_Geliyorlar.Properties.Resources.kalp;
            this.kalp2.Location = new System.Drawing.Point(281, 25);
            this.kalp2.Name = "kalp2";
            this.kalp2.Size = new System.Drawing.Size(15, 15);
            this.kalp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kalp2.TabIndex = 5;
            this.kalp2.TabStop = false;
            // 
            // kalp1
            // 
            this.kalp1.Image = global::Ustume_Geliyorlar.Properties.Resources.kalp;
            this.kalp1.Location = new System.Drawing.Point(260, 25);
            this.kalp1.Name = "kalp1";
            this.kalp1.Size = new System.Drawing.Size(15, 15);
            this.kalp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kalp1.TabIndex = 4;
            this.kalp1.TabStop = false;
            // 
            // lblammo
            // 
            this.lblammo.AutoSize = true;
            this.lblammo.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblammo.ForeColor = System.Drawing.Color.Thistle;
            this.lblammo.Location = new System.Drawing.Point(102, 19);
            this.lblammo.Name = "lblammo";
            this.lblammo.Size = new System.Drawing.Size(95, 27);
            this.lblammo.TabIndex = 1;
            this.lblammo.Text = "Ammo: 0";
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblskor.ForeColor = System.Drawing.Color.Thistle;
            this.lblskor.Location = new System.Drawing.Point(11, 19);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(74, 27);
            this.lblskor.TabIndex = 0;
            this.lblskor.Text = "Skor: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameEngine);
            // 
            // pnlson
            // 
            this.pnlson.Controls.Add(this.ana_menu);
            this.pnlson.Controls.Add(this.lbl_level);
            this.pnlson.Controls.Add(this.lbl_live_time);
            this.pnlson.Controls.Add(this.lbl_total_shoot);
            this.pnlson.Controls.Add(this.lbl_total_ammo);
            this.pnlson.Controls.Add(this.lblskor_son);
            this.pnlson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlson.Location = new System.Drawing.Point(0, 0);
            this.pnlson.Name = "pnlson";
            this.pnlson.Size = new System.Drawing.Size(984, 661);
            this.pnlson.TabIndex = 10;
            // 
            // ana_menu
            // 
            this.ana_menu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ana_menu.Location = new System.Drawing.Point(782, 564);
            this.ana_menu.Name = "ana_menu";
            this.ana_menu.Size = new System.Drawing.Size(157, 71);
            this.ana_menu.TabIndex = 5;
            this.ana_menu.Text = "ANA MENÜ";
            this.ana_menu.UseVisualStyleBackColor = true;
            this.ana_menu.Click += new System.EventHandler(this.ana_menu_Click);
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_level.ForeColor = System.Drawing.Color.Thistle;
            this.lbl_level.Location = new System.Drawing.Point(28, 396);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(411, 45);
            this.lbl_level.TabIndex = 4;
            this.lbl_level.Text = "Ulaştığın Zorluk Seviyesi :";
            // 
            // lbl_live_time
            // 
            this.lbl_live_time.AutoSize = true;
            this.lbl_live_time.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_live_time.ForeColor = System.Drawing.Color.Thistle;
            this.lbl_live_time.Location = new System.Drawing.Point(28, 338);
            this.lbl_live_time.Name = "lbl_live_time";
            this.lbl_live_time.Size = new System.Drawing.Size(363, 45);
            this.lbl_live_time.TabIndex = 3;
            this.lbl_live_time.Text = "Hayatta Kaldığın Süre :";
            // 
            // lbl_total_shoot
            // 
            this.lbl_total_shoot.AutoSize = true;
            this.lbl_total_shoot.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_total_shoot.ForeColor = System.Drawing.Color.Thistle;
            this.lbl_total_shoot.Location = new System.Drawing.Point(28, 274);
            this.lbl_total_shoot.Name = "lbl_total_shoot";
            this.lbl_total_shoot.Size = new System.Drawing.Size(424, 45);
            this.lbl_total_shoot.TabIndex = 2;
            this.lbl_total_shoot.Text = "Toplam Ettiğin Ateş Sayısı :";
            // 
            // lbl_total_ammo
            // 
            this.lbl_total_ammo.AutoSize = true;
            this.lbl_total_ammo.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_total_ammo.ForeColor = System.Drawing.Color.Thistle;
            this.lbl_total_ammo.Location = new System.Drawing.Point(28, 209);
            this.lbl_total_ammo.Name = "lbl_total_ammo";
            this.lbl_total_ammo.Size = new System.Drawing.Size(503, 45);
            this.lbl_total_ammo.TabIndex = 1;
            this.lbl_total_ammo.Text = "Toplam Aldığın Ammo Miktarı : ";
            // 
            // lblskor_son
            // 
            this.lblskor_son.AutoSize = true;
            this.lblskor_son.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblskor_son.ForeColor = System.Drawing.Color.Thistle;
            this.lblskor_son.Location = new System.Drawing.Point(28, 146);
            this.lblskor_son.Name = "lblskor_son";
            this.lblskor_son.Size = new System.Drawing.Size(172, 45);
            this.lblskor_son.TabIndex = 0;
            this.lblskor_son.Text = "Skorun : 0";
            // 
            // zaman
            // 
            this.zaman.Interval = 1000;
            this.zaman.Tick += new System.EventHandler(this.Gecen_Sure);
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblsure.ForeColor = System.Drawing.Color.Thistle;
            this.lblsure.Location = new System.Drawing.Point(863, 19);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(75, 27);
            this.lblsure.TabIndex = 10;
            this.lblsure.Text = "Süre: 0";
            // 
            // pnlanamenu
            // 
            this.pnlanamenu.Controls.Add(this.label1);
            this.pnlanamenu.Controls.Add(this.cikis);
            this.pnlanamenu.Controls.Add(this.baslat);
            this.pnlanamenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlanamenu.Location = new System.Drawing.Point(0, 0);
            this.pnlanamenu.Name = "pnlanamenu";
            this.pnlanamenu.Size = new System.Drawing.Size(984, 661);
            this.pnlanamenu.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(432, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "prodbyEhreVGL";
            // 
            // cikis
            // 
            this.cikis.AutoSize = true;
            this.cikis.Location = new System.Drawing.Point(475, 289);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(44, 31);
            this.cikis.TabIndex = 1;
            this.cikis.Text = "ÇIKIŞ";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // baslat
            // 
            this.baslat.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslat.ForeColor = System.Drawing.Color.PaleGreen;
            this.baslat.Location = new System.Drawing.Point(243, 89);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(514, 165);
            this.baslat.TabIndex = 0;
            this.baslat.Text = "BAŞLA";
            this.baslat.UseVisualStyleBackColor = true;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.kalp5);
            this.panel1.Controls.Add(this.lblsure);
            this.panel1.Controls.Add(this.lblskor);
            this.panel1.Controls.Add(this.kalp6);
            this.panel1.Controls.Add(this.lblammo);
            this.panel1.Controls.Add(this.kalp1);
            this.panel1.Controls.Add(this.kalp4);
            this.panel1.Controls.Add(this.kalp2);
            this.panel1.Controls.Add(this.kalp3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 56);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlanamenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnloyun);
            this.Controls.Add(this.pnlson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.kalp6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalp5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kalp1)).EndInit();
            this.pnlson.ResumeLayout(false);
            this.pnlson.PerformLayout();
            this.pnlanamenu.ResumeLayout(false);
            this.pnlanamenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnloyun;
        private System.Windows.Forms.Label lblammo;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox kalp6;
        private System.Windows.Forms.PictureBox kalp5;
        private System.Windows.Forms.PictureBox kalp4;
        private System.Windows.Forms.PictureBox kalp3;
        private System.Windows.Forms.PictureBox kalp2;
        private System.Windows.Forms.PictureBox kalp1;
        private System.Windows.Forms.Panel pnlson;
        private System.Windows.Forms.Button ana_menu;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_live_time;
        private System.Windows.Forms.Label lbl_total_shoot;
        private System.Windows.Forms.Label lbl_total_ammo;
        private System.Windows.Forms.Label lblskor_son;
        private System.Windows.Forms.Timer zaman;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Panel pnlanamenu;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

