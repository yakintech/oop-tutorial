using System;
namespace CsharpProductInterfaceSample
{
    public class Monitor : BaseModel, IProduct
    {
        public decimal UnitPrice { get; set; }
    }
}
