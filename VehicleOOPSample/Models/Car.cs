using System;
namespace VehicleOOPSample.Models
{
    public class Car : Vehicle
    {
        public int VisaDate {
            get {
                return base.CalcVisaDate(ReleaseYear);
            }
        }

    }
}
