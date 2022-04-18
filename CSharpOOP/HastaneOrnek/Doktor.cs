using System;
namespace CSharpOOP.HastaneOrnek
{
    public class Doktor : BaseModel
    {

        public Doktor(string ad, string soyad)
        {
            this.Ad = ad; 
            this.Soyad = soyad;

        }

        public Doktor(string ad, string soyad, Poliklinik poliklinik)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Poliklinik = poliklinik;
        }

        public string Soyad { get; set; }

        public string SicilNo { get; set; }

        public Poliklinik Poliklinik { get; set; }
    }
}
