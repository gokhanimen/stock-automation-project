namespace satis_form
{
    partial class FrmÜrünListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmÜrünListele));
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SatışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.AlışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.Miktarıtxt = new System.Windows.Forms.TextBox();
            this.ÜrünAdıtxt = new System.Windows.Forms.TextBox();
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.BarkodNotxt = new System.Windows.Forms.TextBox();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.butonSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barkodno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisfiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(159, 332);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 36);
            this.btnGüncelle.TabIndex = 7;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barkod No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Miktarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alış Fiyatı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Satış Fiyatı:";
            // 
            // SatışFiyatıtxt
            // 
            this.SatışFiyatıtxt.Location = new System.Drawing.Point(104, 287);
            this.SatışFiyatıtxt.Name = "SatışFiyatıtxt";
            this.SatışFiyatıtxt.Size = new System.Drawing.Size(130, 23);
            this.SatışFiyatıtxt.TabIndex = 6;
            // 
            // AlışFiyatıtxt
            // 
            this.AlışFiyatıtxt.Location = new System.Drawing.Point(104, 248);
            this.AlışFiyatıtxt.Name = "AlışFiyatıtxt";
            this.AlışFiyatıtxt.Size = new System.Drawing.Size(130, 23);
            this.AlışFiyatıtxt.TabIndex = 5;
            // 
            // Miktarıtxt
            // 
            this.Miktarıtxt.Location = new System.Drawing.Point(104, 209);
            this.Miktarıtxt.Name = "Miktarıtxt";
            this.Miktarıtxt.Size = new System.Drawing.Size(130, 23);
            this.Miktarıtxt.TabIndex = 4;
            // 
            // ÜrünAdıtxt
            // 
            this.ÜrünAdıtxt.Location = new System.Drawing.Point(104, 167);
            this.ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            this.ÜrünAdıtxt.Size = new System.Drawing.Size(130, 23);
            this.ÜrünAdıtxt.TabIndex = 3;
            // 
            // Markatxt
            // 
            this.Markatxt.Enabled = false;
            this.Markatxt.Location = new System.Drawing.Point(104, 129);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.ReadOnly = true;
            this.Markatxt.Size = new System.Drawing.Size(130, 23);
            this.Markatxt.TabIndex = 2;
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Enabled = false;
            this.Kategoritxt.Location = new System.Drawing.Point(104, 91);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.ReadOnly = true;
            this.Kategoritxt.Size = new System.Drawing.Size(130, 23);
            this.Kategoritxt.TabIndex = 1;
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(104, 51);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(130, 23);
            this.BarkodNotxt.TabIndex = 0;
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(634, 30);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(100, 23);
            this.txtBarkodNoAra.TabIndex = 12;
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Barkod No\' ya Göre Ara:";
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(90, 30);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(100, 23);
            this.comboKategori.TabIndex = 9;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(251, 30);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(100, 23);
            this.comboMarka.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kategori:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Marka:";
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(367, 22);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(100, 35);
            this.btnMarkaGuncelle.TabIndex = 11;
            this.btnMarkaGuncelle.Text = "Marka Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(852, 156);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // butonSil
            // 
            this.butonSil.Location = new System.Drawing.Point(69, 331);
            this.butonSil.Name = "butonSil";
            this.butonSil.Size = new System.Drawing.Size(75, 36);
            this.butonSil.TabIndex = 8;
            this.butonSil.Text = "Sil";
            this.butonSil.UseVisualStyleBackColor = true;
            this.butonSil.Click += new System.EventHandler(this.butonSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.butonSil);
            this.groupBox1.Controls.Add(this.btnGüncelle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SatışFiyatıtxt);
            this.groupBox1.Controls.Add(this.BarkodNotxt);
            this.groupBox1.Controls.Add(this.AlışFiyatıtxt);
            this.groupBox1.Controls.Add(this.Kategoritxt);
            this.groupBox1.Controls.Add(this.Miktarıtxt);
            this.groupBox1.Controls.Add(this.Markatxt);
            this.groupBox1.Controls.Add(this.ÜrünAdıtxt);
            this.groupBox1.Location = new System.Drawing.Point(28, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 395);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // barkodno
            // 
            this.barkodno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barkodno.DataPropertyName = "barkodno";
            this.barkodno.HeaderText = "Barkod No";
            this.barkodno.Name = "barkodno";
            this.barkodno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // kategori
            // 
            this.kategori.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kategori.DataPropertyName = "kategori";
            this.kategori.HeaderText = "Kategori";
            this.kategori.Name = "kategori";
            this.kategori.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // marka
            // 
            this.marka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marka.DataPropertyName = "marka";
            this.marka.HeaderText = "Marka";
            this.marka.Name = "marka";
            this.marka.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // urunadi
            // 
            this.urunadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.urunadi.DataPropertyName = "urunadi";
            this.urunadi.HeaderText = "Ürün Adı";
            this.urunadi.Name = "urunadi";
            this.urunadi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // miktari
            // 
            this.miktari.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.miktari.DataPropertyName = "miktari";
            this.miktari.HeaderText = "Miktarı";
            this.miktari.Name = "miktari";
            this.miktari.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // alisfiyati
            // 
            this.alisfiyati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alisfiyati.DataPropertyName = "alisfiyati";
            this.alisfiyati.HeaderText = "Alış Fiyatı";
            this.alisfiyati.Name = "alisfiyati";
            this.alisfiyati.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // satisfiyati
            // 
            this.satisfiyati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.satisfiyati.DataPropertyName = "satisfiyati";
            this.satisfiyati.HeaderText = "Satış Fiyatı";
            this.satisfiyati.Name = "satisfiyati";
            this.satisfiyati.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tarih
            // 
            this.tarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            this.tarih.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodno,
            this.kategori,
            this.marka,
            this.urunadi,
            this.miktari,
            this.alisfiyati,
            this.satisfiyati,
            this.tarih});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 495);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 570);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMarkaGuncelle);
            this.panel2.Controls.Add(this.txtBarkodNoAra);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.comboKategori);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboMarka);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(312, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 75);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(312, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 495);
            this.panel3.TabIndex = 25;
            // 
            // FrmÜrünListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1077, 570);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmÜrünListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Ekranı";
            this.Load += new System.EventHandler(this.FrmÜrünListele_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SatışFiyatıtxt;
        private System.Windows.Forms.TextBox AlışFiyatıtxt;
        private System.Windows.Forms.TextBox Miktarıtxt;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.TextBox BarkodNotxt;
        private System.Windows.Forms.TextBox ÜrünAdıtxt;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMarkaGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button butonSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodno;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}