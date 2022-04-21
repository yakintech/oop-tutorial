using System;
namespace CsharpProductInterfaceSample
{
    public class Phone : BaseModel, IProduct
    {
        public decimal UnitPrice { get; set; }
    }
}
