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
     partial class FormPersonel : Form
    {
        public FormPersonel(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }
        Banka banka;
        private void BtnMusteriKaydet_Click(object sender, EventArgs e)
        {

        }

        private void BtnMusteriKaydet_Click_1(object sender, EventArgs e)
        {
            string ad = txtMusteriAd.Text;
            string soyad = txtMusteriSoyad.Text;
            string kullaniciAdi = txtMusteriNo.Text;
            string sifre = txtMusteriSifre.Text;
            DateTime tarih = dateTimeMusteri.Value; // Bu kodla Tarihin değerini almış oluruz

            if (radioBireyselMusteri.Checked==true)
            {
                banka.MusteriEkle(true,ad,soyad,kullaniciAdi,sifre,tarih);
                string rapor = ($"{kullaniciAdi} kullanıcı adına sahip {ad} {soyad} kişisi Bireysel müşteri olarak bankaya eklendi");
                banka.RaporEkle(rapor,tarih);
            }
            else if (radioTicariMusteri.Checked == true)
            {
                banka.MusteriEkle(false, ad, soyad, kullaniciAdi, sifre, tarih);
                string rapor = ($"{kullaniciAdi} kullanıcı adına sahip {ad} {soyad} kişisi Ticari müşteri olarak bankaya eklendi");
                banka.RaporEkle(rapor, tarih);
            }
            else
            {
                MessageBox.Show("Lütfen müşteri tipini seçiniz");
            }

        }

        private void BtnHesapAc_Click(object sender, EventArgs e)
        {
            string musteriNo = txtMusteriHesapAcNo.Text;
            int ekBakiye = Convert.ToInt32(txtEkBakiye.Text);

            foreach (BireyselMusteri m in banka.bireyselMusteriler)
            {
                if (musteriNo==m.ID)
                {
                    m.HesapAc(ekBakiye);
                    string rapor = ($"{m.ID} kullanıcı adına sahip Bireysel Müşteri için hesap açıldı.");
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor,tarih);
                }
            }

            foreach (TicariMusteri m in banka.ticariMusteriler)
            {
                if (musteriNo == m.ID)
                {
                    m.HesapAc(ekBakiye);
                    string rapor = ($"{m.ID} kullanıcı adına sahip Ticari Müşteri için hesap açıldı.");
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }

        }

        private void BtnHesapSil_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtHesapNo.Text);

            foreach (BireyselMusteri m in banka.bireyselMusteriler)
            {
                foreach (Hesap h in m.hesaplar.ToList())
                {
                    m.HesapSil(hesapNo);

                    string rapor = ($"{m.ID} kullanıcı adına sahip Bireysel Müşterinin {hesapNo} numaralı hesabı silindi.");
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }

            foreach (TicariMusteri m in banka.ticariMusteriler)
            {
                foreach (Hesap h in m.hesaplar.ToList())
                {
                    m.HesapSil(hesapNo);

                    string rapor = ($"{m.ID} kullanıcı adına sahip Ticari Müşterinin {hesapNo} numaralı hesabı silindi.");
                    DateTime tarih = DateTime.Today;
                    banka.RaporEkle(rapor, tarih);
                }
            }


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
    }
}
