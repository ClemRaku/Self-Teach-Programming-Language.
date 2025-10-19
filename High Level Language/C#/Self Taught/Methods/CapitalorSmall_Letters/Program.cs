using System;
namespace Capital_or_small
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            string uppercase = word.ToUpper();
            string lowercase = word.ToLower();
            Console.WriteLine($"Uppercase: {uppercase}\nLowercase: {lowercase}");
        }
    }
}