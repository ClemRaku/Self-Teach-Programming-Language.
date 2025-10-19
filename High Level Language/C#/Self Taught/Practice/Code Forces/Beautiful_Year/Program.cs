using System;
using System.Diagnostics.CodeAnalysis;
namespace Beautiful_Year
{
    class Program
    {
        public static void Main(string[] args)
        {
            string word_year = Console.ReadLine();
            int num_year = Convert.ToInt32(word_year) + 1;
            bool distinct = false;

            int distinct_year = num_year+1;

            
            while(!distinct)
            {
                distinct = check_year(num_year);
                if(!distinct)
                {
                    
                    num_year++;
                }
                else
                {
                    distinct = true;
                    
                }
            }


            Console.WriteLine(num_year);
        }
        static bool check_year( int N_YEAR)
        {
            string W_YEAR = Convert.ToString(N_YEAR);
            for(int i=0; i < W_YEAR.Length; i++)
            {
                for(int j = i+1; j < W_YEAR.Length; j++)
                {
                    if(W_YEAR[j] == W_YEAR[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}