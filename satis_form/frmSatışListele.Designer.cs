namespace satis_form
{
    partial class frmSatışListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatışListele));
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTcAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // barkodno
            // 
            this.barkodno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barkodno.DataPropertyName = "barkodno";
            this.barkodno.HeaderText = "Barkod No";
            this.barkodno.Name = "barkodno";
            this.barkodno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // satisfiyati
            // 
            this.satisfiyati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.satisfiyati.DataPropertyName = "satisfiyati";
            this.satisfiyati.HeaderText = "Satış Fiyatı";
            this.satisfiyati.Name = "satisfiyati";
            this.satisfiyati.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // toplamfiyati
            // 
            this.toplamfiyati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.toplamfiyati.DataPropertyName = "toplamfiyati";
            this.toplamfiyati.HeaderText = "Toplam Fiyat";
            this.toplamfiyati.Name = "toplamfiyati";
            this.toplamfiyati.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.tc,
            this.adsoyad,
            this.telefon,
            this.barkodno,
            this.urunadi,
            this.miktari,
            this.satisfiyati,
            this.toplamfiyati,
            this.tarih});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1077, 529);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC Kimlik Numarasına Göre Ara:";
            // 
            // TxtTcAra
            // 
            this.TxtTcAra.Location = new System.Drawing.Point(904, 12);
            this.TxtTcAra.Name = "TxtTcAra";
            this.TxtTcAra.Size = new System.Drawing.Size(161, 23);
            this.TxtTcAra.TabIndex = 0;
            this.TxtTcAra.TextChanged += new System.EventHandler(this.TxtTcAra_TextChanged);
            // 
            // frmSatışListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 570);
            this.Controls.Add(this.TxtTcAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSatışListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmSatışListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodno;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTcAra;
    }
}