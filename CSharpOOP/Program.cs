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
            Ninject ninject = new Ninject();

            Console.WriteLine(ninject);
        }
    }
}
