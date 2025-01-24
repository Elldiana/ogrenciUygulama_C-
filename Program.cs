namespace ogrenciUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(123, "Ali", "Veli", "Bilgisayar Mühendisliği", 2, 70, 80, 90, 100, "Gazi Üniversitesi");
            Console.WriteLine("Uygulammamıza Hoşgeldiniz.. Yapmak istediğiniz işlemi seçiniz: ");
            
            while (kontrol)
            {
                Menu();
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileri();
                        Console.WriteLine("----------------------------");
                        break;
                    case "2":
                        Console.WriteLine("Ortalama: " + ogrenci1.ortalamaHesapla());
                        Console.WriteLine("----------------------------");
                        break;
                    case "3":
                        ogrenci1.okulGetir();
                        Console.WriteLine("----------------------------");
                        break;
                    case "4":
                        kontrol = false;
                        break;

                }
            }
        }
        static void Menu()
        {
            Console.WriteLine("1- Öğrenci Bilgileri");
            Console.WriteLine("2- Ortalama Hesapla");
            Console.WriteLine("3- Okul Getir");
            Console.WriteLine("4- Çıkış");
        }
    }
}
