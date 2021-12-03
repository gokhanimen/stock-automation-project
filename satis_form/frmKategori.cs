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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E6B8FTL;Initial Catalog=Stok_Takip;Integrated Security=True");

        bool durum;

        private void kategoriKontrol()
        {
            if (txtKategori.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    if (txtKategori.Text.Trim().ToLower() == read["kategori"].ToString().Trim().ToLower())
                    {
                        durum = false;
                    }
                    else
                    {
                        durum = true;
                    }
                }
                baglanti.Close();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kategoriKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values ('" + txtKategori.Text.Trim().ToUpper() + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kategori Eklendi", "Kategori Ekleme İşlemi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bir Kategori Giriniz!", "Uyarı");
            }
            txtKategori.Text = "";
        }
    }
}
