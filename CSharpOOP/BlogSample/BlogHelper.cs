using System;
using System.Globalization;

namespace CSharpOOP.BlogSample
{
    public class BlogHelper
    {

        public static string companyName = "Siemens Blog";

       //Aşağıdaki metot dışarıdan bir metin alır ve metin içerisinde bulunan tüm kelimelerin ilk harfini büyültüp diğer harflerini küçültecek şekilde metni return eder.

        public static string TitleCapitalize(string title)
        {
            TextInfo myTI = new CultureInfo("tr-TR", false).TextInfo;
            return myTI.ToTitleCase(title);
        }
    }
}
