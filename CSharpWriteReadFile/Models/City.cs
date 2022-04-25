using System;
namespace CSharpWriteReadFile.Models
{
    public class City : BaseModel
    {
        public string Name { get; set; }

        public Country Country { get; set; }
    }
}
