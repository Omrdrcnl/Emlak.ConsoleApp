using System;

namespace Emlak.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Emlak nesnesi oluşturma
            Emlak emlak = new Emlak();

            // Adres bilgilerini ayarlama
            emlak.Adres = new Adres()
            {
                Sehir = "Çorum",
                Semt = "Zafer",
                Sokak = "Kara Sokak",
                Ilce = "Alaca",
                no = 123
            };

            
           
            // Konut nesnesi oluşturma
            Konut konut = new Konut();
            konut.Adres = new Adres()
            {
                Sehir = "İstanbul",
                Semt = "Kadıköy",
                Sokak = "Örnek Sokak",
                Ilce = "Örnek İlçe",
                no = 789
            };

          

            konut.FiyatVeri = 200000;
            konut.IlanTarihi = DateTime.Now.ToString("dd.MM.yyyy");
            konut.Sahibi = new Musteri()
            {
               
                Ad = "Ayşe Karagöz",
                Yas = 35,
                Adres = new Adres()
                {
                    Sehir = "İstanbul",
                    Semt = "Çamlıdağ",
                    Sokak = "Karanfil Sokak",
                    Ilce = "Kadıköy",
                    no = 321
                }
            };
            konut.M2 = 120;
            konut.Odasayisi = 3;
            konut.Cephe = "Güney";

            // Konut özelliklerini ekrana yazdırma
            Console.WriteLine("\nSatılık Ev İlanı");
            Console.WriteLine("Adres: {0}", GetAdresString(konut.Adres));
            Console.WriteLine("Fiyat: {0}", konut.FiyatVeri);
            Console.WriteLine("İlan Tarihi: {0}", konut.IlanTarihi);
            Console.WriteLine("Sahibi: {0}", GetMusteriString(konut.Sahibi));
            Console.WriteLine("Metrekare: {0}", konut.M2);
            Console.WriteLine("Oda Sayısı: {0}", konut.Odasayisi);
            Console.WriteLine("Cephe: {0}", konut.Cephe);

            //Arsa Nesnesi Oluşturma
            Arsa arsa = new Arsa()
            {
                Alan = 250,
                IlanTarihi = "10.11.2022",
                ImarDurumu = "İmarlı",
                M2 = 250,
                FiyatVeri= 300000,


            };
            arsa.Adres = new Adres()
            {
                Sehir = "Ankara",
                Ilce = "Mamak",
                Semt = "Yukarı Ayrancılar",
                Sokak = "Daşdelen Sokak",
                no = 89
            };
            arsa.Sahibi = new Musteri()
            {
                Ad = "Haşmet Kara",
                Yas = 50,
                Adres = new Adres()
                {
                    Sehir = "Nigde",
                    Ilce = "Bor",
                    Semt = "Kırkbayır",
                    Sokak = "Dikili sokak",
                    no =40
                }
                
            };

            //Arsa nesnesini ekrana yazdırma
            Console.WriteLine("\nSatılık Arsa İlanı");
            Console.WriteLine("Arsa Adresi: {0}", GetAdresString(arsa.Adres));
            Console.WriteLine("Fiyat: {0}", arsa.FiyatVeri);
            Console.WriteLine("İlan Tarihi: {0}", arsa.IlanTarihi);
            Console.WriteLine("Sahibi: {0}", GetMusteriString(arsa.Sahibi));
            Console.WriteLine("Metrekare: {0}", arsa.Alan);
            
            Console.WriteLine("Arsa İmar Durumu:", arsa.ImarDurumu);
            

            // Kullanıcıdan fiyatı alarak emlak.FiyatVeri'yi ayarlama
            Console.WriteLine("\nLütfen Kiralık ev ilanı için Tutar giriniz: ");
            decimal fiyat = decimal.Parse(Console.ReadLine());
            emlak.FiyatVeri = fiyat;


            // İlan tarihini ayarlama
            emlak.IlanTarihi = DateTime.Now.ToString("dd.MM.yyyy");

            // Sahibi ayarlama
            emlak.Sahibi = new Musteri()
            {

                Ad = "Ahmet",
                Yas = 30,
                Adres = new Adres()
                {
                    Sehir = "Ankara",
                    Semt = "Dutluk",
                    Sokak = "yeşil Sokak",
                    Ilce = "Çankaya",
                    no = 456
                }
            };

            // Metrekareyi ayarlama
            emlak.M2 = 150;

            // Emlak özelliklerini ekrana yazdırma
            Console.WriteLine("Emlak Bilgileri");
            Console.WriteLine("Adres: {0}", GetAdresString(emlak.Adres));
            Console.WriteLine("Fiyat: {0}", emlak.FiyatVeri);
            Console.WriteLine("İlan Tarihi: {0}", emlak.IlanTarihi);
            Console.WriteLine("Sahibi: {0}", GetMusteriString(emlak.Sahibi));
            Console.WriteLine("Metrekare: {0}", emlak.M2);



            Console.ReadLine();
        }
            



        private static string GetAdresString(Adres adres)
        {
            return string.Format("{0} {1} {2} Mahallesi {3} No:{4}", adres.Sehir, adres.Ilce, adres.Semt,  adres.Sokak, adres.no);
        }

        private static string GetMusteriString(Musteri musteri)
        {
            return string.Format(" Ad Soyad: {0}, Yaş: {1}, Adres Bilgisi: {2}",  musteri.Ad, musteri.Yas, GetAdresString(musteri.Adres));
        }
        
    }   
}
