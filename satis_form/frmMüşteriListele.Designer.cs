namespace satis_form
{
    partial class frmMüşteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüşteriListele));
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniMusteriEkle = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriListeFormu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListeFormu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(128, 232);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(95, 37);
            this.btnGüncelle.TabIndex = 5;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(82, 189);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(141, 23);
            this.txtAdres.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(82, 144);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(141, 23);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(82, 95);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(141, 23);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtTc
            // 
            this.txtTc.Enabled = false;
            this.txtTc.Location = new System.Drawing.Point(82, 47);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(141, 23);
            this.txtTc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "TC:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(23, 232);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 37);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(69, 52);
            this.txtTcAra.MaxLength = 11;
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(240, 23);
            this.txtTcAra.TabIndex = 0;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "TC ile arama yap:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYeniMusteriEkle);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.btnGüncelle);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(69, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 328);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri ";
            // 
            // btnYeniMusteriEkle
            // 
            this.btnYeniMusteriEkle.Location = new System.Drawing.Point(23, 278);
            this.btnYeniMusteriEkle.Name = "btnYeniMusteriEkle";
            this.btnYeniMusteriEkle.Size = new System.Drawing.Size(200, 37);
            this.btnYeniMusteriEkle.TabIndex = 7;
            this.btnYeniMusteriEkle.Text = "Yeni Müşteri Ekle";
            this.btnYeniMusteriEkle.UseVisualStyleBackColor = true;
            this.btnYeniMusteriEkle.Click += new System.EventHandler(this.btnYeniMusteriEkle_Click);
            // 
            // tc
            // 
            this.tc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tc.DataPropertyName = "tc";
            this.tc.HeaderText = "TC Kimlik Numarası";
            this.tc.Name = "tc";
            this.tc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // adsoyad
            // 
            this.adsoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adsoyad.DataPropertyName = "adsoyad";
            this.adsoyad.HeaderText = "Ad Soyad";
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // telefon
            // 
            this.telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon Numarası";
            this.telefon.Name = "telefon";
            this.telefon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // adres
            // 
            this.adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adres.DataPropertyName = "adres";
            this.adres.HeaderText = "Adres";
            this.adres.Name = "adres";
            this.adres.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MusteriListeFormu
            // 
            this.MusteriListeFormu.BackgroundColor = System.Drawing.Color.White;
            this.MusteriListeFormu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriListeFormu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tc,
            this.adsoyad,
            this.telefon,
            this.adres});
            this.MusteriListeFormu.Dock = System.Windows.Forms.DockStyle.Right;
            this.MusteriListeFormu.Location = new System.Drawing.Point(392, 0);
            this.MusteriListeFormu.Name = "MusteriListeFormu";
            this.MusteriListeFormu.Size = new System.Drawing.Size(685, 570);
            this.MusteriListeFormu.TabIndex = 12;
            this.MusteriListeFormu.Text = "dataGridView1";
            this.MusteriListeFormu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MusteriListeFormu_CellDoubleClick);
            // 
            // frmMüşteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1077, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTcAra);
            this.Controls.Add(this.MusteriListeFormu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMüşteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme Ekranı";
            this.Load += new System.EventHandler(this.frmMüşteriListele_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListeFormu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView MusteriListeFormu;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.Button btnYeniMusteriEkle;
    }
}