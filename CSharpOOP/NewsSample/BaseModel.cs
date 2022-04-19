using System;
namespace CSharpOOP.NewsSample
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        public DateTime AddDate { get; set; } = DateTime.Now;
    }
}
