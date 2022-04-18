using System;
namespace CSharpOOP.Models
{
    public class Supplier : BaseModel
    {

        string _country = "Türkiye";

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Country {
            get
            {
                return _country;
            }
            set
            {
                _country = value.ToUpper();
            }
        }


        //public string County { get; set; } = "Türkiye";

    }
}
