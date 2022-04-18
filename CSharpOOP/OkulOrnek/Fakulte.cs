using System;
namespace CSharpOOP.OkulOrnek
{
    public class Fakulte
    {

        public Fakulte()
        {

        }

        public Fakulte(string ad)
        {
            this.Ad = ad;
        }


        string _ad = "";

        public string Ad
        {
            get
            {
                return _ad.ToUpper();
            }
            set
            {
                _ad = value;
            }

        }

        public int KurulusYil { get; set; }
    }
}
