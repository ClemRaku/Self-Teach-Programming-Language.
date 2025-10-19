using System;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");//WriteLine basically goes to another line, where just write stays on single line
            string name = Console.ReadLine(); //ReadLine basically takes the user input, and stores in the value this line is assigned to
            Console.WriteLine("Hello "+name);
            Console.Write("Enter Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Your age is "+ age);
        }
    }
}