namespace satis_form
{
    partial class frmProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfil));
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSifreTekrarı = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(115, 71);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(127, 23);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(115, 109);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(127, 23);
            this.txtSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı: ";
            // 
            // lblSifreTekrarı
            // 
            this.lblSifreTekrarı.AutoSize = true;
            this.lblSifreTekrarı.Location = new System.Drawing.Point(39, 150);
            this.lblSifreTekrarı.Name = "lblSifreTekrarı";
            this.lblSifreTekrarı.Size = new System.Drawing.Size(70, 15);
            this.lblSifreTekrarı.TabIndex = 4;
            this.lblSifreTekrarı.Text = "Şifre Tekrarı:";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(115, 142);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(127, 23);
            this.txtSifreTekrar.TabIndex = 2;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(158, 186);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(84, 35);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // frmProfil
            // 
            this.AcceptButton = this.btnGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(286, 275);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.lblSifreTekrarı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil Güncelleme";
            this.Load += new System.EventHandler(this.frmProfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSifreTekrarı;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Button btnGüncelle;
    }
}