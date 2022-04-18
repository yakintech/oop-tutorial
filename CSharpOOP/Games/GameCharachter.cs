using System;
namespace CSharpOOP.Games
{
    public class GameCharachter
    {
        public string Name { get; set; }

        //Bir metotta virtual anahtar kelimesi varsa o metot miras verilen class tarafından override edilebilir, yani metot gövdesi değiştirilebilir!

        public virtual void Hello()
        {
            Console.WriteLine("Hello ! ");
        }

        public void By()
        {
            Console.WriteLine("By!");
        }

        public void LostGame()
        {
            Console.WriteLine(":(");
        }

        public void WinGame()
        {
            Console.WriteLine("oley be oley :)");
        }
    }
}
