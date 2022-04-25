using System;
namespace CSharpExtensionSample
{
    public static class DateTimeExtensions
    {

        public static DateTime GetTomorrow(this DateTime dateTime)
        {
            return dateTime.AddDays(1);
        }
    }
}
