using System;
namespace CSharpOOP.Models
{
    public class Product 
    {
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public Category Category { get; set; }

        public Supplier Supplier { get; set; }


        public override string ToString()
        {
            return this.Name;
        }

    }
}
