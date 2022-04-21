using System;
namespace CsharpProductInterfaceSample
{
    public class PC : BaseModel, IProduct
    {
        public decimal UnitPrice { get; set; }
    }
}
