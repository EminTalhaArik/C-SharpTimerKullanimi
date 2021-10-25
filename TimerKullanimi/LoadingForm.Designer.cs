
namespace TimerKullanimi
{
    partial class LoadingForm
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
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.lblYukleniyor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(12, 115);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(374, 39);
            this.prgBar.TabIndex = 0;
            // 
            // lblYukleniyor
            // 
            this.lblYukleniyor.AutoSize = true;
            this.lblYukleniyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYukleniyor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblYukleniyor.Location = new System.Drawing.Point(88, 40);
            this.lblYukleniyor.Name = "lblYukleniyor";
            this.lblYukleniyor.Size = new System.Drawing.Size(230, 44);
            this.lblYukleniyor.TabIndex = 1;
            this.lblYukleniyor.Text = "Yükleniyor...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLoading.Location = new System.Drawing.Point(326, 126);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(36, 17);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "%25";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 167);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblYukleniyor);
            this.Controls.Add(this.prgBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoadingForm";
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.Label lblYukleniyor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLoading;
    }
}