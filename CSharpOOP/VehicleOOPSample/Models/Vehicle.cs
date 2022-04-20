using System;
namespace VehicleOOPSample.Models
{

    //Id -> int
    //Brand -> Class
    //Year -> Int

    //CalcVisaDate protected virtual metot(int alır int döner. Dışarıdan aldığı yılın 10 sene sonrasını döner)



    public class Vehicle
    {
        public int Id { get; set; }

        public Brand Brand { get; set; }

        public int ReleaseYear { get; set; }

        public int OilLevel { get; set; }

        public virtual bool isRefilOil
        {
            get
            {

                return isRefillOil(OilLevel);
            }
        }


        protected virtual bool isRefillOil(int oilLevel)
        {
            if (oilLevel < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        protected virtual int CalcVisaDate(int releaseYear)
        {
            return releaseYear + 10;
        }
    }
}
