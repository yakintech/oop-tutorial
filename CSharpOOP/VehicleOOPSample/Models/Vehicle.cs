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

        public int Year { get; set; }

        protected virtual int CalcVisaDate(int year)
        {
            return year + 10;
        }
    }
}
