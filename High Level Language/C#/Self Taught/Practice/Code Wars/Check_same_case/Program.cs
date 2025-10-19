using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
namespace Check_same_case//could've done better
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] a_b = Console.ReadLine().Split(' ');
            char a = Convert.ToChar(a_b[0]);
            char b = Convert.ToChar(a_b[1]);
            Console.WriteLine(SameCase(a, b));
        }
        public static int SameCase(char a, char b) 
        {
            bool a_uppercase = false;
            bool b_uppercase = false;
            bool neither = false;
            if(a >= 'a' && a <= 'z')
            {
                a_uppercase = false;
            }
            else if(a >= 'A' && a<= 'Z')
            {
                a_uppercase = true;
            }
            else
            {
                neither = true;
            }

            if(b >= 'a' && b <= 'z')
            {
                b_uppercase = false;
            }
            else if(b >= 'A' && b<= 'Z')
            {
                b_uppercase = true;
            }
            else
            {
                neither = true;
            }


            if(neither)
            {
                return -1;
            }
            else if(a_uppercase == b_uppercase)
            {
                return 1;
            }
            else
            {
                return 0;
            }

            return 0;
        }
    }
}