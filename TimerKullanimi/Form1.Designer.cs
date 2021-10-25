
namespace TimerKullanimi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerSay = new System.Windows.Forms.Timer(this.components);
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblNoktaliVirgul1 = new System.Windows.Forms.Label();
            this.lblNoktaliVirgul2 = new System.Windows.Forms.Label();
            this.gboxKronometre = new System.Windows.Forms.GroupBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblGeriSayim = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.tbxSure = new System.Windows.Forms.TextBox();
            this.pboxTrafikLambasi = new System.Windows.Forms.PictureBox();
            this.gboxKronometre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTrafikLambasi)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSay
            // 
            this.timerSay.Interval = 1000;
            this.timerSay.Tick += new System.EventHandler(this.timerSay_Tick);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Komika Axis", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(15, 472);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(189, 152);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "24";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Komika Axis", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.Location = new System.Drawing.Point(283, 472);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(189, 152);
            this.lblMinute.TabIndex = 1;
            this.lblMinute.Text = "24";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Komika Axis", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(549, 472);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(189, 152);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "24";
            // 
            // lblNoktaliVirgul1
            // 
            this.lblNoktaliVirgul1.AutoSize = true;
            this.lblNoktaliVirgul1.Font = new System.Drawing.Font("Komika Axis", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoktaliVirgul1.Location = new System.Drawing.Point(180, 472);
            this.lblNoktaliVirgul1.Name = "lblNoktaliVirgul1";
            this.lblNoktaliVirgul1.Size = new System.Drawing.Size(99, 152);
            this.lblNoktaliVirgul1.TabIndex = 3;
            this.lblNoktaliVirgul1.Text = ":";
            // 
            // lblNoktaliVirgul2
            // 
            this.lblNoktaliVirgul2.AutoSize = true;
            this.lblNoktaliVirgul2.Font = new System.Drawing.Font("Komika Axis", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoktaliVirgul2.Location = new System.Drawing.Point(446, 472);
            this.lblNoktaliVirgul2.Name = "lblNoktaliVirgul2";
            this.lblNoktaliVirgul2.Size = new System.Drawing.Size(99, 152);
            this.lblNoktaliVirgul2.TabIndex = 4;
            this.lblNoktaliVirgul2.Text = ":";
            // 
            // gboxKronometre
            // 
            this.gboxKronometre.Controls.Add(this.btnBaslat);
            this.gboxKronometre.Controls.Add(this.lblGeriSayim);
            this.gboxKronometre.Controls.Add(this.lblSure);
            this.gboxKronometre.Controls.Add(this.tbxSure);
            this.gboxKronometre.Location = new System.Drawing.Point(12, 12);
            this.gboxKronometre.Name = "gboxKronometre";
            this.gboxKronometre.Size = new System.Drawing.Size(426, 287);
            this.gboxKronometre.TabIndex = 5;
            this.gboxKronometre.TabStop = false;
            this.gboxKronometre.Text = "Kronometre";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(156, 188);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(148, 57);
            this.btnBaslat.TabIndex = 11;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblGeriSayim
            // 
            this.lblGeriSayim.AutoSize = true;
            this.lblGeriSayim.Font = new System.Drawing.Font("Komika Axis", 25F);
            this.lblGeriSayim.Location = new System.Drawing.Point(192, 100);
            this.lblGeriSayim.Name = "lblGeriSayim";
            this.lblGeriSayim.Size = new System.Drawing.Size(86, 69);
            this.lblGeriSayim.TabIndex = 8;
            this.lblGeriSayim.Text = "24";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(85, 50);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(65, 24);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "Süre : ";
            // 
            // tbxSure
            // 
            this.tbxSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSure.Location = new System.Drawing.Point(156, 50);
            this.tbxSure.Name = "tbxSure";
            this.tbxSure.Size = new System.Drawing.Size(148, 27);
            this.tbxSure.TabIndex = 0;
            // 
            // pboxTrafikLambasi
            // 
            this.pboxTrafikLambasi.Image = global::TimerKullanimi.Properties.Resources._0;
            this.pboxTrafikLambasi.Location = new System.Drawing.Point(1064, 12);
            this.pboxTrafikLambasi.Name = "pboxTrafikLambasi";
            this.pboxTrafikLambasi.Size = new System.Drawing.Size(200, 500);
            this.pboxTrafikLambasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxTrafikLambasi.TabIndex = 6;
            this.pboxTrafikLambasi.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 631);
            this.Controls.Add(this.pboxTrafikLambasi);
            this.Controls.Add(this.gboxKronometre);
            this.Controls.Add(this.lblNoktaliVirgul2);
            this.Controls.Add(this.lblNoktaliVirgul1);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxKronometre.ResumeLayout(false);
            this.gboxKronometre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTrafikLambasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerSay;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblNoktaliVirgul1;
        private System.Windows.Forms.Label lblNoktaliVirgul2;
        private System.Windows.Forms.GroupBox gboxKronometre;
        private System.Windows.Forms.Label lblGeriSayim;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.TextBox tbxSure;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.PictureBox pboxTrafikLambasi;
    }
}

