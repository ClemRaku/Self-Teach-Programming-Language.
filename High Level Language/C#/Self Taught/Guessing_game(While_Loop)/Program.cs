using System;
namespace Guesing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess Limit = 3\n");
            string answer = "";
            string correct_answer = "egg";
            int Guess_start = 0;

            while(answer != correct_answer && Guess_start < 3)
            {
                Console.WriteLine("What has to be broken before you can use it?");
                answer = Console.ReadLine();
                Guess_start++;
            }
            if(Guess_start>=3)
            {
                Console.WriteLine("You're out of turns to Guess");
            }
            else
            {
                Console.WriteLine("You GUESSED CORRECTLY!!");
            }
        }
    }
}