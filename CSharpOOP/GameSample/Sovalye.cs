using System;
namespace CSharpOOP.GameSample
{
    public class Sovalye : BaseGameChar
    {


        public Sovalye(string name) : base(name)
        {

        }

        public override void Hello()
        {
            Console.WriteLine("Şovalye");
            base.Hello();
        }
    }
}
