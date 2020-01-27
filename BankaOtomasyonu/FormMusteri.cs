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
     partial class FormMusteri : Form
    {
        public FormMusteri(Banka banka, BireyselMusteri bireyselMusteri)
        {
            InitializeComponent();
            this.banka = banka;
            this.bireyselM = bireyselMusteri;
            musteri = true;
        }
        public FormMusteri(Banka banka, TicariMusteri ticariMusteri)
        {
            InitializeComponent();
            this.banka = banka;
            this.ticariM = ticariMusteri;
            musteri = false;
        }
        Banka banka;
        BireyselMusteri bireyselM;
        TicariMusteri ticariM;
        bool musteri; 

        private void TabNavigationPage4_Paint(object sender, PaintEventArgs e)
        {

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

        private void SimpleButton5_Click(object sender, EventArgs e)
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

        private void SimpleButton6_Click(object sender, EventArgs e)
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

        private void SimpleButton7_Click(object sender, EventArgs e)
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

        private void BtnParaYatir_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtYatirHesapNo.Text);
            decimal miktar = Convert.ToInt32(txtYatirMiktar.Text);
            foreach (BireyselMusteri m in banka.bireyselMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo == h.No)
                    {
                        m.HesapParaYatir(h, miktar);
                    }
                }
            }


            foreach (TicariMusteri m in banka.ticariMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo == h.No)
                    {
                        m.HesapParaYatir(h, miktar);
                    }
                }
            }
        }

        private void BtnParaCek_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtCekHesapNo.Text);
            decimal miktar = Convert.ToInt32(txtCekMiktar.Text);

            foreach (BireyselMusteri m in banka.bireyselMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo==h.No)
                    {
                        m.HesapParaCek(h,miktar);
                    }
                }
            }


            foreach (TicariMusteri m in banka.ticariMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (hesapNo == h.No)
                    {
                        m.HesapParaCek(h, miktar);
                    }
                }
            }
        }

        private void BtnHavaleGonder_Click(object sender, EventArgs e)
        {
           
            int kaynakNo = Convert.ToInt32(txtHavaleNo.Text);
            int hedefNo = Convert.ToInt32(txtKaynakNo.Text);
            int miktar = Convert.ToInt32(txtHavaleMiktar.Text);
            decimal bankaPayi = 0.0m;

            Hesap kaynakHesap = null, hedefHesap = null;
            Musteri kaynakMusteri = null;

            bool kaynakDurum = false, hedefDurum=false,kaynakHesapTuru=false; // Kaynak hesap turu ticari false bireysel true :)

            string rapor;
            DateTime tarih;

            foreach (BireyselMusteri m in banka.bireyselMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (kaynakNo==h.No)
                    {
                        kaynakHesap = h;
                        kaynakMusteri = m;
                        kaynakDurum = true;
                        kaynakHesapTuru = true;
                    }
                    if (hedefNo==h.No)
                    {
                        kaynakHesap = h;
                        kaynakMusteri = m;
                        kaynakDurum = true;
                    }
                }

            }

            foreach (TicariMusteri m in banka.ticariMusteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (kaynakNo == h.No)
                    {
                        kaynakHesap = h;
                        kaynakMusteri = m;
                        kaynakDurum = true;
                        
                    }
                    if (hedefNo == h.No)
                    {
                        kaynakHesap = h;
                        kaynakMusteri = m;
                        kaynakDurum = true;
                    }
                }

            }

            if (kaynakDurum==true &&hedefDurum==true)
            {
                if (kaynakHesapTuru==false) //Kaynak hesap turu ticari müsteri ise
                {
                    if (kaynakHesap.bakiye>=miktar)
                    {
                        kaynakHesap.bakiye -= miktar;
                        hedefHesap.bakiye += miktar;

                        MessageBox.Show($"{kaynakHesap.No} numaralı hesabınızdan {hedefHesap.No} numaralı hesaba {miktar} TL gönderilmiştir.");
                        tarih = DateTime.Today;

                        rapor= ($"{kaynakHesap.No} numaralı hesabınızdan {hedefHesap.No} numaralı hesaba {miktar} TL gönderilmiştir.");
                        kaynakHesap.RaporEkle(rapor,tarih);

                        rapor = ($"{kaynakHesap.No} numaralı hesaptan {hedefHesap.No} numaralı hesabınıza {miktar} TL gönderilmiştir.");
                        hedefHesap.RaporEkle(rapor,tarih);

                    }
                    else
                    {
                        MessageBox.Show("Kaynak, Hedef bulunamadı veya bakiye yetersiz.");
                    }
                }
                else if (kaynakHesap.bakiye>=(miktar+miktar*2/100))
                {
                    kaynakHesap.bakiye -= miktar;
                    hedefHesap.bakiye += miktar;
                    bankaPayi = miktar + 2 / 100;
                    banka.toplamPara += bankaPayi;

                    MessageBox.Show($"{kaynakHesap.No} numaralı hesabınızdan {hedefHesap.No} numaralı hesaba {miktar} TL gönderilmiştir.");
                    tarih = DateTime.Today;

                    rapor = ($"{kaynakHesap.No} numaralı hesabınızdan {hedefHesap.No} numaralı hesaba {miktar} TL gönderilmiştir.");
                    kaynakHesap.RaporEkle(rapor, tarih);

                    rapor = ($"{kaynakHesap.No} numaralı hesaptan {hedefHesap.No} numaralı hesabınıza {miktar} TL gönderilmiştir.");
                    hedefHesap.RaporEkle(rapor, tarih);
                }
                else
                {
                    MessageBox.Show("Kaynak, Hedef bulunamadı veya bakiye yetersiz.");
                }
            }


        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            if (musteri == true)
            {
                dataGridHesaplarim.DataSource = bireyselM.hesaplar;

            }
            else
            {
                dataGridHesaplarim.DataSource = ticariM.hesaplar;

            }

        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            int hesapNo = 0;
            if (txtOzetHesapNo.Text!="") //hesap numarası boş değilse
            {
                hesapNo = Convert.ToInt32(txtOzetHesapNo.Text);
                DateTime timeBaslangic = timePickerBaslangic.Value;
                DateTime timeBitis = timePickerBitis.Value;

                int BaslangicGun = timeBaslangic.Day;
                int BitisGun = timeBitis.Day;

                List<Rapor> GosterilecekRaporlar = new List<Rapor>();

                foreach (Musteri m in banka.bireyselMusteriler)
                {
                    foreach (Hesap h in m.hesaplar)
                    {
                        
                        
                            if (hesapNo == h.No)
                            {
                                foreach (Rapor r in h.RaporListesi)
                                {
                                TimeSpan t = timeBitis - r.tarih;
                                int baslangicDegeri = t.Days;
                                TimeSpan t2 = r.tarih - timeBaslangic;
                                int bitisDegeri = t2.Days;

                                if (baslangicDegeri>=0 && bitisDegeri>=0)
                                {
                                    GosterilecekRaporlar.Add(r);

                                }


                                }
                                
                              }
                        
                    }
                }

                foreach (Musteri m in banka.ticariMusteriler)
                {
                    foreach (Hesap h in m.hesaplar)
                    {


                        if (hesapNo == h.No)
                        {
                            foreach (Rapor r in h.RaporListesi)
                            {
                                TimeSpan t = timeBitis - r.tarih;
                                int baslangicDegeri = t.Days;
                                TimeSpan t2 = r.tarih - timeBaslangic;
                                int bitisDegeri = t2.Days;

                                if (baslangicDegeri >= 0 && bitisDegeri >= 0)
                                {
                                    GosterilecekRaporlar.Add(r);

                                }


                            }

                        }

                    }
                }

                dataGridHesapOzeti.DataSource = GosterilecekRaporlar;



            }

            else
            {
                MessageBox.Show("Lütfen Hesap Numarası Giriniz!");
            }
        }
    }
}
