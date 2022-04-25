﻿using System;
using System.IO;
using System.Linq;

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
