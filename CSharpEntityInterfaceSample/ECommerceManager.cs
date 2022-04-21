using System;
namespace CSharpEntityInterfaceSample
{
    public class ECommerceManager
    {
        //Bu metot sıralanabilir bir objenin 10 sonraki sırasını söyler
        public int SortData(ISort sort)
        {
            int resultNumber = sort.SortNumber + 10;

            return resultNumber;
        }
    }
}
