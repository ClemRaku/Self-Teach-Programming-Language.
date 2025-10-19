using System;
using System.Runtime.CompilerServices;
namespace Three_Brothers
{
    class Program
    {
        public static void Main(string[] args)
        {

            string brothers_num = Console.ReadLine();
            
            string[] bro_nums = brothers_num.Split(' ');

            int brother1 = int.Parse(bro_nums[0]);
            int brother2 = int.Parse(bro_nums[1]);
            
            if(brother1 == 1 && brother2 == 2 || brother1 == 2 && brother2 ==1)
            {
                Console.WriteLine("3");
            }
            else if(brother1 == 1 && brother2 == 3 || brother1 == 3 && brother2 == 1)
            {
                Console.WriteLine("2");
            }
            else// if(brother1 == 2 && brother2 == 3)
            {
                Console.WriteLine("1");
            }
        }
    }
}