using System;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
namespace Alternating_sum_of_numbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int test_cases = Convert.ToInt32(Console.ReadLine());
            int[] length_of_the_sequence = new int[test_cases];
            string[] sequence = new string[test_cases];
            int[] result = new int[test_cases];
            int[] number_of_sequences = new int[test_cases];
            
            for(int i = 0 ; i < test_cases; i++)
            {
                number_of_sequences[i] = Convert.ToInt32(Console.ReadLine());
                sequence[i] = Console.ReadLine();
                string[] sequences = sequence[i].Split(' ');
                result[i] = Alternating_sum_of_numbers(sequences);
            }
            for(int j = 0; j < test_cases; j++)
            {
                Console.WriteLine(result[j]);
            }
            
        }
        public static int Alternating_sum_of_numbers(string[] sequences)
        {
            int[] int_sequence = new int[sequences.Length];
            for(int i = 0; i < sequences.Length; i++)
            {
                int_sequence[i] = int.Parse(sequences[i]);
            }

            bool minus = true;
            bool plus = false;
            int c = 0;
            int result = int_sequence[0];
            
            for(int j = 0; j < int_sequence.Length - 1; j++)
            {
                if(minus == true)
                {
                    result = result - int_sequence[j+1];
                    minus = false;
                    plus = true;
                    
                }
                else if(plus == true)
                {
                    result = result + int_sequence[j+1];
                    minus = true;
                    plus = false;
                }
                else
                {
                    continue;
                }
            }
            return result;
        }
    }
}