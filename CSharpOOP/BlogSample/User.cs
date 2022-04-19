using System;
namespace CSharpOOP.BlogSample
{
    public class User
    {
        public string EMail { get; set; }

        string password = "";
        public string Password {
            get
            {
                return password;
            }
            set
            {
                password = BlogHelper.CreateMD5(value);
            }
        }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
