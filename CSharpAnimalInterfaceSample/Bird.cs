using System;
namespace CSharpAnimalInterfaceSample
{
    public class Bird : Animal, IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("cik cuk vb.");
        }
    }
}
