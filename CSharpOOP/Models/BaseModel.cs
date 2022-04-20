using System;
namespace CSharpOOP.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime AddDate { get; set; }



        protected virtual double CalcKDVPrice(double price)
        {
            return price * 1.18;
        }

    }
}
