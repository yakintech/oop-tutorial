using System;
namespace CSharpGameInterfaceSample
{
    public class Ninject : IWarm
    {
        public string KindOfSwarm { get; set; }

        public void Attack()
        {
            Console.WriteLine("Ninja hebele gübele");
        }

        public void Defence()
        {
            Console.WriteLine("Nijalar defansa");
        }
    }
}
