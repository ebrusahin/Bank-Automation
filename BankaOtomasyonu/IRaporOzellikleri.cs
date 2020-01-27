using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    interface IRaporOzellikleri // Rapor sınıfının metotlarını burda tanımlıyoruz.
    {
        void RaporEkle(string rapor,DateTime tarih);
    }
}
