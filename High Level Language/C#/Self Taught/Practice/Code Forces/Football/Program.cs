using System;
using System.Xml.XPath;
namespace Football
{
    class Program
    {
        public static void Main(string[] args)
        {
            string zeros_ones = Console.ReadLine();

            int count_1 = 0;
            int count_0 = 0;
            for(int i = 0; izeros_ones.Length; i++)
            {
                if(zeros_ones[i] == '1')
                {
                    count_0 = 0;
                    count_1++;
                    if(count_1 == 7)
                    {
                        break;
                    }
                }
                else if(zeros_ones[i] == '0')
                {
                    count_1 = 0;
                    count_0++;
                    if(count_0 == 7)
                    {
                        break;
                    }
                }
                else
                {
                    count_0 = 0;
                    count_1 = 0;
                }
            }

            if(count_0 == 7  count_1 == 7)
            {
                Console.WriteLine(YES);
            }
            else
            {
                Console.WriteLine(NO);
            }
            
        }
    }
}
