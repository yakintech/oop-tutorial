using System;
namespace CSharpExtensionSample
{
    public static class StringExtensions
    {
        //Kelimedeki harf sayısı büyükse true değilse false döner
        public static bool CompareStrings(this string word, string compareWord)
        {
            if (compareWord.Length > word.Length)
                return true;
            else
                return false;
        }

        public static string Capitalize(this string word)
        {
            string result = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
            return result;
        }
    }
}
