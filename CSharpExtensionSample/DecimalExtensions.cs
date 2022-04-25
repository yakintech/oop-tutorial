using System;
namespace CSharpExtensionSample
{
    public static class DecimalExtensions
    {

        public static string CurrencyFormat(this decimal money)
        {
            return money.ToString() + ".00";
        }
    }
}
