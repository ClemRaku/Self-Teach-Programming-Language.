using System;
namespace Too_Long_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a Word: ");
            string word = Console.ReadLine();
            if(word.Length>10)
            {
                shorten(word);
            }
            else
            {
                Console.WriteLine(word);
            }
        }
        static void shorten(string wWword)
        {
            char first_letter = wWword[0];
            int numb = wWword.Length - 2;
            char last_letter = wWword[wWword.Length - 1];
            Console.WriteLine(first_letter+""+numb+""+last_letter);
        }
    }
}