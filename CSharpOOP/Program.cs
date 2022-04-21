using System;
using CSharpOOP.Models;
using CSharpOOP.Games;
using CSharpOOP.BankSample;
using CSharpOOP.HastaneOrnek;
using CSharpOOP.OkulOrnek;
using CSharpOOP.BlogSample;
using CSharpOOP.NewsSample;
using CSharpOOP.GameSample;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            WebUser webUser = new WebUser();


            Console.WriteLine(webUser);
            Console.Read();
            

            Sovalye sovalye = new Sovalye("Abdullah");

            //Sovalye sovalye = new Sovalye();
            //sovalye.Hello();

            Console.Read();


            #region News
            News news = new News();

            Console.Write(news.SubContent);

            #region BlogPost

            BlogPost blogPost = new BlogPost();


            blogPost.Title = "barCelona ne oynadı be!";


            Console.WriteLine(blogPost.BlogCategory?.Name);

            //1. yol

            if (blogPost.BlogCategory != null)
            {
                Console.WriteLine(blogPost.BlogCategory.Name);

            }


            //2. yol

            Console.WriteLine(blogPost.BlogCategory?.Name);




            User user = new User();
            user.Password = "123";

            Console.Write(user.Password);


            Console.Write(blogPost.Title);
            Console.Read();

            //BlogHelper blogHelper = new BlogHelper();
            //blogHelper.TitleCapitalize("");

            BlogHelper.TitleCapitalize("");
            Math.Sin(30);
            Console.Write("");

            Console.Write(BlogHelper.companyName);
            #endregion

            #endregion



            #region hastaneSample
            Poliklinik poliklinik = new Poliklinik("KBB", 2000);


            Doktor doktor = new Doktor("Çağatay","Yıldız", poliklinik);
            Doktor doktor1 = new Doktor("Abdullah", "Tekin", poliklinik);

            Hasta hasta = new Hasta();
            hasta.Ad = "Mert";
            hasta.DogumTarih = new DateTime(1998, 1, 1);
            hasta.TCNo = "8842812491";


            Islem islem = new Islem();
            islem.Doktor = doktor;
            islem.Hasta = hasta;
            islem.IslemTarihi = DateTime.Now;
            islem.Not = "Grip olmuşum";

            //Bu işlemin olduğu polikliniği adı nedir?
            Console.WriteLine(islem.Doktor.Poliklinik.Ad);



            #endregion



            #region bankAccountSample
            BankAccount bankAccount = new BankAccount("Çağatay", 1000);


            while (true)
            {
                Console.WriteLine("Lütfen işlem tutarını giriniz.");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Lütfen işlem notunu giriniz");
                string note = Console.ReadLine();

                Console.WriteLine("İşleminiz para yatırma ise D çekme ise W tuşuna basıp entera basınız!");

                string operation = Console.ReadLine().ToLower();

                if (operation == "d")
                {
                    bankAccount.MakeDeposit(amount, DateTime.Now, note);
                }
                else if (operation == "w")
                {
                    bankAccount.MakeWithdrawal(amount, DateTime.Now, note);
                }
                else
                {
                    break;
                }

                Console.WriteLine("İşlem sonrasın mevcut bakiyeniz: " + bankAccount.Balance);

            }

            #endregion



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
