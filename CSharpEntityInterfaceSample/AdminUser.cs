using System;
namespace CSharpEntityInterfaceSample
{
    public class AdminUser : BaseModel
    {
        public string EMail { get; set; }

        public string Password { get; set; }
    }
}
