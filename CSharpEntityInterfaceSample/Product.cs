using System;
namespace CSharpEntityInterfaceSample
{
    public class Product : BaseModel, ISort
    {
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int SortNumber { get; set; }
    }
}
