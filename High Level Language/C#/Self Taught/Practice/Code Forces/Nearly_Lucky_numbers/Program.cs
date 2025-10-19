using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
namespace Nearly_Lucky_number
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.Write("Enter: ");
            string integ = Console.ReadLine();
            int count_lucky = 0;
            bool nearlyLUKCY = false;
            foreach(char i in integ)
            {
                if(i == '4' || i == '7')
                {
                    count_lucky++;
                }
            }
            if(count_lucky == 7 || count_lucky == 4)
            {
                nearlyLUKCY = true;
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}