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
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-E6B8FTL;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            baglanti.Close();
        }

        private void frmSatışListele_Load(object sender, EventArgs e)
        {
            satislistele();
        }

        private void TxtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from satis where tc like '%" + TxtTcAra.Text + "%'", baglanti);
            adaptor.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
