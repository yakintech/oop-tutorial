using System;
using CSharpOOP.Models;
using CSharpOOP.Games;
using CSharpOOP.BankSample;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {


            BankAccount bankAccount = new BankAccount("Çağatay", 1000);


            while (true)
            {
                Console.WriteLine("Lütfen işlem tutarını giriniz.");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("İşleminiz para yatırma ise D çekme ise W tuşuna basıp entera basınız!");

                string operation = Console.ReadLine().ToLower();

                if (operation == "d")
                {

                }
                else if(operation == "w")
                {

                }


            }


            //Batman batman = new Batman("Çağatay", "Erzurum");
            //Batman batman1 = new Batman();


            //Ninject ninject = new Ninject();
            //ninject.Hello();


            #region OOP-Sample-1

            //Instance aldım!

            Category category = new Category();
            category.Id = 3;
            category.Name = "Sport";
            category.Description = "Sport products";

            Supplier supplier = new Supplier();
            supplier.Country = "iran";
            supplier.CompanyName = "Siemens";
            supplier.ContactName = "Alp";


            Product product = new Product();
            product.Name = "IPhone";
            product.UnitPrice = 55;
            product.Category = category; //boxing
            product.Supplier = supplier; //boxing


            //Yukarıda instance alınan product ın categorysinin adını console a yazdır
            // Console.WriteLine(product.Category.Name); //unboxing

            //Yukarıda instance alınan product ın suppler ının companyName console a yazdır. DİLEK?
            // Console.WriteLine(product.Supplier.CompanyName); //unboxing

            Console.WriteLine(product);
            Console.ReadLine();

            #endregion

        }
    }
}
