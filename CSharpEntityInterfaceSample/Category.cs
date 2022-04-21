using System;
namespace CSharpEntityInterfaceSample
{
    public class Category : BaseModel, ISort
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int SortNumber { get; set; }
    }
}
