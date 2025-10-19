using System;
using System.Runtime.CompilerServices;
namespace Way_too_long_words
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number_of_inputs = Convert.ToInt32(Console.ReadLine());
            string[] array_names = new string[number_of_inputs];

            for (int i = 0; i < number_of_inputs; i++)
            {
                array_names[i] = Console.ReadLine();
            }
            for (int j = 0; j < number_of_inputs; j++)
            {
                if (array_names[j].Length > 10)
                {
                    char first_letter = array_names[j][0];
                    char last_letter = array_names[j][array_names[j].Length - 1];
                    int middle_number = array_names[j].Length - 2;
                    Console.WriteLine($"{first_letter}{middle_number}{last_letter}");
                }
                else
                {
                    Console.WriteLine(array_names[j]);
                }
            }
        }
    }
}