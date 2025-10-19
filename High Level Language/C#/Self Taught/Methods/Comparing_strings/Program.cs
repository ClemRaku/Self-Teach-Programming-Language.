using System;
using System.Xml.XPath;
namespace Comparing_strings
{
    class Program
    {
        public static void Main(string[] args)
        {
            comparing_two_strings();
            comparing_two_ordinal_comparision(); //ignores case-sensitive
            comparing_two_culture_strings();
            comparing_two_culture_strings_ignoringCases();
            comparing_two_UNICODEvalues();
        }
        public static void comparing_two_strings()
        {
            string one = "abc";
            string two = "def";
            int compare = string.Compare(one, two);
            Console.WriteLine(compare);//will show minus one, since def is higher value than abc
        }
        public static void comparing_two_ordinal_comparision()
        {
            string one = "AbC";
            string two = "aBc";
            int compare = string.Compare(one, two, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(compare);//should be zero due to them being the same characters, ignoring the case.
        }
        public static void comparing_two_culture_strings()
        {
            string one = "straße";
            string two = "STRASSE";
            int result = string.Compare(one, two, StringComparison.CurrentCulture);
            Console.WriteLine(result);//will show -1, due to STRASSE being higher value. "ß" is of different culture
        }
        public static void comparing_two_culture_strings_ignoringCases()
        {
            string one = "straße";
            string two = "STRASSE";
            int result = string.Compare(one, two, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(result);//ignores upper or lowercase.
        }
        
        public static void comparing_two_UNICODEvalues()
        {
            string one = "ABC";
            string two = "abc";
            int result = string.Compare(one, two, StringComparison.Ordinal);
            Console.WriteLine(result);
        }

    }
}