using System;
using System.Diagnostics.CodeAnalysis;
namespace In_Search_of_an_Easy_Problem	
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num_of_peepes = Convert.ToInt32(Console.ReadLine());

            string yes_no = Console.ReadLine();
            bool easy = true;
            foreach(char num in yes_no)
            {
                if(num == '1')
                {
                    easy = false;
                    break;
                }
            }
            if(easy)
            {
                Console.WriteLine("EASY");
            }
            else
            {
                Console.WriteLine("HARD");
            }
        }
    }
}