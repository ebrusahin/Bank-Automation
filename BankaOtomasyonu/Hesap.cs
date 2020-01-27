using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    class Hesap:IRaporOzellikleri
    {
        public int No { get; set; } // Hesap numarası şart
        public decimal bakiye { get; set; }
        public decimal limit { get; set; }
        public decimal gunlukLimit { get; set; }
        public decimal ekBakiye { get; set; }
        public List<Rapor> RaporListesi; //Her bi yeni işlemde rapor sınıfından bir nesne oluşturcaz. Rapor ve tarih değişkenleini doldurduktan sonra
                                         //Burdaki(HesapSınıfının) RaporListesine ekliycez.Daha sonra datagrigdview ile ekrana bascaz.
        Rapor r;

        public Hesap()
        {
            RaporListesi = new List<Rapor>(); //Her yeni hesap açıldığında Raporlar listelensin
        }

        public void RaporEkle(string rapor, DateTime tarih)
        {
            r = new Rapor();
            this.r.rapor = rapor;
            this.r.tarih = tarih;
            RaporListesi.Add(r);

        }
    }
}
