using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
   abstract class Musteri : Kisi, IMusteriOzellikleri    // (interfacein metotlarını implemente etmek zorundayız!)
    {
        public DateTime Tarih { get; set; }      //Musterinin kayıt olduğu tarih 
        public string musteriTipi { get; set; } 
        public List<Hesap> hesaplar;             // Musterinin sahip olduğu hesapların tutulduğu liste

        Hesap h;                                 //Hesap açarken yeni hesap nesnesi oluşturcaz. Hesap hesap= new Hesap(); 2,3 gibi gibi
        string rapor;                            // Hesaba ait işlmeleri listelemek için bir rapor değişkeni tuttuk ne kadar para çekildi yatırıldı gibi gibi
        DateTime tarih;                         //para çektim yatırdım falan ama hangi tarihte sorusu için :)

   
        public Musteri()                         //Yeni bir Musteri sınıfı oluşturduğumuzda 
                                                 //hesaplar listesinde yeni bir liste oluşturmasını istiyoruz.
        {
            hesaplar = new List<Hesap>();
        }

        public void HesapAc(int ekBakiye)        //Random bir hesap numarası vererek hesap açalım
        {
            Random r = new Random();
            int sayi = r.Next(100,999);             //Hesap numaramız 100 ile 999 arasında herhengi bir sayı olabilir
            h = new Hesap();
            h.No = sayi;
            h.bakiye = 0;
            h.ekBakiye = ekBakiye;
            h.limit = ekBakiye;
            h.gunlukLimit = 750;
            hesaplar.Add(h);
            System.Windows.Forms.MessageBox.Show($"{ID} Numaralı Müşteri İçin {sayi} numaralı hesap {ekBakiye} ek bakiyesi ile açılmıştır.");



        }

        public void HesapParaCek(Hesap h, decimal miktar)
        {
            if (h.ekBakiye!=0 && h.ekBakiye>0)
            {
                if (h.gunlukLimit!=0.0m && h.gunlukLimit>0)
                {
                    if (h.gunlukLimit-miktar>=0)
                    {
                        if (h.bakiye>=miktar)
                        {
                            h.bakiye -= miktar;
                            h.gunlukLimit -= miktar;

                            System.Windows.Forms.MessageBox.Show($"Bakiyenizden {miktar} TL çekilmiştir.");
                            rapor= ($"Bakiyenizden {miktar} TL çekilmiştir.");
                            tarih = DateTime.Today;
                            h.RaporEkle(rapor,tarih);
                        }
                        else if (h.bakiye>0)
                        {
                            if ((miktar-h.bakiye)<=h.ekBakiye)
                            {
                                decimal bakiyedenCekilen, ekbakiyedenCekilen;
                                bakiyedenCekilen = h.bakiye;
                                ekbakiyedenCekilen = miktar - bakiyedenCekilen;
                                h.ekBakiye -= ekbakiyedenCekilen;
                                h.gunlukLimit -= bakiyedenCekilen + ekbakiyedenCekilen;

                                System.Windows.Forms.MessageBox.Show($"{bakiyedenCekilen} TL Bakiyeden, {ekbakiyedenCekilen} Ek bakiyeden çekilmiştir.");
                                rapor= ($"{bakiyedenCekilen} TL Bakiyeden, {ekbakiyedenCekilen} Ek bakiyeden çekilmiştir.");
                                tarih = DateTime.Today;
                                h.RaporEkle(rapor,tarih);

                            }else
                                System.Windows.Forms.MessageBox.Show("Ek bakiye limitiniz bu işlem için yeterli değildir.");
                        }
                        else
                        {
                            if (h.ekBakiye>=miktar)
                            {
                                h.ekBakiye -= miktar;
                                h.gunlukLimit -= miktar;

                                System.Windows.Forms.MessageBox.Show($"{miktar} TL Ek Bakiyeden Çekilmiştir.");
                                rapor= ($"{miktar} TL Ek Bakiyeden Çekilmiştir.");
                                tarih = DateTime.Today;
                                h.RaporEkle(rapor,tarih);
                                    
                            }
                            else
                                System.Windows.Forms.MessageBox.Show("Bakiye ve Ek bakiye bu işlem için yeterli değildir.");
                        }
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Çekmek istediğinşz miktar kalan günlük para çekme limitinizden fazla olamaz.");
                }
                else
                    System.Windows.Forms.MessageBox.Show("Günlük para çekme limitiniz dolmuştur.");
            }else
                System.Windows.Forms.MessageBox.Show("İşlem başarısısz. \n Bakiye:0 \n Ek Bakiye : 0");
        }

        public void HesapParaYatir(Hesap h, decimal miktar)
        {
            decimal odenenBorc = 0;
            h.bakiye += miktar;
            System.Windows.Forms.MessageBox.Show($"Hesabınıza {miktar} TL eklenmiştir. \n Mevcut bakiye: {h.bakiye} TL");
            rapor= ($"Hesabınıza {miktar} TL eklenmiştir. \n Mevcut bakiye: {h.bakiye} TL");
            tarih = DateTime.Today;
            h.RaporEkle(rapor,tarih);

            if (h.bakiye<h.limit)
            {
                decimal borc = h.limit - h.ekBakiye;

                for (decimal i=h.ekBakiye; h.ekBakiye<h.limit;i+=0.1m )
                {
                    if (h.bakiye==0.0m)
                    {
                        break;
                    }
                    else
                    {
                        h.bakiye -= 0.1m;
                        odenenBorc += 0.1m;
                        h.ekBakiye += 0.1m;

                    }
                }
                System.Windows.Forms.MessageBox.Show($"{borc} TL Ek Bakiye borcunuzun {odenenBorc} TL kadarı bakiyenizden tahsil edilmiştir.");
                rapor= ($"{borc} TL Ek Bakiye borcunuzun {odenenBorc} TL kadarı bakiyenizden tahsil edilmiştir.");
                tarih = DateTime.Today;
                h.RaporEkle(rapor,tarih);

            }
                
        }

        public void HesapSil(int hesapNo)
        {
            foreach (Hesap h in hesaplar.ToList())
            {
                if (hesapNo==h.No)
                {
                    if (h.bakiye==0 && h.ekBakiye==h.limit)
                    {
                        hesaplar.Remove(h);
                        System.Windows.Forms.MessageBox.Show($"{hesapNo} numaralı hesap başarıyla silindi.");
                    }else
                        System.Windows.Forms.MessageBox.Show($"{hesapNo} numaralı hesap silinemedi.");
                }

            }
        }

    }
}










