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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E6B8FTL;Initial Catalog=Stok_Takip;Integrated Security=True");

        private void btnGirişYap_Click(object sender, EventArgs e)
        {

            if (txtKullaniciAdi.Text != "" || txtSifre.Text != "")
            {
                baglanti.Open();
                string komut = "select * from KullaniciBilgileri where KullaniciAdi = '"+ txtKullaniciAdi.Text +"' and Sifre = '"+txtSifre.Text+"'";

                SqlDataAdapter adaptor = new SqlDataAdapter(komut, baglanti);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                if (tablo.Rows.Count == 1)
                {
                    frmAnasayfa satis = new frmAnasayfa();
                    satis.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bilgilerinizi kontrol ediniz!", "Uyarı");
                    txtKullaniciAdi.Clear();
                    txtSifre.Clear();
                }

                baglanti.Close();
            }
            else 
            {
                MessageBox.Show("Kullanıcı bilgileri boş geçilemez!", "Uyarı");
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnGirişYap.FlatStyle = FlatStyle.Flat;
            btnGirişYap.FlatAppearance.BorderSize = 0;
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
