using System;
namespace CSharpOOP.HastaneOrnek
{
    public class Poliklinik : BaseModel
    {

        public Poliklinik()
        {

        }

        public Poliklinik(string ad, int yil)
        {
            this.KurulusYil = yil;
            this.Ad = ad;
        }

        public int KurulusYil { get; set; }
    }
}
