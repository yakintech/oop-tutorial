using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CSharpWriteReadFile.Models;


namespace CSharpWriteReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // *ülkeleri ekrana yazdır.
            //*kaç ülke var?
            //*a harfiyle başlayan ülkeleri ekrana yazdır.
            //* a harfiyle biten ülkeleri ekrana yazdır


            string path = "/Users/cagatayyildiz/Desktop/projects/oop-tutorial/CSharpWriteReadFile/countries.txt";

            string[] lines = File.ReadAllLines(path);



            string citiesPath = "/Users/cagatayyildiz/Desktop/projects/oop-tutorial/CSharpWriteReadFile/cities.txt";

            string[] citiesLines = File.ReadAllLines(citiesPath);

            List<City> cities = new List<City>();
            foreach (var item in citiesLines)
            {
                City city = new City();
                city.Name = item.Split(',')[0];

                Country country = new Country();
                country.Name = item.Split(',')[1];

                city.Country = country;


                cities.Add(city);

            }

            //bool istanbulVarMi = citiesLines.Any(q => q.ToLower().Contains("istanbul"));
            //Console.WriteLine("İstanbul var mı: " + istanbulVarMi);


            //var result = cities.GroupBy(q => q.Country.Name)
            //    .Select(x => new
            //{
            //    cityQuantity = x.Count(),
            //    countryName = x.FirstOrDefault().Country.Name
            //}).OrderByDescending(q => q.cityQuantity).ToList()[0];



            // Console.WriteLine("Country" + result.countryName);




            Console.Read();
              
            //txt den çektiği ülkeleri Country listesine ATA!!!

            //List<Country> countries = new List<Country>();

            //foreach (var item in lines)
            //{
            //    Country newCountry = new Country();
            //    newCountry.Name = item;

            //    countries.Add(newCountry);
            //}



            #region soru-1
            //Soru-1
            //* ülkeleri ekrana yazdır.
            //foreach (var item in lines)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.Read();
            #endregion

            #region soru-2
            //Soru-2
            //* kaç ülke var?
            //int countryCount = lines.Length;

            //Console.WriteLine("Toplam ülke: " + countryCount);

            #endregion

            #region soru-3
            //a harfiyle başlayan ülkeleri ekrana yazdır.

            //1.yol

            //foreach (var item in lines)
            //{
            //    if (item.ToLower().StartsWith('a'))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //2.yol

            // var countriesStartsA = lines.Where(q => q.ToLower().StartsWith('a')).ToList();

            // countriesStartsA.ForEach(item =>
            //{
            //    Console.WriteLine(item);
            //});
            #endregion

            #region soru-4
            //a harfiyle biten ülkeleri ekrana yazdır

            foreach (var item in lines)
            {
                if (item.ToLower().EndsWith("a"))
                {
                    Console.WriteLine(item);
                }
            }


            #endregion

            Console.Read();

            #region fileReadWriteSample

            //string path = "/Users/cagatayyildiz/Desktop/projects/oop-tutorial/CSharpWriteReadFile/user.txt";

            //string path2 = "/Users/cagatayyildiz/Desktop/projects/oop-tutorial/CSharpWriteReadFile/cities.txt";

            //string[] lines = File.ReadAllLines(path);

            ////Tüm txt dökümanının içeriğini okur.
            //string txtContent = File.ReadAllText(path);

            ////foreach (var item in lines)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////Console.Read();


            //Console.WriteLine("Lütfen bir şehir söyleyiniz");
            //string newCity = Console.ReadLine();


            ////File.WriteAllText(path, txtContent + "\n" + newCity);
            ////File.AppendAllText(path,"\n" + newCity);

            //string[] cities = { newCity };

            //File.AppendAllLines(path, cities);
            #endregion





        }
    }
}
