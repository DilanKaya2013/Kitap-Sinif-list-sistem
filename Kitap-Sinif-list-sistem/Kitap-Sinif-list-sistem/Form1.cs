using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitap_Sinif_list_sistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kitap kitap;
        List<Kitap> kitapListesi=new List<Kitap>();

        private void Form1_Load(object sender, EventArgs e)
        {
            kitapListesi.Add(new Kitap(1, "Gizli Bahçe", "Frances Hodgson Burnett", "273", "kurgu", false, new DateTime(2021, 07, 01)));
            kitapListesi.Add(new Kitap(2, "Labirent", "James Dashner", "478", "Bilim kurgu", false, new DateTime(2009, 06, 02)));
            kitapListesi.Add(new Kitap(3, "Kızıl Soruşturması", "Sherlock Holmes", "153", "Polisiye", true, new DateTime(1887, 02, 05)));
            kitapListesi.Add(new Kitap(4, "Kar Tanesi", "Belza Alkoç", "320", "Roman", true, new DateTime(2021, 11, 22)));
            kitapListesi.Add(new Kitap(6, "Harry potter ve felsefe taşı ", "J. K. Rowling", "274", "Aksiyon", true, new DateTime(1997, 06, 26)));
             
            dgvKitap.DataSource = kitapListesi;


        }

        private void dgvKitap_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvKitap.CurrentRow.Cells["id"].Value.ToString();
            txtKitapAdi.Text = dgvKitap.CurrentRow.Cells["kitapAdi"].Value.ToString();
            txtYazar.Text = dgvKitap.CurrentRow.Cells["yazar"].Value.ToString();
            txtSayfaSayisi.Text = dgvKitap.CurrentRow.Cells["sayfaSayisi"].Value.ToString();
            cmbTur.Text = dgvKitap.CurrentRow.Cells["tur"].Value.ToString();
            chkCilt.Checked = (bool)dgvKitap.CurrentRow.Cells["cilt"].Value;
            dtpBasimTarihi.Value = (DateTime)dgvKitap.CurrentRow.Cells["basimTarihi"].Value;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string kitapAdi = txtKitapAdi.Text;
            string yazar = txtYazar.Text;
            string sayfaSayisi=txtSayfaSayisi.Text;
            string tur=cmbTur.Text;
            bool cilt=chkCilt.Checked;
            DateTime basimTarihi=dtpBasimTarihi.Value;

            Kitap yeniKitap = new Kitap(id, kitapAdi, yazar, sayfaSayisi, tur, cilt, basimTarihi);
            kitapListesi.Add(yeniKitap);
            dgvKitap.DataSource = kitapListesi.ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvKitap.SelectedRows[0];
            Kitap secilenKitap = secilenSatir.DataBoundItem as Kitap;
            DialogResult result = MessageBox.Show("Seçilen Satır Silinsin Mi?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                kitapListesi.Remove(secilenKitap);
            }
            dgvKitap.DataSource=kitapListesi.ToList();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvKitap.SelectedRows[0];
            Kitap secilenKitap = secilenSatir.DataBoundItem as Kitap;
            int id = Convert.ToInt32(txtId.Text);
            string kitapAdi = txtKitapAdi.Text;
            string yazar = txtYazar.Text;
            string sayfaaSayisi = txtSayfaSayisi.Text;
            string tur = cmbTur.Text;
            bool cilt = chkCilt.Checked;
            DateTime basimTarihi = dtpBasimTarihi.Value;

            secilenKitap.Id=id;
            secilenKitap.KitapAdi=kitapAdi;
            secilenKitap.Yazar=yazar;
            secilenKitap.SayfaSayisi = sayfaaSayisi;
            secilenKitap.Tur=tur;
            secilenKitap.Cilt = cilt;
            secilenKitap.BasimTarihi = basimTarihi;


            dgvKitap.DataSource = null;
            dgvKitap.DataSource = kitapListesi.ToList();

            
        }
    }
}
