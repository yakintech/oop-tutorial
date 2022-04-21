using System;

namespace CSharpEntityInterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "IPhone";
            product.SortNumber = 1;

            ECommerceManager eCommerceManager = new ECommerceManager();

            int result = eCommerceManager.SortData(product);
        }
    }
}
