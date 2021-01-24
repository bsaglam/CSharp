namespace B24.D220.CheckedListBoxKullanimi
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.grpDetayBilgi = new System.Windows.Forms.GroupBox();
            this.rtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblStokAdet = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.lblYazar = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDetayBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(165, 259);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // grpDetayBilgi
            // 
            this.grpDetayBilgi.Controls.Add(this.rtxtAciklama);
            this.grpDetayBilgi.Controls.Add(this.txtUrunAdi);
            this.grpDetayBilgi.Controls.Add(this.lblUrunAdi);
            this.grpDetayBilgi.Controls.Add(this.txtStok);
            this.grpDetayBilgi.Controls.Add(this.lblStokAdet);
            this.grpDetayBilgi.Controls.Add(this.txtYazar);
            this.grpDetayBilgi.Controls.Add(this.lblYazar);
            this.grpDetayBilgi.Controls.Add(this.txtKategori);
            this.grpDetayBilgi.Controls.Add(this.lblKategori);
            this.grpDetayBilgi.Controls.Add(this.pictureBox1);
            this.grpDetayBilgi.Location = new System.Drawing.Point(183, 12);
            this.grpDetayBilgi.Name = "grpDetayBilgi";
            this.grpDetayBilgi.Size = new System.Drawing.Size(470, 266);
            this.grpDetayBilgi.TabIndex = 4;
            this.grpDetayBilgi.TabStop = false;
            this.grpDetayBilgi.Text = "Ürün Detay Bilgileri";
            // 
            // rtxtAciklama
            // 
            this.rtxtAciklama.Location = new System.Drawing.Point(6, 139);
            this.rtxtAciklama.Name = "rtxtAciklama";
            this.rtxtAciklama.Size = new System.Drawing.Size(442, 125);
            this.rtxtAciklama.TabIndex = 3;
            this.rtxtAciklama.Text = "";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(260, 19);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(188, 20);
            this.txtUrunAdi.TabIndex = 2;
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
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(260, 68);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(188, 20);
            this.txtStok.TabIndex = 2;
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
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(260, 94);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(188, 20);
            this.txtYazar.TabIndex = 2;
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
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(260, 42);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(188, 20);
            this.txtKategori.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 293);
            this.Controls.Add(this.grpDetayBilgi);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDetayBilgi.ResumeLayout(false);
            this.grpDetayBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox grpDetayBilgi;
        private System.Windows.Forms.RichTextBox rtxtAciklama;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblStokAdet;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

