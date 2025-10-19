using System;
using System.Xml.XPath;
namespace Petya_and_strings
{
    class Program
    {
        public static void Main(string[] args)
        {

            string first_string = Console.ReadLine();
            string second_string = Console.ReadLine();
            int comparision_num = string.Compare(first_string, second_string, StringComparison.OrdinalIgnoreCase); //note this
            if(comparision_num < 0)
            {
                Console.WriteLine("-1");
            }
            else if(comparision_num > 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        

    }
}