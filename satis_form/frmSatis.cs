using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace satis_form
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E6B8FTL;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet",baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            lblStokAdedi.Visible = false;
            sepetlistele();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from müşteri where tc like '" + txtTc.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtÜrünAdı.Text = read["urunadi"].ToString();
                txtSatışFiyatı.Text = read["satisfiyati"].ToString();
                lblStokAdedi.Visible = true;
                lblAdet.Text = read["miktari"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                txtÜrünAdı.Text = "";
                txtSatışFiyatı.Text = "";
                txtToplamFiyat.Text = "";
                lblAdet.Text = "";
            }
        }

        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            try
            {
                if (durum == true)
                {
                    if (int.Parse(txtMiktari.Text) > 0 && txtMiktari.Text != "")
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                        komut.Parameters.AddWithValue("@tc", txtTc.Text);
                        komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                        komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                        komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                        komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                        komut.Parameters.AddWithValue("@satisfiyati", Double.Parse(txtSatışFiyatı.Text));
                        komut.Parameters.AddWithValue("@toplamfiyati", Double.Parse(txtToplamFiyat.Text));
                        komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ürün Miktarını Kontrol Ediniz");
                    }
                }

                else
                {
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update sepet set miktari = miktari+ '" + int.Parse(txtMiktari.Text) + "'where barkodno='" + txtBarkodNo.Text + "'", baglanti);
                    komut2.ExecuteNonQuery();

                    SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyati = miktari*satisfiyati where barkodno='" + txtBarkodNo.Text + "'", baglanti);
                    komut3.ExecuteNonQuery();

                    baglanti.Close();
                }
                groupBox2.Enabled = false;
                txtMiktari.Text = "1";
                daset.Tables["sepet"].Clear();
                sepetlistele();
                hesapla();
                txtBarkodNo.Text = "";
                txtÜrünAdı.Text = "";
                txtSatışFiyatı.Text = "";
                txtToplamFiyat.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Ürün Miktarını Kontrol Ediniz");
            }
        }

        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet",baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatışFiyatı.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno = '"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() +"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();
            groupBox2.Enabled = true;
            baglanti.Close();
            MessageBox.Show("Ürünler Sepetten Çıkarıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            txtAdSoyad.Text = "";
            txtTc.Text = "";
            txtTelefon.Text = "";
            txtBarkodNo.Text = "";
            txtÜrünAdı.Text = "";
            txtMiktari.Text = "";
            txtSatışFiyatı.Text = "";
            txtToplamFiyat.Text = "";
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", Double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", Double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set miktari = miktari - '" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "'where barkodno = '" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();

            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet ", baglanti);
            komut3.ExecuteNonQuery();
            groupBox2.Enabled = true;
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            txtAdSoyad.Text = "";
            txtTc.Text = "";
            txtTelefon.Text = "";
            txtBarkodNo.Text = "";
            txtÜrünAdı.Text = "";
            txtMiktari.Text = "";
            txtSatışFiyatı.Text = "";
            txtToplamFiyat.Text = "";
        }
    }
}
