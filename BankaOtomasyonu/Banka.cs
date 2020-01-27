using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
     class Banka : IBankaOzellikleri,IRaporOzellikleri
    {

        public List<Personel> personeller = new List<Personel>();
        public List<BireyselMusteri> bireyselMusteriler = new List<BireyselMusteri>();
        public List<TicariMusteri> ticariMusteriler = new List<TicariMusteri>();
        public List<Rapor> bankaRaporListesi = new List<Rapor>();
        public decimal toplamPara { get; set; }

        Personel p;
        BireyselMusteri bireyselmusteri;
        TicariMusteri ticariMusteri;

        Rapor r;
        string rapor;
        DateTime tarih;
 

       

        public void MusteriEkle(bool musteriTipi, string ad, string soyad, string ID, string sifre, DateTime tarih)
        {
            
            if (musteriTipi == true)
            {
                bireyselmusteri = new BireyselMusteri();

                this.bireyselmusteri.Ad = ad;
                this.bireyselmusteri.Soyad = soyad;
                this.bireyselmusteri.ID = ID;
                this.bireyselmusteri.Sifre = sifre;
                this.bireyselmusteri.Tarih = tarih;
                this.bireyselmusteri.musteriTipi = "Bireysel";

                bireyselMusteriler.Add(bireyselmusteri);
                System.Windows.Forms.MessageBox.Show("Bireysel Müşteri Başarıyla Eklendi.");

                rapor = ($"{ID} numaralı Bireysel Müşteri Başarıyla Eklendi.");
                tarih = DateTime.Today;
                RaporEkle(rapor, tarih);
            }
            else
            {
                ticariMusteri = new TicariMusteri();

                this.ticariMusteri.Ad = ad;
                this.ticariMusteri.Soyad = soyad;
                this.ticariMusteri.ID = ID;
                this.ticariMusteri.Sifre = sifre;
                this.ticariMusteri.Tarih = tarih;
                this.ticariMusteri.musteriTipi = "Ticari";
                System.Windows.Forms.MessageBox.Show("Ticari Müşteri Başarıyla Eklendi.");
                rapor = ($"{ID} numaralı Ticari Müşteri Başarıyla Eklendi.");
                tarih = DateTime.Today;
                RaporEkle(rapor,tarih);
            }
            

        }




        public void PersonelEkle(string ad, string soyad, string ID, string sifre)
        {
            p = new Personel();
            p.Ad = ad;
            p.Soyad = soyad;
            p.ID = ID;
            p.Sifre = sifre;

            personeller.Add(p);
            System.Windows.Forms.MessageBox.Show($"{ID} ID Numaralı Personel başarıyla eklendi.");

            rapor= ($"{ID} ID Numaralı Personel başarıyla eklendi.");
            tarih = DateTime.Today;
            RaporEkle(rapor,tarih);

        }

        public void PersonelSil(string kullaniciAdi)
        {
            foreach  (Personel p in personeller.ToList())
            {
                if (p.ID==kullaniciAdi)
                {
                    personeller.Remove(p);
                }
            }
            System.Windows.Forms.MessageBox.Show($"{kullaniciAdi} Personel başarıyla silindi.");
        }

        public void RaporEkle(string rapor, DateTime tarih)
        {

            r = new Rapor();
            this.r.rapor = rapor;
            this.r.tarih = tarih;
            bankaRaporListesi.Add(r);

        }
    }
}
