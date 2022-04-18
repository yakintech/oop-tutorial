using System;
namespace CSharpOOP.Games
{
    public class Batman : GameCharachter
    {
        //Yapıcı, ayağa kaldırıcı metot!! Constructor metot
        public Batman()
        {

        }

        public Batman(string name, string city)
        {
            this.Name = name;
            this.City = city;
        }

        public string City { get; set; }

        public string Country { get; set; }




    }
}
