using System;

namespace CSharpAnimalInterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalManager animalManager = new AnimalManager();

            Cat cat = new Cat();
            cat.Name = "Tekir";

            animalManager.Hello(cat);

        }
    }
}
