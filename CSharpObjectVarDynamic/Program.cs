using System;

namespace CSharpObjectVarDynamic
{
    class Program
    {
        static void Main(string[] args)
        {

            


            var name = "Çağatay";
            var number = -23;


            object city = "İstanbul";
            object price = 3.2M;
            object tax = 18;

            int result = Convert.ToInt32(tax) * 2;



            User user = new User();
            user.Name = "Çağatay";
            user.BirthDate = DateTime.Now;

           

            user.Address = "Vişnezade mah";
            user.Address = 3;

            Console.WriteLine(user.Address);
            Console.Read();


            string data = user.Address;



           
        }
    }
}
