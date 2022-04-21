using System;
namespace CSharpGameInterfaceSample
{
    public class Samurai : IWarm
    {
        public string City { get; set; }

        public void Attack()
        {
            Console.WriteLine("Kaç yaşındasın sen?");
        }

        public void Defence()
        {
            Console.WriteLine("Samuray defans");
        }
    }
}
