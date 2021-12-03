using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace satis_form
{
    public partial class frmProfil : Form
    {
        public frmProfil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E6B8FTL;Initial Catalog=Stok_Takip;Integrated Security=True");

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor");
            }
            else if (txtSifre.Text == "" || txtKullaniciAdi.Text == "" || txtSifreTekrar.Text == "")
            {
                MessageBox.Show("Lütfen eksiksiz doldurunuz");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update KullaniciBilgileri set KullaniciAdi=@KullaniciAdi, Sifre=@Sifre", baglanti);
                komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text.ToString());
                komut.Parameters.AddWithValue("@Sifre", txtSifre.Text.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bilgileriniz güncellendi", "Profil Düzenle");
            }
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {

        }
    }
}
