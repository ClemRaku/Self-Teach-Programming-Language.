using System;
using System.Runtime.CompilerServices;
namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type yes or no");
            Console.Write("Male: ");
            string Gender = Console.ReadLine();
            Console.Write("Tall: ");
            string Tall = Console.ReadLine();
            bool isMale;
            bool isTall;
            
            if(Gender == "yes" && Tall == "yes")
            {
                isMale = true;
                isTall = true;
            }
            else if(Gender == "no" && Tall == "no")
            {
                isMale = false;
                isTall = false;
            }
            else if(Gender == "yes" && Tall == "no")
            {
                isMale = true;
                isTall = false;
            }
            else
            {
                isMale = false;
                isTall = true;
            }

            
            if(isMale && isTall)
            {
                Console.WriteLine("You're Male & you're tall");
            }
            else if(isMale && !isTall)//'!' is negation operator
            {
                Console.WriteLine("You're a short male");
            }
            else if(!isMale && isTall )
            {
                Console.WriteLine("You're not a male but you're tall");
            }
            else
            {
                Console.WriteLine("You're not Male & and are short");
            }
        }
    }
}