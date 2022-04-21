using System;
namespace CSharpAnimalInterfaceSample
{
    public class Cat : Animal, IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Miyav vb.");

        }
    }
}
