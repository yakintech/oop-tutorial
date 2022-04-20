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

        protected virtual int CalcVisaDate(int releaseYear)
        {
            return releaseYear + 10;
        }
    }
}
