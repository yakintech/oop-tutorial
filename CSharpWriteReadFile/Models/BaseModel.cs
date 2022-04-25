using System;
namespace CSharpWriteReadFile.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime AddDate { get; set; } = DateTime.Now;
    }
}
