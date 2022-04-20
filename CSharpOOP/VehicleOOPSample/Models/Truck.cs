using System;
namespace VehicleOOPSample.Models
{
    public class Truck : Vehicle
    {
        //Tırların vizesi 20 senede bir.

        public int VisaDate
        {
            get
            {
                return CalcVisaDate(ReleaseYear);
            }
        }


        public override bool isRefilOil
        {
            get
            {
                return isRefillOil(OilLevel - 10);
            }
        }


        protected override int CalcVisaDate(int releaseYear)
        {
            return releaseYear + 20;
        }



    }
}
