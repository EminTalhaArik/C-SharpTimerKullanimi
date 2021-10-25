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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        int loadingPanel = 0;

        int colorInd = 0;
        int colorRandom = 75;
        Random randomColor = new Random();

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            colorInd = randomColor.Next(0, 3);
            loadingPanel = 0;
            if (timer1.Enabled == false) timer1.Start();
        }
        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingPanel += random.Next(0, 3);
            if (loadingPanel <= 100)
            {
                prgBar.Value = loadingPanel;

                if (colorInd == 0)
                {
                    this.BackColor = Color.FromArgb(random.Next(75, 255), 0, 0);
                }
                else if (colorInd == 1)
                {
                    this.BackColor = Color.FromArgb(0, random.Next(75, 255), 0);

                }
                else if (colorInd == 2)
                {
                    this.BackColor = Color.FromArgb(0, 0, random.Next(75, 255));

                }

                lblLoading.Text = "%" + loadingPanel;
                if (loadingPanel % 3 == 0) lblYukleniyor.Text = "Yükleniyor";
                lblYukleniyor.Text += ".";
            }
            else if (loadingPanel > 100)
            {
                timer1.Stop();
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }
    }
}
