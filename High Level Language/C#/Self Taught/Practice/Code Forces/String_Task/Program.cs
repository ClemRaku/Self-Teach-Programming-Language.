using System;
using System.Collections.Generic;
namespace String_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> vowels = new List<char>{'a', 'e', 'i', 'o', 'u', 'y'};//note this
            string word = Console.ReadLine();
            string lower_case_word = word.ToLower();
            int length = lower_case_word.Length;
            char[] letters = lower_case_word.ToCharArray();
            List<char> list_letters = new List<char>(letters);//note this
            //removing all the vowels
            List<char>List_without_vowels = remove_vowels(vowels, list_letters, length);
            //adding the period
            Console.WriteLine($".{string.Join('.', List_without_vowels)}");
        }
        public static List<char> remove_vowels(List<char>remove, List<char>given, int lenght_of_given)
        {
            int i = 0;
            while(i < given.Count)
            {
                if(remove.Contains(given[i]))
                {
                    given.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            return given;
        }
    }
}