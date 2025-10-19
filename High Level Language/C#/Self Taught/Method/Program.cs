using System;
namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User's Name: ");
            string nam = Console.ReadLine();
            Console.Write("Enter Age: ");
            int boyosh= Convert.ToInt16(Console.ReadLine());
            SayHi(nam, boyosh);
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello, " + name + ".You're age is: " + age );
        }
    }
}

//Method is basically a Function