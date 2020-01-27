using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    interface IMusteriOzellikleri         // Musteri sınıfını oluşturmadan önce bu interfacei oluşturduk.
    {
                                          //Her bir müşteri için olması gereken metotlar tanımlıyoruz
        void HesapAc(int ekBakiye);      //Hesap açılırken ek bakiye gerekli.ek bakiyeyi parametre olarak int tipinde metoda veriyoruz.
        void HesapSil(int hesapNo);      // hesap silerken hesap numarası kullanıyoruz.
        void HesapParaYatir(Hesap h,decimal miktar); // Musteri hesapa para yatırabilmeli öncelikle Hesap adında bir
                                                     //sınıf oluşturup gerekli metotlara parametre olarak Hesap sınıfından  bir nesne veriyoruz.
                                                     //Ne kadar yatırıcağımızıda önemli.Bunun için decimal tipinde bir parametre geçiyoruz.
                                                   
        void HesapParaCek(Hesap h,decimal miktar);  // Hangi hesaptan ne kadar para cekilicek sorusunun cevabını metot içindeki parametrelere tanımlıyoruz.
    }
}
