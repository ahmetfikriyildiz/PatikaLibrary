using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibrary
{
    // Bir kitap kaydetme uygulaması yapıldı. 2 adet constructor kullanıldı bunların biri default diğeri parametre alan türden diğer açıklamalar aşağıda yapılmıştır.

    public class Kitap
    {
        // Özellikler (Properties)
        public string Ad { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi { get; set; }

        // Parametresiz Yapıcı (Default Constructor)
        public Kitap()
        {
            KayitTarihi = DateTime.Now;   // Kayıt Tarihi o an olarak atanır
            Console.WriteLine("Yeni bir kitap kaydedildi.");
        }

        // Parametreli Yapıcı (Kitap Adı, Yazar Adı, Sayfa Sayısı ve Yayınevi)
        public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinevi;
            KayitTarihi = DateTime.Now;   // Kayıt Tarihi o an olarak atanır
            Console.WriteLine("Yeni bir kitap kaydedildi.");
        }

        // Bilgi yazdırma metodu
        public void KitapBilgileriYazdir()
        {
            Console.WriteLine($"Kitap Adı: {Ad}");
            Console.WriteLine($"Yazar: {YazarAdi} {YazarSoyadi}");
            Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
            Console.WriteLine($"Yayınevi: {Yayinevi}");
            Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");
        }
    }
    public class Book
    {

      
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Parametresiz yapıcı ile kitap nesnesi oluşturma
            Kitap kitap1 = new Kitap();
            kitap1.Ad = "Aylin";
            kitap1.YazarAdi = "Ayşe";
            kitap1.YazarSoyadi = "Kulin";
            kitap1.SayfaSayisi = 398;
            kitap1.Yayinevi = "Remzi Kitabevi";

            // Parametreli yapıcı ile kitap nesnesi oluşturma
            Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

            // Kitap bilgilerini yazdırma
            Console.WriteLine("Kitap 1 Bilgileri:");
            kitap1.KitapBilgileriYazdir();

            Console.WriteLine("\nKitap 2 Bilgileri:");
            kitap2.KitapBilgileriYazdir();
            Console.ReadKey();
        }
    }
}
