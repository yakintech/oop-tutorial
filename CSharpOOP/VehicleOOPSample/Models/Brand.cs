using System;
namespace VehicleOOPSample.Models
{
    public class Brand
    {
        public Brand(string name)
        {
            this.Name = name;
        }
        

        public string Name { get; set; }
        public string Logo { get; set; }
    }
}
