using System;
namespace CSharpOOP.OkulOrnek
{
    public class Ogrenci
    {
        public Ogrenci()
        {

        }

        public Ogrenci(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string No { get; set; }
        public Bolum Bolum { get; set; }
    }

}
