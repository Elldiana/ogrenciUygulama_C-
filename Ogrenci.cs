using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciUygulaması
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string ad;
        private string soyad;
        private string bolum;
        private int sinif;
        private int vizenot;
        private int finalnot;
        private int katilimNotu;
        private int projeNotu;
        private string okul;

        // Yapıcı Metot
        public Ogrenci(int _ogrenciNo, string _ad, string _soyad, string _bolum, int _sinif, int _vizenot, int _finalnot, int _katilimNotu, int _projeNotu, string _okul)
        {
            ogrenciNo = _ogrenciNo;
            ad = _ad;
            soyad = _soyad;
            bolum = _bolum;
            sinif = _sinif;
            vizenot = _vizenot;
            finalnot = _finalnot;
            katilimNotu = _katilimNotu;
            projeNotu = _projeNotu;
            okul = _okul;
        }

        public void ogrenciBilgileri()
        {
           Console.WriteLine("Öğrenci Numarası: " + ogrenciNo);
            Console.WriteLine("Adı: " + ad);
            Console.WriteLine("Soyadı: " + soyad);
            Console.WriteLine("Bölümü: " + bolum);
            Console.WriteLine("Sınıfı: " + sinif);
            Console.WriteLine("Vize Notu: " + vizenot);
            Console.WriteLine("Final Notu: " + finalnot);
            Console.WriteLine("Katılım Notu: " + katilimNotu);
            Console.WriteLine("Proje Notu: " + projeNotu);
            Console.WriteLine("Okulu: " + okul);
        }
        public double ortalamaHesapla()
        {
            double ortalama = (vizenot * 0.3) + (finalnot * 0.4) + (katilimNotu* 0.1)+ (projeNotu * 0.2);
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrenci okul isimi: " + okul);
        }
    }
}
