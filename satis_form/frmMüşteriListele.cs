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
    public partial class frmMüşteriListele : Form
    {
        public frmMüşteriListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E6B8FTL;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet dataset = new DataSet();

        private void frmMüşteriListele_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
        }

        private void Kayit_Goster()
        {
            baglanti.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from müşteri", baglanti);
            adaptor.Fill(dataset, "müşteri");
            MusteriListeFormu.DataSource = dataset.Tables["müşteri"];
            baglanti.Close();
        }

        private void MusteriListeFormu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = MusteriListeFormu.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = MusteriListeFormu.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = MusteriListeFormu.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = MusteriListeFormu.CurrentRow.Cells["adres"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set adsoyad=@adsoyad, telefon=@telefon,adres=@adres where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataset.Tables["müşteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("Müşteri Kaydı Güncellendi", "Kayıt Güncelleme Ekranı");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where tc='"+ MusteriListeFormu.CurrentRow.Cells["tc"].Value.ToString()+ "'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataset.Tables["müşteri"].Clear();
            Kayit_Goster();
            MessageBox.Show("Kayıt Silindi", "Kayıt Silme Ekranı");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select *from müşteri where tc like '%"+txtTcAra.Text+"%'", baglanti);
            adaptor.Fill(tablo);
            MusteriListeFormu.DataSource = tablo;
            baglanti.Close();
        }

        private void btnYeniMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMüsteriEkle müsteriEkle = new frmMüsteriEkle();
            müsteriEkle.ShowDialog();
        }
    }
}
