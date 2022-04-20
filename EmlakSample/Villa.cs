using System;
namespace EmlakSample
{
    public class Villa : Ev
    {
        public Villa(string lokasyon,int odaSayisi):base(lokasyon, odaSayisi)
        {

        }

        public bool HavuzVarMi { get; set; }
        public int BahceAlan { get; set; }
        public int GarajAlan { get; set; }

    }
}
