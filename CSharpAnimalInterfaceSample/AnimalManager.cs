using System;
namespace CSharpAnimalInterfaceSample
{
    public class AnimalManager
    {
        public void Hello(Animal animal)
        {
            Console.WriteLine(animal.Name + " isimli hayvan merhaba dedi!");
        }

        public void Byby(Animal animal)
        {
            Console.WriteLine(animal.Name + " isimli hayvan haydi görüşürüz dedi!");

        }
    }
}
