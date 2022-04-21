using System;
namespace CsharpProductInterfaceSample
{
    public class Phone : BaseModel, IProduct
    {
        public bool HasCamera { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
