using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat;
        int dakika;
        int saniye;
        string gun;
        string ay;
        string yil;

        private void timerSay_Tick(object sender, EventArgs e)
        {
            Saat();
            GeriSayim();
            TrafikLambasi();
        }

        private void Saat()
        {
            saat = DateTime.Now.Hour;
            dakika = DateTime.Now.Minute;
            saniye = DateTime.Now.Second;

            gun = DateTime.Now.Day.ToString();
            ay = DateTime.Now.Month.ToString();
            yil = DateTime.Now.Year.ToString();

            lblHour.Text = saat.ToString();
            lblMinute.Text = dakika.ToString();
            lblSecond.Text = saniye.ToString();
        }

        private void GeriSayim()
        {
            if (geriSayimDevam)
            {
                geriSayimSure -= 1;
                lblGeriSayim.Text = geriSayimSure.ToString();
                if (geriSayimSure <= 0) BaslatButton();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Saat();
            TrafikLambasi();

            if (timerSay.Enabled == false) timerSay.Start();
            geriSayimDevam = false;
            lblGeriSayim.Text = "0";
        }

        int geriSayimSure = 0;
        bool geriSayimDevam = false;
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            BaslatButton();
        }

        private void BaslatButton()
        {
            geriSayimSure = Convert.ToInt32(tbxSure.Text);

            if (timerSay.Enabled == false) timerSay.Start();

            if (geriSayimDevam)
            {
                geriSayimDevam = false;
                btnBaslat.Text = "Başlat";
            }
            else if (!geriSayimDevam)
            {
                btnBaslat.Text = "Durdur";
                geriSayimDevam = true;
                lblGeriSayim.Text = geriSayimSure.ToString();
            }
        }

        //string main = @"D:\Belgeler\Projeler\Yazilim_Projeleri\TimerKullanimi\TimerKullanimi\Properties\Resimler\";
        //string kirmiziIsik = "1.png";
        //string sariIsik = "4.png";
        //string yesilIsik = "3.png";
        //string kirmiziVeSariIsik = "2.png";
        //string kapali = "0.png";

        Image kapali = global::TimerKullanimi.Properties.Resources._0;
        Image kirmiziIsik = global::TimerKullanimi.Properties.Resources._1;
        Image kirmiziVeSariIsik = global::TimerKullanimi.Properties.Resources._2;
        Image yesilIsik = global::TimerKullanimi.Properties.Resources._3;
        Image sariIsik = global::TimerKullanimi.Properties.Resources._4;

        int trafikLambasiSayim = 0;
        private void TrafikLambasi()
        {
            //if (trafikLambasiSayim == 20) trafikLambasiSayim = 0;
            //trafikLambasiSayim++;

            //if (trafikLambasiSayim == 5) pboxTrafikLambasi.Image = Image.FromFile(main + kirmiziIsik);
            //else if (trafikLambasiSayim == 7) pboxTrafikLambasi.Image = Image.FromFile(main + kirmiziVeSariIsik);
            //else if (trafikLambasiSayim == 13) pboxTrafikLambasi.Image = Image.FromFile(main + yesilIsik);
            //else if (trafikLambasiSayim == 18) pboxTrafikLambasi.Image = Image.FromFile(main + sariIsik);

            if (trafikLambasiSayim == 20) trafikLambasiSayim = 0;
            trafikLambasiSayim++;

            if (trafikLambasiSayim == 5) pboxTrafikLambasi.Image = kirmiziIsik;
            else if (trafikLambasiSayim == 7) pboxTrafikLambasi.Image = kirmiziVeSariIsik;
            else if (trafikLambasiSayim == 13) pboxTrafikLambasi.Image = yesilIsik;
            else if (trafikLambasiSayim == 18) pboxTrafikLambasi.Image = sariIsik;
        }
    }
}

