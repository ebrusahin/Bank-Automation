using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    class Rapor
    {

        //Bu sınıfın içinde hangi işlemin yapıldığının özetini tutan string bir değişken belirtmemiz gerekiyor.
        public string rapor { get; set; }

        // İşlemlerin hangi tarihte yapıldığını bilmemiz gerekiyor.
        public DateTime tarih { get; set; }
    }
}
