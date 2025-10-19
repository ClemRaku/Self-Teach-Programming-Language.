using System;
namespace Exceptionals
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The division is: "+ num1/num2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}