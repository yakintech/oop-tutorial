using System;
namespace CSharpOOP.HastaneOrnek
{
    public class BaseModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Ad { get; set; }

    }
}
