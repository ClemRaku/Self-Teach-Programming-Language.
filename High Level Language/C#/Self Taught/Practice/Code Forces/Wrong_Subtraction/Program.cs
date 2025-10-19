using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
namespace Wrong_Subtraction
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] n_k = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(n_k[0]);
            int k = Convert.ToInt32(n_k[1]);

            char digitTOCHECK = '0';

            string n_converted;


            for(int i = 0 ; i < k; i++)
            {
                n_converted = n.ToString();

                if(n_converted[^1] == digitTOCHECK)
                {
                    n /= 10;
                }
                else
                {
                    n--;
                }
            }
            Console.WriteLine(n);
        }
    }
}