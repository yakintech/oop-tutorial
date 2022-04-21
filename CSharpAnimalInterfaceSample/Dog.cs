using System;
namespace CSharpAnimalInterfaceSample
{
    public class Dog :Animal, IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Hav huv vb.");
        }
    }
}
