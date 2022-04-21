using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpProductInterfaceSample
{
    public class ECommerceManager
    {

        //Bu metot pahalı ürünleri bana verir (fiyatı 100 den pahalıysa bu ürün pahalıdır)

        public List<IProduct> GetExpensiveProducts(List<IProduct> products)
        {
            List<IProduct> expensiveProducts = products.Where(q => q.UnitPrice > 100).ToList();

            return expensiveProducts;
        }

    }
}
