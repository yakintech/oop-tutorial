using System;
namespace EmlakSample
{
    public abstract class Emlak
    {

        public Emlak(string lokasyon)
        {
            this.Lokasyon = lokasyon;
        }
         
        public DateTime AddDate { get; set; } = DateTime.Now;

        public string ViewDate
        {
            get
            {
                return AddDate.ToString("dd MM yyyyy, dddd");
            }
        }

        public string Lokasyon { get; set; }
        public int Alan { get; set; }
        public decimal SatisFiyat { get; set; } = 0.0M;
        public decimal KiraFiyat { get; set; }

        public decimal SatisVergi
        {
            get
            {
                return SatisFiyat * 0.012M;
            }
        }


        public decimal KiraVergi
        {
            get
            {
                return KiraFiyat * 0.05M;
            }
        }

    }
}
