using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
     partial class FormYonetici : Form
    {
        public FormYonetici(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }
        Banka banka;

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill;
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill;
        }

        private void SimpleButton3_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill;
        }

        private void SimpleButton4_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            FormGiris formGiris = new FormGiris(banka);
            formGiris.TopLevel = false;
            panel1.Controls.Add(formGiris);
            formGiris.Show();
            formGiris.Dock = DockStyle.Fill;
        }

        private void BtnPersonelEkle_Click(object sender, EventArgs e)
        {
            string Ad = txtPersonelEkleAdi.Text;
            string Soyad = txtPersonelEkleSoyadi.Text;
            string ID = txtPersonelEkleKullaniciAdi.Text;
            string Sifre = txtPersonelEkleSifre.Text;

            txtPersonelEkleAdi.Clear();
            txtPersonelEkleSoyadi.Clear();
            txtPersonelEkleKullaniciAdi.Clear();
            txtPersonelEkleSifre.Clear();

            banka.PersonelEkle(Ad,Soyad,ID,Sifre);
            this.dataGridPersonelListele.DataSource = null;
            this.dataGridPersonelListele.DataSource = banka.personeller;

            string rapor = ($"{ID} kullanıcı adına sahip personel bankaya eklendi.");
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor, tarih);

        }

        private void BtnPersonelSil_Click(object sender, EventArgs e)
        {
            string personelKullaniciAdi = txtPersonelSilKulAdi.Text;
            txtPersonelSilKulAdi.Clear();
            banka.PersonelSil(personelKullaniciAdi);

            this.dataGridPersonelListele.DataSource = null;
            this.dataGridPersonelListele.DataSource = banka.personeller;

            string rapor = ($"{personelKullaniciAdi} kullanıcı adına sahip personel bankadan silindi");
            DateTime tarih = DateTime.Today;
            banka.RaporEkle(rapor,tarih);
        }

        private void BtnBankaIslemListele_Click(object sender, EventArgs e)
        {
            dataGridBankaIslemListele.DataSource = null;
            dataGridBankaIslemListele.DataSource = banka.bankaRaporListesi;

            labelToplamPara.Text = ($"Banka Toplam Para: {banka.toplamPara} TL");
        }
    }
}
