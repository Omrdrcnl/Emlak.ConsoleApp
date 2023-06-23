using System;

namespace Emlak.ConsoleApp
{
    public class Emlak
    {
        public Adres Adres;
        public string IlanTarihi;
        public Musteri Sahibi;
        public decimal M2;
        private VergiDahil fiyat;

        public decimal FiyatVeri {
            get { return fiyat.GetFiyat(); }
            set { fiyat.SetFiyat(value); } 
                             }
        public Emlak() {
        fiyat= new VergiDahil();
        }
    }
    public class VergiDahil
    {
        private decimal fiyat;

        public decimal GetFiyat()
        {
            decimal VergiOranı = 0.18m;
            decimal VergiliFiyat = fiyat + (fiyat * VergiOranı);
            return VergiliFiyat;
        }
        public void SetFiyat(decimal value)
                    {
            if(value <= 0)
        {
            throw new ArgumentException("Fiyat 0 veya Daha küçük olamaz");
        }
            else
        {
            fiyat = value;
        }
        }
    }

    public class Konut : Emlak
    {
        public int Odasayisi;
        public string Cephe;
    }
    public class Arsa : Emlak
    {
        public double Alan;
        public string ImarDurumu;
    }
    public class Villa : Konut
    {
        public decimal BahceAlanı;
        public bool HavuzluMu;
    }

    public class SatilikVilla :Villa
    {
        public string YapiDurumu;
    }
    public class KiralikVilla :Villa
    {
        public bool EsyaLiMi;
    }
    public class Ev : Konut
    {
        public int Kat;
        public int KatSayisi;
        public bool SahibindenMi;
    }
    public class SatilikEv : Ev
    {
        public string yapiDurumu;
    }
    public class KiralikEv : Ev
    {
        public bool EsyaliMi;
    }
    public class SatilikArsa : Arsa
    {
        public bool TapuVarMi;
    }
    public class KiralikArsa : Arsa
    {
        public int KiraSüresi;
    }
    public class Musteri
    {
       
        public string Ad;
        public int Yas;
        public Adres Adres;
    }

    public class Adres
    {
        public string Sehir;
        public string Semt;
        public string Sokak;
        public string Ilce;
        public int no;
    }


}
