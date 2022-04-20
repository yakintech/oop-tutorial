using System;
namespace CSharpOOP.Models
{
    public class Product  : BaseModel
    {
        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public double KDVPrice { get
            {
                return this.CalcKDVPrice(this.UnitPrice);
            }
        }

        public Category Category { get; set; }

        public Supplier Supplier { get; set; }


        public override string ToString()
        {
            return this.Name;
        }


        protected override double CalcKDVPrice(double price)
        {
            return price * 1.08;
        }

    }
}
