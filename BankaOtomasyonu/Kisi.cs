using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public abstract class Kisi   //İlk Olarak soyut Kisi sınıfını oluşturdum.public yaptım form kısmından ulaşabilmek için
    {
        public string Ad { get; set; }     // Değişkenleri kapsülleyerek oluşturalım
        public string Soyad { get; set; }   // Oop mantığı
        public string ID { get; set; }
        public string Sifre { get; set; }

    }
}
