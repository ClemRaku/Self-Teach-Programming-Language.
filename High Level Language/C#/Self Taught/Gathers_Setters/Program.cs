using System;
using Gathers_Setters;
namespace Gathers_Settters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "DOG");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            Console.WriteLine(avengers.rating);
        }
    }
}