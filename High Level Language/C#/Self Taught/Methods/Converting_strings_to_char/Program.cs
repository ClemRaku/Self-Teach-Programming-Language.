using System;
namespace Converting_strings_into_char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            char[] letter = word.ToCharArray();
            Console.Write("Position of the letter, you want to see: ");
            int Pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(letter[Pos-1]);
        }
    }
}