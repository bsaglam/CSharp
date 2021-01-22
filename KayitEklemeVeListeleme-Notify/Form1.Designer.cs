namespace B24.D202.KayitEklemeVeListeleme_Notify
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKayit = new System.Windows.Forms.ListBox();
            this.bildirim = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.lblSifre);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblSoyisim);
            this.groupBox1.Controls.Add(this.lblIsim);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(95, 193);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Yeni Müşteri Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(95, 141);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(95, 68);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(100, 20);
            this.txtSoyisim.TabIndex = 1;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(95, 37);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 20);
            this.txtIsim.TabIndex = 0;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(16, 141);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 13);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Şifre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(16, 68);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(42, 13);
            this.lblSoyisim.TabIndex = 0;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(16, 37);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(25, 13);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "İsim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKayit);
            this.groupBox2.Location = new System.Drawing.Point(312, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lstKayit
            // 
            this.lstKayit.FormattingEnabled = true;
            this.lstKayit.Location = new System.Drawing.Point(6, 24);
            this.lstKayit.Name = "lstKayit";
            this.lstKayit.Size = new System.Drawing.Size(120, 95);
            this.lstKayit.TabIndex = 0;
            // 
            // bildirim
            // 
            this.bildirim.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.bildirim.BalloonTipText = "Deneme";
            this.bildirim.BalloonTipTitle = "Kayıt sayısı";
            this.bildirim.Text = "notifyIcon1";
            this.bildirim.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 274);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kullanıcı Ekleme ve Listeleme Ekranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.ListBox lstKayit;
        private System.Windows.Forms.NotifyIcon bildirim;
    }
}

