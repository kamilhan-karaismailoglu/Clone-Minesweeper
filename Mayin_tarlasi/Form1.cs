using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace Mayin_tarlasi
{   
    public partial class Form1 : Form
    {
        public Tarla MayinTarlasi;
        Image MayinResim = Image.FromFile(@"Mayin.png");
        Image BayrakResim = Image.FromFile(@"flag.png");
        Image FaceLoseResim = Image.FromFile(@"face_lose.png");
        Image FaceUnpressedResim = Image.FromFile(@"face_unpressed.png");
        Image FaceWinResim = Image.FromFile(@"face_win.png");
        List<Mayin> BulunanMayinlar;
        int toplamDogruBayrak;
        int GerekliOlanDogruBayrak;
        int YanlısBayrakSayısı;
        int KalanMayın;
        int saniye;
        public Form1()
        {   
            InitializeComponent();           
        }
        private void Form1_Load(object sender, EventArgs e)
        {          
            textBoxHeight.Text = 20.ToString();
            textBoxWidth.Text = 20.ToString();
            textBoxMinus.Text = 20.ToString();
            labelMayinSayisi.Text = "020";

            buttonFace.BackgroundImage = FaceUnpressedResim;
            buttonFace.BackgroundImageLayout = ImageLayout.Stretch;

            MayinTarlasi = new Tarla(new Size(400, 400), 20);
            panelTarla.Size = new Size(404, 404);
            panelÜst.Size = new Size(404, 60);
            this.Size = new Size(404,404);
            buttonSS.Location = new Point(panelTarla.Size.Width - 33, panelTarla.Size.Height + panelÜst.Height + 55);
            buttonFace.Location = new Point(404/2-30,3);
            GerekliOlanDogruBayrak = 20;
            KalanMayın = 20;
            toplamDogruBayrak = 0;
            YanlısBayrakSayısı = 0;

            MayinEkle();
            timer1.Enabled = true;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int height;
            int width;
            int minus;

            if (textBoxHeight.Text == "" || textBoxMinus.Text == "" || textBoxWidth.Text == "")
            {
                MessageBox.Show("Geçersiz Bir Değer Girildi Lütfen Tekrar Deneyin");
            }
            else
            {
                height = Convert.ToInt32(textBoxHeight?.Text);
                width = Convert.ToInt32(textBoxWidth?.Text);
                minus = Convert.ToInt32(textBoxMinus?.Text);

                if (minus > height * width || minus < 1 || height < 1 || width < 1  || height > 100 || width > 100)
                {
                    MessageBox.Show("Geçersiz Bir Değer Girildi Lütfen Tekrar Deneyin");
                }
                else
                {
                    panelTarla.Controls.Clear();
                    buttonFace.BackgroundImage = FaceUnpressedResim;
                    buttonFace.BackgroundImageLayout = ImageLayout.Stretch;
                    panelTarla.Enabled = true;

                    MayinTarlasi = new Tarla(new Size(width * 20, height * 20), minus);
                    panelTarla.Size = new Size(width * 20 + 4, height * 20 + 4);
                    panelÜst.Size = new Size(width * 20 + 4, 60);
                    this.Size = new Size(width * 20 + 4, height * 20 + 4);
                    buttonFace.Location = new Point(panelÜst.Size.Width / 2 - 27, 3);
                    panelSagSayac.Location = new Point(panelÜst.Size.Width - 7 - panelSagSayac.Size.Width, 4);
                    buttonSS.Location = new Point(panelTarla.Size.Width - 32, panelTarla.Size.Height + panelÜst.Height + 55);
                    panelÜst.Visible = true;
                    buttonFace.Visible = true;
                    panelSolSayac.Visible = true;
                    panelSagSayac.Visible = true;
                    panelTarla.Location = new Point(5, 113);
                    this.Size = new Size(404,panelTarla.Height+panelÜst.Height+50);

                    if (width < 4)
                    {
                        buttonFace.Visible = false;
                        panelÜst.Visible = false;
                        panelSolSayac.Visible = true;
                        panelSagSayac.Visible = false;
                        panelTarla.Location = new Point(5, 63);
                        buttonSS.Location = new Point(panelTarla.Size.Width - 32, panelTarla.Size.Height+ 65);
                        this.Size = new Size(404, panelTarla.Height + panelÜst.Size.Height + 50+buttonSS.Height);
                        if (width == 1)
                        {
                            buttonSS.Location = new Point(panelTarla.Size.Width - 20, panelTarla.Size.Height + 65);
                        }
                    }
                    if (width > 3 && width < 9)
                    {
                        buttonFace.Visible = false;
                        panelSolSayac.Visible = true;
                        panelSagSayac.Visible = false;
                        panelSolSayac.Location = new Point(2,4); 

                    }
                    if (width >= 9 && width < 11)
                    {
                        buttonFace.Visible = false;
                        panelSolSayac.Visible = true;
                        panelSagSayac.Visible = true;
                    }
                    if (width >= 11)
                    {
                        buttonFace.Visible = true;
                        panelSolSayac.Visible = true;
                        panelSagSayac.Visible = true;
                    }

                    GerekliOlanDogruBayrak = minus;
                    KalanMayın = minus;
                    toplamDogruBayrak = 0;
                    YanlısBayrakSayısı = 0;

                    if (KalanMayın < 10)
                    {
                        labelMayinSayisi.Text ="00"+ KalanMayın.ToString();
                    }
                    else if(KalanMayın > 9 && KalanMayın < 100)
                    {
                        labelMayinSayisi.Text = "0" + KalanMayın.ToString();
                    }
                    else if (KalanMayın > 99 && KalanMayın < 1000)
                    {
                        labelMayinSayisi.Text = KalanMayın.ToString();
                    }
                    MayinEkle();
                    saniye = 0;
                    timer1.Enabled = true;
                }
            }                    
        }
        public void MayinEkle()
        {
            for (int x = 0; x < panelTarla.Width; x = x + 20)
            {
                for (int y = 0; y < panelTarla.Height; y = y + 20)
                {
                    ButtonEkle(new Point(x, y));
                }
            }
        }
        public void ButtonEkle(Point konum)
        {
            Button btn = new Button();
            btn.Name = konum.X + "" + konum.Y;
            btn.Size = new Size(20, 20);
            btn.Location = konum;
            btn.MouseDown += new MouseEventHandler(btn_Click);
            panelTarla.Controls.Add(btn);
        }
        public void btn_Click(object sender, EventArgs e)
        {   
            MouseEventArgs me = (MouseEventArgs)e;
            Button button = (sender as Button);

            if (me.Button == MouseButtons.Left)
            {
                if (button.BackgroundImage!=BayrakResim)
                {
                    Mayin myn = MayinTarlasi.GetMayinWithLoc(button.Location);
                    BulunanMayinlar = new List<Mayin>();
                    if (myn.DoluMu)
                    {
                        button.BackgroundImage = MayinResim;
                        button.BackColor = Color.Red;
                        buttonFace.BackgroundImage = FaceLoseResim;
                        buttonFace.BackgroundImageLayout = ImageLayout.Stretch;
                        panelTarla.Enabled = false;
                        timer1.Enabled = false;
                        saniye = 0;
                        MayinlariGöster();
                    }
                    else
                    {
                        int s = EtrafindaKacMayinVar(myn);
                        if (s == 0)
                        {
                            BulunanMayinlar.Add(myn);
                            for (int i = 0; i < BulunanMayinlar.Count; i++)
                            {
                                Mayin item = BulunanMayinlar[i];
                                if (item != null)
                                {
                                    if (item.BakıldıMı == false && item.DoluMu == false)
                                    {
                                        if (item.KonumBelirle.X == -100 && item.KonumBelirle.Y == -100)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Button btn = (Button)panelTarla.Controls.Find(item.KonumBelirle.X + "" + item.KonumBelirle.Y, false)[0];
                                            if (btn.BackgroundImage==BayrakResim)
                                            {
                                                KalanMayın++;
                                                YanlısBayrakSayısı--;
                                                if (KalanMayın < 10)
                                                {
                                                    labelMayinSayisi.Text = "00" + KalanMayın.ToString();
                                                    if (KalanMayın < 0 && KalanMayın > -10)
                                                    {
                                                        labelMayinSayisi.Text = "0" + KalanMayın.ToString();
                                                    }
                                                    else if (KalanMayın < -9 && KalanMayın > -100)
                                                    {
                                                        labelMayinSayisi.Text = KalanMayın.ToString();
                                                    }
                                                }
                                                else if (KalanMayın > 9 && KalanMayın < 100)
                                                {
                                                    labelMayinSayisi.Text = "0" + KalanMayın.ToString();
                                                }
                                                else if (KalanMayın > 99 && KalanMayın < 1000)
                                                {
                                                    labelMayinSayisi.Text = KalanMayın.ToString();
                                                }
                                            }
                                            if (EtrafindaKacMayinVar(BulunanMayinlar[i]) == 0)
                                            {
                                                btn.Enabled = false;
                                                btn.BackgroundImage = null;
                                                CevredekileriEkle(item);
                                            }
                                            else
                                            {
                                                btn.BackgroundImage = null;
                                                btn.Text = EtrafindaKacMayinVar(item).ToString();

                                                if (EtrafindaKacMayinVar(item) == 1)
                                                {
                                                    btn.ForeColor = System.Drawing.Color.Blue;
                                                }
                                                else if (EtrafindaKacMayinVar(item) == 2)
                                                {
                                                    btn.ForeColor = System.Drawing.Color.Green;
                                                }
                                                else
                                                {
                                                    btn.ForeColor = System.Drawing.Color.Red;
                                                }
                                            }
                                            item.BakıldıMı = true;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            button.BackgroundImage = null;
                            if (s==1)
                            {
                                button.ForeColor = Color.Blue;
                            }
                            else if (s==2)
                            {
                                button.ForeColor = Color.Green;
                            }
                            else
                            {
                                button.ForeColor = Color.Red;
                            }

                            button.Text = s.ToString();
                        }
                    }               
                }
            }
            else if (me.Button == MouseButtons.Right)
            {
                Mayin myn = MayinTarlasi.GetMayinWithLoc(button.Location);

                if (button.BackgroundImage == BayrakResim)
                {
                    button.BackgroundImage = null;
                    KalanMayın += 1;
                    if (KalanMayın < 10)
                    {
                        labelMayinSayisi.Text = "00" + KalanMayın.ToString();
                        if (KalanMayın < 0 && KalanMayın > -10)
                        {
                            labelMayinSayisi.Text = "0" + KalanMayın.ToString();
                        }
                        else if (KalanMayın < -9 && KalanMayın > -100)
                        {
                            labelMayinSayisi.Text = KalanMayın.ToString();
                        }
                    }
                    else if (KalanMayın > 9 && KalanMayın < 100)
                    {
                        labelMayinSayisi.Text = "0" + KalanMayın.ToString();
                    }
                    else if (KalanMayın > 99 && KalanMayın < 1000)
                    {
                        labelMayinSayisi.Text = KalanMayın.ToString();
                    }
                    if (myn.DoluMu)
                    {
                        toplamDogruBayrak -= 1;                        
                    }
                    else
                    {
                        YanlısBayrakSayısı -= 1;
                    }
                    if (toplamDogruBayrak == GerekliOlanDogruBayrak && YanlısBayrakSayısı == 0)
                    {
                        buttonFace.BackgroundImage = FaceWinResim;
                        buttonFace.BackgroundImageLayout = ImageLayout.Stretch;
                        toplamDogruBayrak = 0;
                        panelTarla.Enabled = false;
                        timer1.Enabled = false;
                        saniye = 0;
                    }
                }
                else
                {
                    if (button.ForeColor == Color.Red || button.ForeColor == Color.Blue || button.ForeColor == Color.Green)
                    {
                    }
                    else
                    {
                        button.BackgroundImage = BayrakResim;
                        button.BackgroundImageLayout = ImageLayout.Stretch;

                        KalanMayın -= 1;

                        if (KalanMayın < 10)
                        {
                            labelMayinSayisi.Text = "00" + KalanMayın.ToString();
                            if (KalanMayın < 0 && KalanMayın >-10)
                            {
                                labelMayinSayisi.Text = "0" + KalanMayın.ToString();
                            }
                            else if (KalanMayın < -9 && KalanMayın > -100)
                            {
                                labelMayinSayisi.Text = KalanMayın.ToString();
                            }
                        }
                        else if (KalanMayın > 9 && KalanMayın < 100)
                        {
                            labelMayinSayisi.Text = "0" + KalanMayın.ToString();
                        }
                        else if (KalanMayın > 99 && KalanMayın < 1000)
                        {
                            labelMayinSayisi.Text = KalanMayın.ToString();
                        }                     

                        if (myn.DoluMu)
                        {
                            toplamDogruBayrak += 1;                           
                        }
                        else
                        {
                            YanlısBayrakSayısı += 1;
                        }
                        if (toplamDogruBayrak == GerekliOlanDogruBayrak && YanlısBayrakSayısı == 0)
                        {
                            buttonFace.BackgroundImage = FaceWinResim;
                            buttonFace.BackgroundImageLayout = ImageLayout.Stretch;
                            panelTarla.Enabled = false;
                            timer1.Enabled = false;
                            saniye = 0;
                        }
                    }                 
                }
            }           
        }
        public int EtrafindaKacMayinVar(Mayin m)
        {
            int sayi = 0;
            if (m.KonumBelirle.X > 0)
            {
                if ((MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X - 20, m.KonumBelirle.Y)).DoluMu))
                {
                    sayi++;
                }
            }
            if (m.KonumBelirle.Y < panelTarla.Height - 20 && m.KonumBelirle.X < panelTarla.Width - 20)
            {
                if ((MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X + 20, m.KonumBelirle.Y + 20)).DoluMu))
                {
                    sayi++;
                }
            }
            if (m.KonumBelirle.X < panelTarla.Width - 20)
            {
                if ((MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X + 20, m.KonumBelirle.Y)).DoluMu))
                {
                    sayi++;
                }
            }
            if (m.KonumBelirle.X > 0 && m.KonumBelirle.Y > 0)
            {
                if ((MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X - 20, m.KonumBelirle.Y - 20)).DoluMu))
                {
                    sayi++;
                }
            }
            if (m.KonumBelirle.Y > 0)
            {
                if ((MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X, m.KonumBelirle.Y - 20)).DoluMu))
                {
                    sayi++;
                }
            }
            if (m.KonumBelirle.X > 0 && m.KonumBelirle.Y < panelTarla.Height - 20)
            {
                if ((MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X - 20, m.KonumBelirle.Y + 20)).DoluMu))
                {
                    sayi++;
                }
            }
            if (m.KonumBelirle.Y < panelTarla.Height - 20)
            {
                if ((MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X, m.KonumBelirle.Y + 20)).DoluMu))
                {
                    sayi++;
                }
            }
            if (m.KonumBelirle.X > panelTarla.Width - 20 && m.KonumBelirle.Y > 0)
            {
                if ((MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X + 20, m.KonumBelirle.Y - 20)).DoluMu))
                {
                    sayi++;
                }
            }

            return sayi;
        }
        public void CevredekileriEkle(Mayin m)
        {
            bool b1 = false;
            bool b2 = false;
            bool b3 = false;
            bool b4 = false;
            if (m.KonumBelirle.X > 0)
            {
                BulunanMayinlar.Add(MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X - 20, m.KonumBelirle.Y)));
                b1 = true;
            }
            if (m.KonumBelirle.Y > 0)
            {
                BulunanMayinlar.Add(MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X, m.KonumBelirle.Y - 20)));
                b2 = true;
            }
            if (m.KonumBelirle.X < panelTarla.Width)
            {
                BulunanMayinlar.Add(MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X + 20, m.KonumBelirle.Y)));
                b3 = true;
            }
            if (m.KonumBelirle.Y < panelTarla.Height)
            {
                BulunanMayinlar.Add(MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X, m.KonumBelirle.Y + 20)));
                b4 = true;
            }
            if (b1 && b2)
            {
                BulunanMayinlar.Add(MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X - 20, m.KonumBelirle.Y - 20)));
            }
            if (b1 && b4)
            {
                BulunanMayinlar.Add(MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X - 20, m.KonumBelirle.Y + 20)));
            }
            if (b2 && b3)
            {
                BulunanMayinlar.Add(MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X + 20, m.KonumBelirle.Y - 20)));
            }
            if (b2 && b4)
            {
                BulunanMayinlar.Add(MayinTarlasi.GetMayinWithLoc(new Point(m.KonumBelirle.X + 20, m.KonumBelirle.Y + 20)));
            }
        }
        public void MayinlariGöster()
        {
            foreach (var mayin in MayinTarlasi.GetAllMayin)
            {
                if (mayin.DoluMu)
                {
                    Button btn = (Button)panelTarla.Controls.Find(mayin.KonumBelirle.X + "" + mayin.KonumBelirle.Y, false)[0];
                    btn.BackgroundImage = MayinResim;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            labelSaniye.Text = saniye.ToString();
            if (saniye < 10)
            {
                labelSaniye.Text = "00" + saniye.ToString();
            }
            else if (saniye > 9 && saniye < 100)
            {
                labelSaniye.Text = "0" + saniye.ToString();
            }
            else if (saniye > 99 && saniye < 1000)
            {
                labelSaniye.Text = saniye.ToString();
            }
        }
        private void buttonSS_Click(object sender, EventArgs e)
        {   
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));                
                bmp.Save(path+@"\"+DateTime.Now.ToLongDateString()+" - "+DateTime.Now.Hour.ToString()+"."+ DateTime.Now.Minute.ToString()+"." + DateTime.Now.Second.ToString()+".png");
                MessageBox.Show("Ekran Görüntüsü Masaüstünüze ( "+DateTime.Now.ToLongDateString() + " - " + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString() + ".png )" + " İsmi ile Kayıt Edildi", "Ekran Görüntüsü Alındı");
            }
        }
        private void textBoxMinus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}