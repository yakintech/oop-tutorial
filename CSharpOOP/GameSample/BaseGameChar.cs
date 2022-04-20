using System;
namespace CSharpOOP.GameSample
{
    public abstract class BaseGameChar
    {

        public BaseGameChar(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public virtual void Hello()
        {
            Console.WriteLine("Hello!");
        }
        
    }
}
