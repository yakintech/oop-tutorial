using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpGameInterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Samurai> samuray = new List<Samurai>();
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };


            samuray.Count();

            fruits.Count();


            GameManager gameManager = new GameManager();

            Samurai samurai = new Samurai();
            samurai.City = "İzmir";


            Ninject ninject = new Ninject();
            ninject.KindOfSwarm = "Hattori Hanzo";



           // gameManager.WarmProcess(samurai);
            gameManager.WarmProcess(ninject);

        }
    }
}
