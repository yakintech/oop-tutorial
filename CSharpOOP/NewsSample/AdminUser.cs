using System;
using CSharpOOP.BlogSample;

namespace CSharpOOP.NewsSample
{
    public class AdminUser
    {

        string email = "";
        public string EMail {
            get
            {
                return email.ToLower();
            }
            set
            {
                email = value;
            }
        }

        string password = "";
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = BlogHelper.CreateMD5(value);
            }
        }
    }
}
