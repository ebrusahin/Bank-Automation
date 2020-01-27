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
     partial class FormGiris : Form
    {
        public FormGiris(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        Banka banka;

        private void BtnYonetici_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = form1.Controls["Panel1"] as Panel;
            panel1.Controls.Clear();

            FormYonetici formYonetici = new FormYonetici(banka);
            formYonetici.TopLevel = false;
            panel1.Controls.Add(formYonetici);
            formYonetici.Show();
            formYonetici.Dock = DockStyle.Fill;






        }

        private void BtnPersonelGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt1KullaniciAdi.Text;
            string sifre = txtSifre.Text;

            foreach (Personel p in banka.personeller)
            {
                if (kullaniciAdi == p.ID && sifre == p.Sifre)
                {
                    Form1 form1 = Application.OpenForms["Form"] as Form1; //Form1'e eriş
                    Panel panel1 = form1.Controls["Panel1"] as Panel; //Form1de panele eriş
                    panel1.Controls.Clear();

                    FormPersonel formPersonel = new FormPersonel(banka); //FormPersoneli panele eklemek için nesne oluştur.
                    formPersonel.TopLevel = false;
                    panel1.Controls.Add(formPersonel);
                    formPersonel.Show();
                    formPersonel.Dock = DockStyle.Fill;
                    MessageBox.Show($"HOŞGELDİNİZ. Sayın {p.Soyad}");
                }      
            }
        }

        private void BtnMusteriGiris_Click(object sender, EventArgs e)
        {
            string musteriNo = txt1KullaniciAdi.Text;
            string sifre = txtSifre.Text;

            foreach (BireyselMusteri  m in banka.bireyselMusteriler)
            {
                if (musteriNo == m.ID && sifre == m.Sifre)
                {
                    Form1 form1 = Application.OpenForms["Form"] as Form1; //Form1'e eriş
                    Panel panel1 = form1.Controls["Panel1"] as Panel; //Form1de panele eriş
                    panel1.Controls.Clear();
                    FormMusteri formMusteri = new FormMusteri(banka,m);
                    formMusteri.TopLevel = false;
                    panel1.Controls.Add(formMusteri);
                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show($"HOŞGELDİNİZ. Sayın {m.Ad} {m.Soyad}");
                }

            }

            foreach (TicariMusteri m in banka.ticariMusteriler)
            {
                if (musteriNo == m.ID && sifre == m.Sifre)
                {
                    Form1 form1 = Application.OpenForms["Form"] as Form1; //Form1'e eriş
                    Panel panel1 = form1.Controls["Panel1"] as Panel; //Form1de panele eriş
                    panel1.Controls.Clear();
                    FormMusteri formMusteri = new FormMusteri(banka, m);
                    formMusteri.TopLevel = false;
                    panel1.Controls.Add(formMusteri);
                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show($"HOŞGELDİNİZ. Sayın {m.Ad} {m.Soyad}");
                }

            }


        }
    }
}
