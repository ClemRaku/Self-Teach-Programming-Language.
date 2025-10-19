using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
namespace Lucky_Division
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string nSTRING = n.ToString();

            bool luckyNUMBER = true;

            foreach(char i in nSTRING)
            {
                if(i != '4' && i!= '7')
                {
                    luckyNUMBER = false;
                    break;
                }
            }

            if(!luckyNUMBER)
            {
                if(n%4 == 0 || n%7 == 0 || n%47 == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}