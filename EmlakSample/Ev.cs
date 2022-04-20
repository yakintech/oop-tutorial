using System;
namespace EmlakSample
{
    public class Ev : Emlak
    {
        public Ev(string lokasyon,int odaSayisi): base(lokasyon)
        {
            OdaSayisi = odaSayisi;
        }


        public int OdaSayisi { get; set; }
        public int Kat { get; set; }
        public bool EbeveynBanyoVarMi { get
            {
                return LuksMu;
            }

        }
        public bool LuksMu { get; set; }

    }
}
