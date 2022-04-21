using System;
using System.Collections.Generic;

namespace CsharpProductInterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>();

            Phone phone = new Phone();
            phone.Name = "IPhone";
            phone.UnitPrice = 120;
            phone.HasCamera = true;

            Phone phone2 = new Phone();
            phone2.Name = "Asker telefonu";
            phone2.HasCamera = false;
            phone2.UnitPrice = 50;

            Phone phone3 = new Phone();
            phone3.Name = "Samsung";
            phone3.HasCamera = true;
            phone3.UnitPrice = 200;

            phones.Add(phone);
            phones.Add(phone2);
            phones.Add(phone3);

            ECommerceManager eCommerceManager = new ECommerceManager();

            var newPhones = eCommerceManager.GetExpensiveProducts(phones);

        }
    }
}
