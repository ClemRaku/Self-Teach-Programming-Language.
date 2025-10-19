using System;
namespace number_User_input
{
    class Program
    {
        static void Main(string[] args)
        {   
            //this is how to store an int into a variable
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 6);
            //This is how to take input a int
            Console.Write("Enter Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num + num1);

            //now in the case for decimals
            Console.WriteLine("For the case of Decimals\n");
            Console.Write("Enter decimal first number: ");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second decimal number: ");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(d1 + d1);
        }
    }
}