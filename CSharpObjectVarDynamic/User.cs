using System;
namespace CSharpObjectVarDynamic
{
    public class User
    {
        public string Name { get; set; }

        public object BirthDate { get; set; }

        public dynamic Address { get; set; }
    }
}
