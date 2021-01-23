namespace B24.D110.ComboBox
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
            this.lblUrunListesi = new System.Windows.Forms.Label();
            this.cbxUrun = new System.Windows.Forms.ComboBox();
            this.grpDetayBilgi = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblStokAdet = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.rtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.grpDetayBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunListesi
            // 
            this.lblUrunListesi.AutoSize = true;
            this.lblUrunListesi.Location = new System.Drawing.Point(27, 18);
            this.lblUrunListesi.Name = "lblUrunListesi";
            this.lblUrunListesi.Size = new System.Drawing.Size(62, 13);
            this.lblUrunListesi.TabIndex = 0;
            this.lblUrunListesi.Text = "Ürün Listesi";
            // 
            // cbxUrun
            // 
            this.cbxUrun.FormattingEnabled = true;
            this.cbxUrun.Location = new System.Drawing.Point(116, 18);
            this.cbxUrun.Name = "cbxUrun";
            this.cbxUrun.Size = new System.Drawing.Size(344, 21);
            this.cbxUrun.TabIndex = 1;
            // 
            // grpDetayBilgi
            // 
            this.grpDetayBilgi.Controls.Add(this.rtxtAciklama);
            this.grpDetayBilgi.Controls.Add(this.textBox2);
            this.grpDetayBilgi.Controls.Add(this.lblUrunAdi);
            this.grpDetayBilgi.Controls.Add(this.textBox4);
            this.grpDetayBilgi.Controls.Add(this.lblStokAdet);
            this.grpDetayBilgi.Controls.Add(this.textBox3);
            this.grpDetayBilgi.Controls.Add(this.lblYazar);
            this.grpDetayBilgi.Controls.Add(this.textBox1);
            this.grpDetayBilgi.Controls.Add(this.lblKategori);
            this.grpDetayBilgi.Controls.Add(this.pictureBox1);
            this.grpDetayBilgi.Location = new System.Drawing.Point(12, 51);
            this.grpDetayBilgi.Name = "grpDetayBilgi";
            this.grpDetayBilgi.Size = new System.Drawing.Size(456, 270);
            this.grpDetayBilgi.TabIndex = 2;
            this.grpDetayBilgi.TabStop = false;
            this.grpDetayBilgi.Text = "Ürün Detay Bilgileri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(184, 45);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(49, 13);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = " Kategori";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(184, 22);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(184, 97);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(34, 13);
            this.lblYazar.TabIndex = 1;
            this.lblYazar.Text = "Yazar";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 20);
            this.textBox3.TabIndex = 2;
            // 
            // lblStokAdet
            // 
            this.lblStokAdet.AutoSize = true;
            this.lblStokAdet.Location = new System.Drawing.Point(184, 71);
            this.lblStokAdet.Name = "lblStokAdet";
            this.lblStokAdet.Size = new System.Drawing.Size(54, 13);
            this.lblStokAdet.TabIndex = 1;
            this.lblStokAdet.Text = "Stok Adet";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(260, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 20);
            this.textBox4.TabIndex = 2;
            // 
            // rtxtAciklama
            // 
            this.rtxtAciklama.Location = new System.Drawing.Point(6, 139);
            this.rtxtAciklama.Name = "rtxtAciklama";
            this.rtxtAciklama.Size = new System.Drawing.Size(442, 126);
            this.rtxtAciklama.TabIndex = 3;
            this.rtxtAciklama.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 333);
            this.Controls.Add(this.grpDetayBilgi);
            this.Controls.Add(this.cbxUrun);
            this.Controls.Add(this.lblUrunListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDetayBilgi.ResumeLayout(false);
            this.grpDetayBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunListesi;
        private System.Windows.Forms.ComboBox cbxUrun;
        private System.Windows.Forms.GroupBox grpDetayBilgi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtxtAciklama;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblStokAdet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblYazar;
    }
}

