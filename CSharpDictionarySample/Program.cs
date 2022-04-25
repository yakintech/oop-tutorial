using System;
using System.Collections.Generic;

namespace CSharpDictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Key ler dictionary yapısında unique olmak zorunda!

            IDictionary<int, string> students = new Dictionary<int, string>();

            students.Add(1, "Çağatay");
            students.Add(2, "Abdullah");
            students.Add(33, "Şivan");
            students.Add(12, "Dilek");
            students.Add(5, "Mehmet");
            students.Add(6, "Burak");
            students.Add(7, "Emre");
            // students.Add(12, "Yunus Emre");


            Console.WriteLine(students[12]);

            //foreach (var item in students)
            //{
            //    Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            //}


            Console.Read();

        }
    }
}
