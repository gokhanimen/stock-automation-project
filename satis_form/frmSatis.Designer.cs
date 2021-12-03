namespace satis_form
{
    partial class frmSatis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            this.label11 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblStokAdedi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamfiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(79, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Satış Tutarı:";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenelToplam.Location = new System.Drawing.Point(172, 448);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(21, 20);
            this.lblGenelToplam.TabIndex = 7;
            this.lblGenelToplam.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.txtTc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(37, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri İşlemleri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ad Soyad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "TC Numarası:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(101, 65);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.CausesValidation = false;
            this.txtTelefon.Location = new System.Drawing.Point(101, 104);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 23);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(101, 22);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 23);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(859, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genel Toplam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(947, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdet);
            this.groupBox1.Controls.Add(this.lblStokAdedi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtToplamFiyat);
            this.groupBox1.Controls.Add(this.txtSatışFiyatı);
            this.groupBox1.Controls.Add(this.txtMiktari);
            this.groupBox1.Controls.Add(this.txtÜrünAdı);
            this.groupBox1.Controls.Add(this.txtBarkodNo);
            this.groupBox1.Location = new System.Drawing.Point(37, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün İşlemleri";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(100, 174);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(0, 15);
            this.lblAdet.TabIndex = 11;
            // 
            // lblStokAdedi
            // 
            this.lblStokAdedi.AutoSize = true;
            this.lblStokAdedi.Location = new System.Drawing.Point(20, 174);
            this.lblStokAdedi.Name = "lblStokAdedi";
            this.lblStokAdedi.Size = new System.Drawing.Size(67, 15);
            this.lblStokAdedi.TabIndex = 10;
            this.lblStokAdedi.Text = "Stok Adedi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Toplam Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Satış Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Barkod No:";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Enabled = false;
            this.txtToplamFiyat.Location = new System.Drawing.Point(101, 138);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(100, 23);
            this.txtToplamFiyat.TabIndex = 7;
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.Location = new System.Drawing.Point(102, 109);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(100, 23);
            this.txtSatışFiyatı.TabIndex = 6;
            this.txtSatışFiyatı.TextChanged += new System.EventHandler(this.txtSatışFiyatı_TextChanged);
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(101, 80);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(100, 23);
            this.txtMiktari.TabIndex = 5;
            this.txtMiktari.Text = "1";
            this.txtMiktari.TextChanged += new System.EventHandler(this.txtMiktari_TextChanged);
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(101, 51);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(100, 23);
            this.txtÜrünAdı.TabIndex = 4;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(101, 22);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 23);
            this.txtBarkodNo.TabIndex = 3;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Sepete Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Satış Yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sepetten Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Satış İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSatışİptal_Click);
            // 
            // tc
            // 
            this.tc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tc.DataPropertyName = "tc";
            this.tc.HeaderText = "Tc Numarası";
            this.tc.Name = "tc";
            // 
            // adsoyad
            // 
            this.adsoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adsoyad.DataPropertyName = "adsoyad";
            this.adsoyad.HeaderText = "Ad Soyad";
            this.adsoyad.Name = "adsoyad";
            // 
            // telefon
            // 
            this.telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            // 
            // barkodno
            // 
            this.barkodno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barkodno.DataPropertyName = "barkodno";
            this.barkodno.HeaderText = "Barkod No";
            this.barkodno.Name = "barkodno";
            // 
            // urunadi
            // 
            this.urunadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.urunadi.DataPropertyName = "urunadi";
            this.urunadi.HeaderText = "Ürün Adı";
            this.urunadi.Name = "urunadi";
            // 
            // miktari
            // 
            this.miktari.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.miktari.DataPropertyName = "miktari";
            this.miktari.HeaderText = "Miktarı";
            this.miktari.Name = "miktari";
            // 
            // satisfiyati
            // 
            this.satisfiyati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.satisfiyati.DataPropertyName = "satisfiyati";
            this.satisfiyati.HeaderText = "Satış Fiyatı";
            this.satisfiyati.Name = "satisfiyati";
            // 
            // toplamfiyati
            // 
            this.toplamfiyati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.toplamfiyati.DataPropertyName = "toplamfiyati";
            this.toplamfiyati.HeaderText = "Toplam Fiyat";
            this.toplamfiyati.Name = "toplamfiyati";
            // 
            // tarih
            // 
            this.tarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1077, 617);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tc,
            this.adsoyad,
            this.telefon,
            this.barkodno,
            this.urunadi,
            this.miktari,
            this.satisfiyati,
            this.toplamfiyati,
            this.tarih});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(328, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 617);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Text = "dataGridView1";
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSatis_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.TextBox txtSatışFiyatı;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblStokAdedi;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodno;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
    }
}

