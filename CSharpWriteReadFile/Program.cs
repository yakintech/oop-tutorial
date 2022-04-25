using System;
using System.IO;


namespace CSharpWriteReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/Users/cagatayyildiz/Desktop/projects/oop-tutorial/CSharpWriteReadFile/user.txt";

            string path2 = "/Users/cagatayyildiz/Desktop/projects/oop-tutorial/CSharpWriteReadFile/cities.txt";

            string[] lines = File.ReadAllLines(path);

            //Tüm txt dökümanının içeriğini okur.
            string txtContent = File.ReadAllText(path);

            //foreach (var item in lines)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.Read();


            Console.WriteLine("Lütfen bir şehir söyleyiniz");
            string newCity = Console.ReadLine();


            //File.WriteAllText(path, txtContent + "\n" + newCity);
            //File.AppendAllText(path,"\n" + newCity);

            string[] cities = { newCity };

            File.AppendAllLines(path, cities);
            



        }
    }
}
