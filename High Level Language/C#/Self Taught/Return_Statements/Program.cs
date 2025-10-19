using System;
namespace Return_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Num: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(cube(n));
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}