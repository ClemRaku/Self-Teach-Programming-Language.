using System;
namespace Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a words: ");
            string letters = Console.ReadLine();
            char[]  letter = letters.ToCharArray();//note this
            int duration_of_loop = letter.Length;
            int count_upper = 0;
            int count_lower = 0;
            for(int i = 0; i<duration_of_loop; i++)
            {
                if(Char.IsUpper(letter[i]))
                {
                    count_upper++;
                }
                else if(Char.IsLower(letter[i]))
                {
                    count_lower++;
                }
                else
                {
                    continue;
                }
            }
            if(count_lower == count_upper || count_lower > count_upper)
            {
                string lowercase_string = letters.ToLower();
                Console.WriteLine(lowercase_string);
            }
            else
            {
                string uppecase_string = letters.ToUpper();
                Console.WriteLine(uppecase_string);
            }
        }
    }
}