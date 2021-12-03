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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E6B8FTL;Initial Catalog=Stok_Takip;Integrated Security=True");

        bool durum;

        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboKategori.Text == read["kategori"].ToString() && txtMarka.Text == read["marka"].ToString() || comboKategori.Text=="" ||  txtMarka.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values ('" + comboKategori.Text + "','" + txtMarka.Text.Trim().ToUpper() + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka Eklendi", "Marka Ekleme İşlemi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori ve marka var", "Uyarı");
            }
            comboKategori.Text = "";
            txtMarka.Text = "";
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
    }
}
