using System;
namespace EmlakSample
{
    public class Arsa : Emlak
    {

        public Arsa(string lokasyon):base(lokasyon)
        {

        }


        public bool ImaraAcilMi { get; set; }
        public bool KopekVarMi { get; set; }
    }
}
