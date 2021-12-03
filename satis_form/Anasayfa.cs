using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace satis_form
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private Form aktifForm = null;

        private void Active(Button button)
        {
            foreach(Control currentBtn in panel2.Controls)
            {
                if(currentBtn.GetType() == typeof(Button))
                {
                    if(currentBtn.Name == button.Name)
                    {
                        button.BackColor = Color.FromArgb(100, 100, 100);
                    } else
                    {
                        currentBtn.BackColor = Color.FromArgb(64, 64, 64);
                    }
                }
            }
        } 
        
        private void altFormuAc(Form altForm)
        {
            if (aktifForm != null)
            {
                aktifForm.Close();
            }
            aktifForm = altForm;
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            AltFormKapsayici.Controls.Add(altForm);
            AltFormKapsayici.Tag = altForm;
            altForm.BringToFront();
            altForm.Show();
        }
        private void btnUrunler_Click(object sender, EventArgs e)
        {   
            Active(btnUrunler);
            altFormuAc(new FrmÜrünListele());
        }
        

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            Active(btnKategoriler);
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            Active(btnUrunIslemleri);
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        private void btnMarkalar_Click(object sender, EventArgs e)
        {   
            Active(btnMarkalar);
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            Active(btnMusteriler);
            altFormuAc(new frmMüşteriListele());
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            Active(btnYeniMusteri);
            frmMüsteriEkle ekle = new frmMüsteriEkle();
            ekle.ShowDialog();
        }

        private void btnSatisListele_Click(object sender, EventArgs e)
        {
            altFormuAc(new frmSatışListele());
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Active(btnUrunler);
            altFormuAc(new FrmÜrünListele());

        }

        private void btnProfilim_Click(object sender, EventArgs e)
        {
            Active(btnProfilim);
            frmProfil profilim = new frmProfil(); 
            profilim.Show();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            Active(btnSatisYap);
            altFormuAc(new frmSatis());
        }

        private void btnSatislistele_Click_1(object sender, EventArgs e)
        {
            Active(btnSatislistele);
            altFormuAc(new frmSatışListele());
        }
    }
}
