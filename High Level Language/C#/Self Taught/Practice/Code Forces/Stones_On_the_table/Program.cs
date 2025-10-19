using System;
using System.Xml.XPath;
namespace Stones_on_the_table
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(Enter number of stones = );
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(Enter colors of the stones = );
            string s = Console.ReadLine();
            int result = Stones_on_the_Table(n, s);
            Console.WriteLine(Stones taken out  + result);
        }
        public static int Stones_on_the_Table(int num_stones, string colors_stones)
        {
            int stones_taken_out = 0;
            for (int i = 0; i  num_stones - 1; i++)
            {
                if(colors_stones[i+1] == colors_stones[i])
                {
                    stones_taken_out++;
                }
            }
            return stones_taken_out;
        }

    }
}