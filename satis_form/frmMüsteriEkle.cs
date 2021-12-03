using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace satis_form
{
    public partial class frmMüsteriEkle : Form
    {
        public frmMüsteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E6B8FTL;Initial Catalog=Stok_Takip;Integrated Security=True");

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into müşteri(tc,adsoyad,telefon,adres) values(@tc,@adsoyad,@telefon,@adres)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Tamamlandı", "Kayıt İşlemi");
            foreach (Control item in this.Controls)
            { 
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
