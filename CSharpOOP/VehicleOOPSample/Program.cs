using System;
using System.Collections.Generic;
using VehicleOOPSample.Models;

namespace VehicleOOPSample
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            car.ReleaseYear = 2018;
            car.OilLevel = 9;




            Truck truck = new Truck();
            truck.ReleaseYear = 2010;
            truck.OilLevel = 15;


            Console.WriteLine("Car Visa Date: " + car.VisaDate);
            Console.WriteLine("Truck Visa Date: " + truck.VisaDate);

            Console.Read();

        }
    }
}
